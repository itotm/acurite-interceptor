using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuriteInterceptorService
{
	public class SensorData
	{
		private const decimal MIN2Millibar = 33.8637526m;

		[NotMapped] public string DateUtc { get; set; }
		[NotMapped] public string Action { get; set; }
		[NotMapped] public string Realtime { get; set; }
		[NotMapped] public string Id { get; set; }
		[NotMapped] public string Mt { get; set; }
		public string Sensor { get; set; }
		public decimal Humidity { get; set; }
		[NotMapped] public decimal TempF { get; set; }
		[NotMapped] public decimal BaromIn { get; set; }
		public string Battery { get; set; }
		public int Rssi { get; set; }
		
		public decimal Temperature { get => (TempF - 32) * 5 / 9; set => TempF = value * 9 / 5 + 32; }
		public decimal Pressure { get => BaromIn * MIN2Millibar; set => BaromIn = value / MIN2Millibar; }
	}
}
