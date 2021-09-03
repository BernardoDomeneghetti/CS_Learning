using Microsoft.AspNetCore.Hosting;

using System;

namespace ByteBankSample
{
    public class Start
    {
        public static void Main(string[] args)
        {
            IWebHost host = WebHostBuilder().Build();

        }
    }
}