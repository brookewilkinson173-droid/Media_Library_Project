public enum MediaAttributeType
{
    Text,
    Number,
    Date,
    Boolean,
    Selection
}

public enum Medium
{
    Book,
    Song,
    Movie,
    TVShow
}

public class MediaAttribute
{
    public required string Id { get; init; }
    public required string DisplayName { get; init; }
    public required MediaAttributeType DataType { get; init; }
}