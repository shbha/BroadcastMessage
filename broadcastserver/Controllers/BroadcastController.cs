using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;

namespace broadcastserver.Controllers
{
    public class BroadcastController : ApiController
    {
		[Route("broadcast/message/from/{from}/text/{message}")]
		[HttpGet]
		public IHttpActionResult Get(string from, string message)
		{
			//TODO

			try
			{
				//var broadcastStorage = "/data/WriteLines.txt";
			}
			catch (Exception ex)
			{
				//swallow
			}
			File.WriteAllLines(@"//MININT-9SH87KU/Users/shbha/BroadcastDataStore/WriteLines.txt", new string[] { message });
			
			return this.Ok($"Message from {from} was successfully broadcasted. Message: {message}");
			//write to file
		}
    }
}
