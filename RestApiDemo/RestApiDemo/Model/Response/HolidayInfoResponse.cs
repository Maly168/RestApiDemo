using Newtonsoft.Json;

namespace RestApiDemo.Model.Response
{
    public class HolidayInfoResponse 
    {
        [JsonProperty("date")]
        public HolidayDateInfo Date { get; set; }

        [JsonProperty("name")]
        public List<HolidayNameInfo> Name { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }
    }

    public class HolidayNameInfo
    {
        [JsonProperty("lang")]
        public string Language { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class HolidayDateInfo
    {
        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }
        [JsonProperty("dayOfWeek")]
        public int DayOfWeek { get; set; }
    }

    public class GetHolidayResponse
    {
        public string Month { get; set; }
        public List<HolidayInfoResponse> HolidayInfo { get; set; }
    }
}
