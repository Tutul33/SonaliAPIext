using Sonali.API.Utilities;
using Sonali.API.Utilities.FileManagement;
using System.Net;
using System.Text.Json;

namespace Sonali.API.Middlewares
{
    public class ApiResponseMiddleware
    {
        private readonly RequestDelegate _next;

        public ApiResponseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Skip wrapping for static files (like images, css, js)
                if (context.Request.Path.StartsWithSegments("/uploads") ||
                    context.Request.Path.StartsWithSegments("/swagger") ||
                    Path.HasExtension(context.Request.Path))
                {
                    await _next(context);
                    return;
                }

                // Capture the response body
                var originalBodyStream = context.Response.Body;

                using var responseBody = new MemoryStream();
                context.Response.Body = responseBody;

                await _next(context);

                // Read response body
                context.Response.Body.Seek(0, SeekOrigin.Begin);
                var bodyText = await new StreamReader(context.Response.Body).ReadToEndAsync();
                context.Response.Body.Seek(0, SeekOrigin.Begin);

                // If status code >= 400, wrap as error, otherwise success
                object? result;
                if (context.Response.StatusCode >= 400)
                {
                    result = ApiResponse<object>.ErrorResponse(
                        message: !string.IsNullOrEmpty(bodyText) ? bodyText : "An error occurred"
                    );
                }
                else
                {
                    // Try to deserialize JSON if body exists, otherwise null
                    object? data = null;
                    if (!string.IsNullOrWhiteSpace(bodyText))
                    {
                        try
                        {
                            data = JsonSerializer.Deserialize<object>(bodyText, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                        }
                        catch
                        {
                            data = bodyText; // fallback to raw string
                        }
                    }

                    result = ApiResponse<object>.SuccessResponse(data);
                }

                // Write the wrapped response
                context.Response.ContentType = "application/json";
                context.Response.Body = originalBodyStream;
                var json = JsonSerializer.Serialize(result, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                await context.Response.WriteAsync(json);
            }
            catch (FileValidationException ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Response.ContentType = "application/json";

                var errorResponse = ApiResponse<object>.ErrorResponse(
                    message: ex.Message
                );

                var json = JsonSerializer.Serialize(errorResponse, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                await context.Response.WriteAsync(json);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var errorResponse = ApiResponse<object>.ErrorResponse(
                    message: ex.Message,
                    errors: new List<string> { ex.StackTrace ?? string.Empty }
                );

                var json = JsonSerializer.Serialize(errorResponse, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                await context.Response.WriteAsync(json);
            }
        }
    }
}
