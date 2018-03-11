using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuriteInterceptorService
{
	public class WeatherDbContext : DbContext
	{
		public DbSet<SensorData> SensorDatas { get; set; }

		public WeatherDbContext() : base("Weather")
		{
		}
	}
}
