public static class MediaAttributeDefinitions
{
    private static readonly Dictionary<Medium, IReadOnlyList<MediaAttribute>>
        Definitions = new()
    {
        [Medium.Book] = new List<MediaAttribute>
        {
            new MediaAttribute { Id = "author", DisplayName = "Author", DataType = MediaAttributeType.Text },
            new MediaAttribute { Id = "isbn", DisplayName = "ISBN", DataType = MediaAttributeType.Text },
            new MediaAttribute { Id = "publisher", DisplayName = "Publisher", DataType = MediaAttributeType.Text },
            new MediaAttribute { Id = "releaseYear", DisplayName = "Release Year", DataType = MediaAttributeType.Number },
            new MediaAttribute { Id = "genre", DisplayName = "Genre", DataType = MediaAttributeType.Text }
        },

        [Medium.Movie] = new List<MediaAttribute>
        {
            new MediaAttribute { Id = "director", DisplayName = "Director", DataType = MediaAttributeType.Text },
            new MediaAttribute { Id = "cast", DisplayName = "Cast", DataType = MediaAttributeType.Text },
            new MediaAttribute { Id = "runtime", DisplayName = "Runtime", DataType = MediaAttributeType.Number },
            new MediaAttribute { Id = "releaseYear", DisplayName = "Release Year", DataType = MediaAttributeType.Number },
            new MediaAttribute { Id = "genre", DisplayName = "Genre", DataType = MediaAttributeType.Text }
        },

        [Medium.Song] = new List<MediaAttribute>
        {
            new MediaAttribute { Id = "artist", DisplayName = "Artist", DataType = MediaAttributeType.Text },
            new MediaAttribute { Id = "album", DisplayName = "Album", DataType = MediaAttributeType.Text },
            new MediaAttribute { Id = "duration", DisplayName = "Duration", DataType = MediaAttributeType.Number },
            new MediaAttribute { Id = "releaseDate", DisplayName = "Release Date", DataType = MediaAttributeType.Date },
            new MediaAttribute { Id = "genre", DisplayName = "Genre", DataType = MediaAttributeType.Text }
        },

        [Medium.TVShow] = new List<MediaAttribute>
        {
            new MediaAttribute { Id = "creator", DisplayName = "Creator", DataType = MediaAttributeType.Text },
            new MediaAttribute { Id = "cast", DisplayName = "Cast", DataType = MediaAttributeType.Text },
            new MediaAttribute { Id = "numberOfSeasons", DisplayName = "Number of Seasons", DataType = MediaAttributeType.Number },
            new MediaAttribute { Id = "startDate", DisplayName = "Start Date", DataType = MediaAttributeType.Date },
            new MediaAttribute { Id = "genre", DisplayName = "Genre", DataType = MediaAttributeType.Text }
        }
    };

    public static IReadOnlyList<MediaAttribute> GetAttributes(Medium medium)
    {
        // Retrieve the attributes associated with the requested medium, if a definition exists.
        if (Definitions.TryGetValue(medium, out var attributes))
        {
            return attributes;
        }

        return Array.Empty<MediaAttribute>();
    }
}

/* public class MediaAttributeDefinitions
{
    internal static IReadOnlyList<MediaAttribute> GetAttributes(Medium medium)
    {

        switch (medium) {

        case Medium.Book:
            return new List<MediaAttribute>
            {
                new MediaAttribute { Id = "author", DisplayName = "Author", DataType = MediaAttributeType.Text },
                new MediaAttribute { Id = "isbn", DisplayName = "ISBN", DataType = MediaAttributeType.Text },
                new MediaAttribute { Id = "publisher", DisplayName = "Publisher", DataType = MediaAttributeType.Text },
                new MediaAttribute { Id = "releaseYear", DisplayName = "Release Year", DataType = MediaAttributeType.Number },
                new MediaAttribute { Id = "genre", DisplayName = "Genre", DataType = MediaAttributeType.Text },
                new MediaAttribute { Id = "title", DisplayName = "Title", DataType = MediaAttributeType.Text}

            };

        

        default:
            throw new NotImplementedException();
        }
    }
} */