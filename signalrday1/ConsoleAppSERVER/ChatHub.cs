using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSERVER
{
    [HubName("ChatHub")]
    public class ChatHub : Hub
    {
        [HubMethodName("Message")]
        public void Message(string name, string Msg)
        {
            Clients.All.WriteMessage(name, Msg);
        }

    }
}
