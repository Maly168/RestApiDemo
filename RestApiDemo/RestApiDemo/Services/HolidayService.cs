using Newtonsoft.Json;
using RestApiDemo.Model.Request;
using RestApiDemo.Model.Response;

namespace RestApiDemo.Services
{
    public class HolidayService : IHolidayService
    {
        private readonly IHttpClientService _httpClientService;
        private string _apiUrl;
        public HolidayService(IHttpClientService httpClientService, IConfiguration configuration)
        {
            _httpClientService = httpClientService;
            _apiUrl = configuration.GetValue<string>("ApiUrl");
        }
        public async Task<List<HolidayInfoResponse>> GetHolidayFromApi(HolidayInfoRequest request)
        {
            var url = $"{_apiUrl}action=getHolidaysForYear&year={request.Year}&country={request.Country}&holidayType=all";
            var apiResponse = await _httpClientService.Get(url);
            //if (apiResponse.Contains("error"))
            //{
            //    var errorMessage = JsonConvert.DeserializeObject<ApiErrorResponse>(apiResponse);
            //    throw new ApiErrorException(errorMessage.Error);
            //}
            var holidayInfo = JsonConvert.DeserializeObject<List<HolidayInfoResponse>>(apiResponse);

            return holidayInfo;
        }
    }
}
