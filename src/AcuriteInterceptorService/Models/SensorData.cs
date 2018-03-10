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

		[NotMapped] public string dateutc { get; set; }
		[NotMapped] public string action { get; set; }
		[NotMapped] public string realtime { get; set; }
		[NotMapped] public string id { get; set; }
		[NotMapped] public string mt { get; set; }
		public string Sensor { get; set; }
		public decimal Humidity { get; set; }
		[NotMapped] public decimal tempf { get; set; }
		[NotMapped] public decimal baromin { get; set; }
		public string Battery { get; set; }
		public int Rssi { get; set; }
		
		public decimal Temperature { get => (tempf - 32) * 5 / 9; set => tempf = value * 9 / 5 + 32; }
		public decimal Pressure { get => baromin * MIN2Millibar; set => baromin = value / MIN2Millibar; }
	}
}
