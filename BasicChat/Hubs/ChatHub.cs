using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace BasicChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToShortDateString();
            string time = dateTime.ToShortTimeString();
            await Clients.All.SendAsync("ReceiveMessage", user, message, date + " " + time);
        }
    }
}
