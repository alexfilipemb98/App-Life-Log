using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace Api
{
    /// <summary>
    /// Api engine
    /// </summary>
    public class Engine : IDisposable
    {
        internal static Data.Engine _engine;

        private IHost _host;
        private string _url;

        public Engine(Data.Engine engine)
        {
            _engine = engine;
        }

        public void Inicialize(string url)
        {
            _url = url;

            _host = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls(_url);
                    webBuilder.UseStartup<Startup>(); // este Startup é o novo adaptado para Core
                })
                .Build();

            _host.Start();
        }

        public void Dispose()
        {
            _host?.Dispose();
        }
    }
}
