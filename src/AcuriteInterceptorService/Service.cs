using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace AcuriteInterceptorService
{
	partial class AcuriteInterceptor : ServiceBase
	{
		private WebAppWrapper _wrapper;

		public AcuriteInterceptor()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			var _wrapper = new WebAppWrapper().Start();
		}

		protected override void OnStop()
		{
			_wrapper.Dispose();
		}
	}
}
