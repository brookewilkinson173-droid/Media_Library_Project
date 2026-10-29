public interface IMediaLibrary
{
    
    Task<MediaItem?> retrievalByIdAsync(int id);
    Task<IReadOnlyList<MediaItem>>  retrievalByAttributeAsync(string attribute, string value);
    Task<IReadOnlyList<MediaAttribute>> GetAttributesAsync(Medium medium); //might need to change data type depending on databse implementation



}