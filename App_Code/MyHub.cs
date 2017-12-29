using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyHub
/// </summary>

[HubName("myhub")]
public class MyHub:Hub
{
    public void serverMethod(string msg)
    {
        Clients.All.clientMethod(msg + " good morning");
        //return msg + " good morning";
    }
    public MyHub()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}