using Microsoft.AspNetCore.SignalR;

namespace Sonali.API.Hubs
{
    public class ChatHub : Hub
    {
        private static readonly Dictionary<string, string> userConnections = new();

        public override Task OnConnectedAsync()
        {
            var username = Context.GetHttpContext()?.Request.Query["username"].ToString();
            if (!string.IsNullOrEmpty(username))
            {
                userConnections[username] = Context.ConnectionId;
            }

            // notify all clients about active users
            Clients.All.SendAsync("ActiveUsers", userConnections.Keys.ToList());

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            var user = userConnections.FirstOrDefault(x => x.Value == Context.ConnectionId).Key;
            if (user != null)
            {
                userConnections.Remove(user);
                Clients.All.SendAsync("ActiveUsers", userConnections.Keys.ToList());
            }

            return base.OnDisconnectedAsync(exception);
        }

        public Task SendPrivateMessage(string sender, string receiver, string message)
        {
            if (userConnections.TryGetValue(receiver, out var connId))
            {
                return Clients.Client(connId).SendAsync("ReceiveMessage", sender, message);
            }

            return Task.CompletedTask;
        }
    }
}
