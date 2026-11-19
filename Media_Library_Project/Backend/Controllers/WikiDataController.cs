using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/wikidata")]
public class WikiDataController : ControllerBase
{
    private readonly WikiDataService _wikiDataService;

    public WikiDataController(WikiDataService wikiDataService)
    {
        _wikiDataService = wikiDataService;
    }

    [HttpGet("{entityId}")]
    public async Task<ActionResult<string>> GetJson(string entityId)
    {
        string? jsonData = await _wikiDataService.GetWikiDataJsonAsync(entityId);
        if (jsonData != null)
        {
            return Ok(jsonData);
        }
        else
        {
            return NotFound();
        }



    }
}