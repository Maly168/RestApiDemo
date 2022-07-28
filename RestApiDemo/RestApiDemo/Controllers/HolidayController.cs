using Microsoft.AspNetCore.Mvc;
using RestApiDemo.Model.Request;
using RestApiDemo.Model.Response;
using RestApiDemo.Services;

namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HolidayController : Controller
    {

        private readonly IHolidayService _holidayService;

        public HolidayController(IHolidayService holidayService)
        {
            _holidayService = holidayService;
        }

        [HttpPost("GetHoliday")]
        public async Task<List<HolidayInfoResponse>> GetHoliday(HolidayInfoRequest request)
        {
            return await _holidayService.GetHolidayFromApi(request);
        }
    }
}
