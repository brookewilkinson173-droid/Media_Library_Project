
public class WikiDataService
{
    
    private readonly HttpClient _httpClient;

    public WikiDataService(HttpClient httpClient)
    {
        this._httpClient = httpClient;
    }

    public async Task<string?> GetWikiDataJsonAsync(string entityId)
    {
        var response = await _httpClient.GetAsync($"{entityId}.json");
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }
        else
        {
            // Handle error response
            Console.WriteLine(response.StatusCode);
            return null;
        }
    }

}