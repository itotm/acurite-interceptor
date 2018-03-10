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
		[NotMapped] public string sensor { get; set; }
		[NotMapped] public decimal humidity { get; set; }
		[NotMapped] public decimal tempf { get; set; }
		[NotMapped] public decimal baromin { get; set; }
		[NotMapped] public string battery { get; set; }
		[NotMapped] public int rssi { get; set; }
		/*
		public string SensorID { get => sensor; set => sensor = value; }
		public decimal Humidity { get => humidity; set => humidity = value; }
		public decimal Temp { get => (tempf - 32) * 5 / 9; set => tempf = value * 9 / 5 + 32; }
		public decimal Pressure { get => baromin * MIN2Millibar; set => baromin = value / MIN2Millibar; }
		public string Battery { get => battery; set => battery = value; }
		public int Signal { get => rssi; set => rssi = value; }*/
	}
}
