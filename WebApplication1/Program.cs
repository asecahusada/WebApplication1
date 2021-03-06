﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //This belongs to User02
            //Add another line for User02
            //This belongs to User03
            //2nd line for User03
            //This line is done via Github
            //Changes by gtberzerk
            //Changes by gtberzerk 2nd
            //Changes by asecahusada via github
            //Latest changes on Epic01 by asecahusada
            //Changes done on Epic01 via github
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
