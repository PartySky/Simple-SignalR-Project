using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SimpleSignalRProject
{
	public class MyHubs : Hub
	{
		public void Hello()
		{
			Clients.All.hello();
		}
	}
}