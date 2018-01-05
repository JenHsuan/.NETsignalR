using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace signalR_MVC.Models
{
    class Info
    {
        public string conId { get; set; }
        public string  conStatus { get; set; }
        public string transport { get; set; }
        public string host { get; set; }
        public string port { get; set; }
        public string uname { get; set; }
    }

    [HubName("myhub")]
    public class MyHub: Hub
    {
        public override Task OnConnected()
        {
            Info i = new Info();
            i.conId = Context.ConnectionId.ToString();
            i.conStatus = Context.Headers["Connection"].ToString();
            i.transport = Context.QueryString["transport"];
            i.host = Context.Request.Url.Host;
            i.port = Context.Request.Url.Port.ToString();
            i.uname = Context.User.Identity.Name;

            return Clients.All.log(i);
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            return Clients.All.log("Disconnected" + DateTime.Now.ToString());
        }

        public void servermethod(string name, string msg)
        {
            string ConId = Context.ConnectionId.ToString();
            // call the clients connected to the hub
            Clients.All.clientmethod(name, ConId, msg);
        }
    }
}