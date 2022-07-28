using Newtonsoft.Json;

namespace RestApiDemo.Model.Request
{
    public class HolidayInfoRequest
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }
    public class GetDayStatusRequest
    {
        public string Date { get; set; }
        public string Country { get; set; }
    }
}
