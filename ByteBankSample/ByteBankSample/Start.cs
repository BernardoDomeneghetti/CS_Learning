using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Builder;
using System;

namespace ByteBankSample
{
    class Start
    {
        public static void Main(string[] args)
        {
            IWebHost host = WebHostBuilder()
                .UseKresnel()
                .UseStartup<StartUp>
                .Build();
        }

        
    }
}