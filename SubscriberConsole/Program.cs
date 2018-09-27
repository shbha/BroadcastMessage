using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SubscriberConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var lastMessage = string.Empty;
			var broadcastedStore = "BroadcastDataStore/WriteLines.txt";
			//var broadcastStorage = "/data/WriteLines.txt";
			while (true)
			{
				System.Threading.Thread.Sleep(5000);
				var content = System.IO.File.ReadAllText(broadcastedStore);
				if (lastMessage != content)
				{
					Console.WriteLine(content);
					lastMessage = content;
				}
			}
		}
	}
}
