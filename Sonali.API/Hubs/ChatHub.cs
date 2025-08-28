using Microsoft.AspNetCore.SignalR;
using System.ServiceModel.Channels;

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
            // 1️⃣ Save to DB (if needed)
            //var msg = new Message
            //{
            //    Sender = sender,
            //    Receiver = receiver,
            //    Text = message,
            //    SentAt = DateTime.UtcNow
            //};

            //_db.Messages.Add(msg);
            //await _db.SaveChangesAsync();

            if (userConnections.TryGetValue(receiver, out var connId))
            {
                return Clients.Client(connId).SendAsync("ReceiveMessage", sender, message);
            }
            // 3️⃣ (Optional) Send ack back to sender
            //await Clients.Caller.SendAsync("MessageSent", msg.Id, msg.SentAt);
            return Task.CompletedTask;
        }
        public Task SendPrivateFile(string sender, string receiver, FileMessage fileMessage)
        {
            if (userConnections.TryGetValue(receiver, out var connId))
            {
                return Clients.Client(connId).SendAsync("ReceiveFile", sender, fileMessage);
            }
            return Task.CompletedTask;
        }
    }
    public class FileMessage
    {
        public string FileName { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public string FileData { get; set; } = string.Empty; // Base64
    }
}
