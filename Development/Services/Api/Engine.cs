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
        private  string _url;

        //PRIVATE
        private IDisposable _api;

        /// <summary>
        /// Engine Data
        /// </summary>
        /// <param name="url"></param>
        public Engine(Data.Engine engine)
        {
            _engine = engine;
           
        }

        /// <summary>
        /// Inicialize Web api
        /// </summary>
        /// <param name="url"></param>
        public void Inicialize(string url)
        { 
            _url = url;
            _api = WebApp.Start<Startup>(_url);
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
