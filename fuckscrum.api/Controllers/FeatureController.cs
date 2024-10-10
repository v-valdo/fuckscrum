using Microsoft.AspNetCore.Mvc;

namespace fuckscrum.api.Controllers
{
    [ApiController]
    [Route("api/projects/{projectId}/features")]
    public class FeatureController : ControllerBase
    {
        //api/projects/id/features
        [HttpGet()]
        public ActionResult ListAllFeatures(int projectId)
        {
            return Ok(new { message = $"all issues project {projectId}" });
        }

        [HttpGet("{id}")]
        public ActionResult GetFeatureById(int projectId, int id)
        {
            return Ok(new { message = $"issue {id} under {projectId}" });
        }

        [HttpPost()]
        public ActionResult CreateFeature(int projectId)
        {
            return CreatedAtAction(nameof(GetFeatureById), new { projectId, id = 123 }, new { message = $"created feature in project {projectId}" });
        }

        [HttpPut("{id}")]
        public ActionResult UpdateFeature(int projectId, int id)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteFeature(int projectId, int id)
        {
            return NoContent();
        }
    }
}