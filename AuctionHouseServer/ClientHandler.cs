using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHouseServer
{
	class ClientHandler
	{
		TcpClient client;
		StreamReader SR;
		StreamWriter SW;

		public ClientHandler(TcpClient newClient)
		{
			client = newClient;
			SR = new StreamReader(client.GetStream());
			SW = new StreamWriter(client.GetStream());
		}
		 
	}
}
