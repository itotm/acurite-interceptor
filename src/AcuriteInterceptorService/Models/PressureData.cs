using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuriteInterceptorService
{
	[Table("PressureData")]
	public class PressureData
	{
		private const decimal MIN2Millibar = 33.8637526m;

		[Key] public int PressureDataID { get; set; }
		public int Pressure { get; set; }

		public PressureData(decimal baromin)
		{
			this.Pressure = (int)Math.Round(baromin * MIN2Millibar, MidpointRounding.ToEven);
		}
	}
}
