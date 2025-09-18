using Microsoft.Owin.Hosting;
using System;

namespace LifeLog.Services.Api
{
	///<summary>
	///Api engine
	///</summary>
	public sealed class Engine : IDisposable
	{
		//INTERNAL
		internal static Engine Instance { get; private set; }

		//PRIVATE
		private static readonly object _lock = new object();
		private IDisposable _api;
		private bool _disposed;

		/// <summary>
		/// Construtor
		/// </summary>
		/// <param name="url"></param>
		public Engine(string url)
		{
			lock (_lock)
			{
				Instance?.Dispose();
				_api = WebApp.Start<Startup>(url);
				Instance = this;
			}
		}

		/// <summary>
		/// Dispose
		/// </summary>
		public void Dispose()
		{
			if (_disposed) return;
			_disposed = true;

			try { _api?.Dispose(); }
			finally
			{
				lock (_lock)
				{
					if (ReferenceEquals(Instance, this))
						Instance = null;
				}
				GC.SuppressFinalize(this);
			}
		}
	}
}