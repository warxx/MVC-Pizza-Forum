﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHttpServer;
using SimpleMVC;

namespace PizzaForum.Appp
{
    class AppStart
    {
        static void Main()
        {
            HttpServer server = new HttpServer(8081, RouteTable.Routes);
            MvcEngine.Run(server, "PizzaForum.Appp");
        }
    }
}
