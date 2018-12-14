using Microsoft.AspNetCore.SignalR;
using MonitoringApp.Services;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ChatAppReact.Hubs
{
	/// <summary>
	/// SignalR Hub class to enable socket communication and perform respective actions
	/// </summary>
	public class MonitoringHub : Hub
	{
        private readonly IDataService _dataService;

        public MonitoringHub(IDataService dataService)
        {
            _dataService = dataService;
        }


        public override Task OnConnectedAsync()
		{
			//Add Custom functionality here if required
			return base.OnConnectedAsync();
		}

		public override Task OnDisconnectedAsync(Exception exception)
		{
			return base.OnDisconnectedAsync(exception);
		}

		/// <summary>
		/// Invoked from WebsocketService in ClientApp when the connection is successfully created
		/// </summary>
		/// <param name="username"></param>
		public void Data()
		{
            while (true)
            {
                Clients.All.SendAsync("informationAdded", _dataService.GetDates());
                Thread.Sleep(100);
            }
        }
    }
}