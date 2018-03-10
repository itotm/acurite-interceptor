using System;
using System.Linq;
using Microsoft.Owin.Hosting;

namespace AcuriteInterceptorService
{
	public class WebAppWrapper : IDisposable
	{
		private IDisposable _webapp = null;

		public WebAppWrapper Start()
		{
			_webapp = WebApp.Start<Startup>(url: "http://+:80/");
			return this;
		}

		public void Dispose()
		{
			_webapp?.Dispose();
		}
	}
}
