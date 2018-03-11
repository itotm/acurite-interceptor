using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuriteInterceptorService
{
	[Table("SensorData")]
	public class SensorData
	{
		private const decimal MIN2Millibar = 33.8637526m;

		[Key] public int SensorDataID { get; set; }

		[NotMapped] public string DateUtc { get; set; }
		[NotMapped] public string Action { get; set; }
		[NotMapped] public string Realtime { get; set; }
		[NotMapped] public string Id { get; set; }
		[NotMapped] public string Mt { get; set; }
		public string Sensor { get; set; }
		public int Humidity { get; set; }
		[NotMapped] public decimal TempF { get; set; }
		[NotMapped] public decimal BaromIn { get; set; }
		public string Battery { get; set; }
		public int Rssi { get; set; }
		
		public decimal Temperature { get => Math.Round((TempF - 32) * 5 / 9, 1, MidpointRounding.ToEven); set { } }
		public int Pressure { get => (int)Math.Round(BaromIn * MIN2Millibar, MidpointRounding.ToEven); set { } }
	}
}
