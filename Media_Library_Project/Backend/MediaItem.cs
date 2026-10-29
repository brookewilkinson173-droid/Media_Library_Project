public class MediaItem
{

    public int Id { get; set; }

    public required string Title { get; set; }

    public required Medium Medium { get; set; }

    public Dictionary<string, object?> Attributes { get; set; } = new();


    
}