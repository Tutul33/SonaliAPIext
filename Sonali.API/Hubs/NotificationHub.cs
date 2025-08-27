using Microsoft.AspNetCore.SignalR;

namespace Sonali.API.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // Send to all clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendToUser(string connectionId, string message)
        {
            // Send to specific user
            await Clients.Client(connectionId).SendAsync("ReceiveMessage", "System", message);
        }
    }
}
