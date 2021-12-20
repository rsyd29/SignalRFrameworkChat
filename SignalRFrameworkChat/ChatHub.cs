using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRFrameworkChat
{
    public class ChatHub : Hub
    {
        public void Send(string messageJson)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(messageJson);
        }
    }
}