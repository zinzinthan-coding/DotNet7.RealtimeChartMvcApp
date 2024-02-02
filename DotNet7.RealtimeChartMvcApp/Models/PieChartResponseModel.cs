namespace DotNet7.RealtimeChartMvcApp.Models
{
    public class PieChartResponseModel
    {
        public PieChartModel Data { get; set; }
    }

    public class PieChartModel
    {
        public List<int> Series { get; set; }
        public List<string> Labels { get; set; }
    }
}
