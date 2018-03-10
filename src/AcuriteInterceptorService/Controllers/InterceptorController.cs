using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AcuriteInterceptorService
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	[Route("weatherstation/updateweatherstation")]
	public class InterceptorController : ApiController
	{
		public IHttpActionResult Get([FromUri]SensorData data)
		{
			Console.WriteLine(String.Format("{0:dd/MM/yyyy HH:mm:ss} - Sensor: {1}, H: {2} T: {3:00.0}, P: {4:0.}, Batt: {5}, Signal: {6}",
				DateTime.Now, data.sensor, data.humidity, (data.tempf - 32) * 5 / 9, data.baromin * 33.8637526m, data.battery, data.rssi));

			if (Properties.Settings.Default.ForwardEnabled)
			{
				HttpClient client = new HttpClient();
				var response = client.GetAsync(Properties.Settings.Default.ForwardUri + Request.RequestUri.Query).Result;
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);
			}
			return Ok("{ \"checkversion\":\"224\" }");
		}
	}
}
