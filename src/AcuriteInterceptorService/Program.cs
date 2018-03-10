using System;
using System.Configuration.Install;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Threading;
using AcuriteInterceptorService.Properties;

namespace AcuriteInterceptorService
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			if (args.Length > 0)
			{
				if (args[0] == "/i")
				{
					ManagedInstallerClass.InstallHelper(new string[] { Assembly.GetExecutingAssembly().Location });
				}
				else if (args[0] == "/u")
				{
					ManagedInstallerClass.InstallHelper(new string[] { "/u", Assembly.GetExecutingAssembly().Location });
				}
			}
			else
			{
				Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

				var wrapper = new WebAppWrapper().Start();
				Console.WriteLine("Interceptor activated. Press a key to stop.");
				Console.ReadKey();
				wrapper.Dispose();
			}
		}
	}
}
