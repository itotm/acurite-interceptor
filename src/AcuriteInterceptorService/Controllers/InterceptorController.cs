using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AcuriteInterceptorService.Properties;

namespace AcuriteInterceptorService
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	[Route("weatherstation/updateweatherstation")]
	public class InterceptorController : ApiController
	{
		public IHttpActionResult Get([FromUri]SensorData data)
		{
			if (Settings.Default.ConsoleOutputEnabled)
			{
				Console.WriteLine(String.Format("{0:dd/MM/yyyy HH:mm:ss} - Sensor: {1}, H: {2} T: {3:00.0}, P: {4:0.}, Batt: {5}, Signal: {6}",
					DateTime.Now, data.Sensor, data.Humidity, data.Temperature, data.Pressure, data.Battery, data.Rssi));
			}

			if (Settings.Default.ForwardEnabled)
			{
				HttpClient client = new HttpClient();
				var response = client.GetAsync(Settings.Default.ForwardUri + Request.RequestUri.Query).Result;
				//Console.WriteLine(response.Content.ReadAsStringAsync().Result);
			}

			return Ok(Settings.Default.AcuriteApiResponse);
		}
	}
}
