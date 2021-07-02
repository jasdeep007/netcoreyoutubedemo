using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youtubedemonetcore.Hubs
{
    // we want server can find /chatHub to this class
    public class ChatHub : Hub
    {
        public readonly Iusers users;
        public ChatHub(Iusers _users)
        {
            users = _users;
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("newmessage", user, message);
        }
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("newuser", users.adduser());
        }
        public override async Task OnDisconnectedAsync(Exception ex)
        {
            await Clients.All.SendAsync("userdisconnect", users.removeuser());
        }
    }
}
