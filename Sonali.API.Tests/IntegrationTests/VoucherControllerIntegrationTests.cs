using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Tests.IntegrationTests
{
    public class VoucherControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public VoucherControllerIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetVoucherList_ReturnsSuccess()
        {
            // Act
            var response = await _client.GetAsync("/api/Voucher/GetVoucherList");

            // Assert
            response.EnsureSuccessStatusCode(); // Status code 200-299
            var content = await response.Content.ReadAsStringAsync();
            Assert.Contains("list", content); // Simplistic check
        }
    }
}
