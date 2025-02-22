using Microsoft.Owin.Hosting;
using System;

namespace Api
{
    /// <summary>
    /// Api engine
    /// </summary>
    public class Engine : IDisposable
    {
        //INTERNAL

        internal static Data.Engine _engine;

        //PRIVATE
        private IDisposable _api;

        /// <summary>
        /// Engine Data
        /// </summary>
        /// <param name="url"></param>
        public Engine(string url , Data.Engine engine)
        {
            _engine = engine;   
            _api = WebApp.Start<Startup>(url);
        }

        /// <summary>
        /// Discpose Web app
        /// </summary>
        public void Dispose()
        {
            _api.Dispose();
        }
    }
}
