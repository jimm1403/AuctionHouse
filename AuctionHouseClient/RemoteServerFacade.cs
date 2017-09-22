using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHouseClient
{
	class RemoteServerFacade
	{
		TcpClient client;
		NetworkStream nws;
		StreamReader SR;
		StreamWriter SW;
		int port;
		string server;

		public RemoteServerFacade(int port, string server)
		{
			this.port = port;
			this.server = server;
			client = new TcpClient();

			nws = client.GetStream();

			SR = new StreamReader(nws);
			SW = new StreamWriter(nws);
		}
	}
}
