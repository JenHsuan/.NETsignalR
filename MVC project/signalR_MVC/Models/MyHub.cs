using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace signalR_MVC.Models
{
    [HubName("myhub")]
    public class MyHub: Hub
    {
        public override Task OnConnected()
        {
            return Clients.All.log("connected" + DateTime.Now.ToString());
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            return Clients.All.log("Disconnected" + DateTime.Now.ToString());
        }

        public void servermethod(string name, string msg)
        {
            // call the clients connected to the hub
            Clients.All.clientmethod(name, msg);
        }
    }
}