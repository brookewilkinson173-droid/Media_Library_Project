using Microsoft.AspNetCore.Mvc;


//namespace YourProject.Controllers;

[ApiController]
[Route("api/media-attributes")]
public class MediaAttributesController : ControllerBase
{
    // Endpoint 1: Return all available media types
    [HttpGet("media-types")]
    public ActionResult<IEnumerable<string>> GetMediaTypes()
    {
        return Ok(Enum.GetNames<Medium>());
    }

    // Endpoint 2: Return attributes for a selected medium
    [HttpGet("{medium}")]
    public ActionResult<IReadOnlyList<MediaAttribute>>
        GetAttributes(Medium medium)
    {
        var attributes = MediaAttributeDefinitions.GetAttributes(medium);

        return Ok(attributes);
    }
}