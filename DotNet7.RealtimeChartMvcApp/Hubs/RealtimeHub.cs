using DotNet7.RealtimeChartMvcApp.Models;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DotNet7.RealtimeChartMvcApp.Hubs
{
    public class RealtimeHub : Hub
    {
        public async Task ServerReceiveMessage()
        {
            Random random = new Random();
            PieChartResponseModel model = new PieChartResponseModel()
            {
                Data = new PieChartModel()
                {
                    Series = new List<int> { random.Next(1,50), random.Next(1, 50), random.Next(1, 50), random.Next(1, 50) },
                    Labels = new List<string> { "A", "B", "C", "D" }
                }
            };
            await Clients.All.SendAsync("ClientReceiveMessage", JsonConvert.SerializeObject(model));
        }
    }
}
