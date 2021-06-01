using Microsoft.AspNetCore.Mvc;

namespace ActionClips.API.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase {

        [HttpGet]
        public string Index() {
            return "Hello World Oh no!";
        }

    }
}