using RestApiDemo.Model.Request;
using RestApiDemo.Model.Response;

namespace RestApiDemo.Services
{
    public interface IHolidayService
    {
        Task<List<HolidayInfoResponse>> GetHolidayFromApi(HolidayInfoRequest request);
    }
}