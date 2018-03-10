﻿using System;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AcuriteInterceptorService
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	[Route("weatherstation/updateweatherstation")]
	public class InterceptorController : ApiController
	{
		public IHttpActionResult Get(string dateutc, string action, string realtime, string id, string mt, string sensor, decimal humidity, decimal tempf, decimal baromin, string battery, int rssi)
		{
			Console.WriteLine(String.Format("{0:dd/MM/yyyy HH:mm:ss} - Sensor: {1}, H: {2} T: {3:00.0}, P: {4}, Batt: {5}, Signal: {6}",
				DateTime.Now, sensor, humidity, (tempf - 32) * 5 / 9, baromin, battery, rssi));
			return Ok();
		}
	}
}