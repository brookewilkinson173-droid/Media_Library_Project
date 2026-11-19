public interface IMediaLibrary
{
    
    Task<MediaItem?> RetrieveByIdAsync(int id);
    Task<IReadOnlyList<MediaItem>>  RetrieveByAttributeAsync(string attribute, string value);
   
    //Task<IReadOnlyList<MediaAttribute>> GetAttributesAsync(Medium medium); //might need to change data type depending on databse implementation



}