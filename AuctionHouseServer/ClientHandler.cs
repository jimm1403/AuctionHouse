using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AuctionHouseServer
{
	class ClientHandler
	{
		Thread clientThread;
		TcpClient client;
		StreamReader SR;
		StreamWriter SW;
		NetworkStream nws;
		public TcpClient Client { get { return client; } }

		public ClientHandler(TcpClient newClient)
		{
			client = newClient;

			nws = client.GetStream();
			SR = new StreamReader(nws);
			SW = new StreamWriter(nws);
		}

		public void HandleClient()
		{
			string message = "Hi client";
			while (true)
			{
				SendToClient(message);
				Thread.Sleep(3000);
			}
		}

		public void StartClient()
		{
			clientThread = new Thread(HandleClient);
			clientThread.Start();
		}
		public void SendToClient(string message)
		{
			SW.WriteLine(message);
			SW.Flush();
		}
		 
	}
}
