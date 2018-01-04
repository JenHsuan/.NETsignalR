using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace signalR_MVC.Models
{
    [HubName("myhub")]
    public class MyHub: Hub
    {
    }
}