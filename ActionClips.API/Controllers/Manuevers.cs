using ActionClips.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ActionClips.API.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class ManeuversController : ControllerBase {

        private ManeuverStore _store;
        public ManeuversController(ManeuverStore maneuverStore)
        {
            _store = maneuverStore;
        }

        [HttpGet]
        public IActionResult All() => Ok(_store.All);

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_store.All.FirstOrDefault(x => x.Id == id));

        [HttpPost]
        public IActionResult Create([FromBody] Models.Maneuver maneuver) {
            _store.Add(maneuver);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Models.Maneuver maneuver) {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            throw new NotImplementedException();
        }
    }
}