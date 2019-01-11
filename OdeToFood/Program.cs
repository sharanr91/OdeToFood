using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace OdeToFood
{
    public class Program
    {
        //Entry point to the application - Main() Func
        //Takes command line arguments
        //Because Asp.Net Core application is structures as a console mode application
        //something we can run from command line.
        public static void Main(string[] args)
        {
            //this entry point to the application will build an web host
            //passing along any arguments from the command-line, and tell that web host/server to start running
            BuildWebHost(args).Run();
        }

        //IIS Express acts much like a proxy server, it is going to forward requests into my application.
        //But my application itself is a seperate process that is up and running and has its own server
        //That web server is configured inside of "BUILDWEBHOST()"
        //we are doing that by using a class from "microsoft.aspnetcore.hosting"

        public static IWebHost BuildWebHost(string[] args) =>
            //webhost class that has a static method that makes this easy to spin up a web server , its called createdefaultBuilder();
            //there are additional methods to customise the builder but now its simple.
            WebHost.CreateDefaultBuilder(args)
            //we are telling webhost builder to use startup.cs class to configure  how the application should behave
                .UseStartup<Startup>()
                .Build();
    }
}
