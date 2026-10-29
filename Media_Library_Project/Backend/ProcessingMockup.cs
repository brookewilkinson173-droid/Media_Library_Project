
namespace Backend;

public class mockUpLibrary
{
    MediaItem[] arrayLibrary = new MediaItem[]
    {
        new MediaItem
        {
            Id = 1,
            Title = "The Great Gatsby",
            Medium = Medium.Book,
            Attributes = new Dictionary<string, object?>
            {
                ["description"] = "A novel about the American dream.",
                ["author"] = "F. Scott Fitzgerald",
                ["releaseYear"] = 1925
            }
        },
        new MediaItem
        {
            Id = 2,
            Title = "Inception",
            Medium = Medium.Movie,
            Attributes = new Dictionary<string, object?>
            {
                ["description"] = "A mind-bending thriller about dreams within dreams.",
                ["director"] = "Christopher Nolan",
                ["releaseYear"] = 2010
            }
        },
        new MediaItem
        {
            Id = 3,
            Title = "Thriller",
            Medium = Medium.Song,
            Attributes = new Dictionary<string, object?>
            {
                ["description"] = "Michael Jackson's iconic music album.",
                ["artist"] = "Michael Jackson",
                ["releaseYear"] = 1982,
                ["format"] = "Album"
            }
        },
        new MediaItem
        {
            Id = 4,
            Title = "The Matrix",
            Medium = Medium.Movie,
            Attributes = new Dictionary<string, object?>
            {
                ["description"] = "A sci-fi action film exploring virtual reality.",
                ["director"] = "The Wachowskis",
                ["releaseYear"] = 1999
            }
        },
        new MediaItem
        {
            Id = 5,
            Title = "To Kill a Mockingbird",
            Medium = Medium.Book,
            Attributes = new Dictionary<string, object?>
            {
                ["description"] = "A novel addressing racial injustice in the Deep South.",
                ["author"] = "Harper Lee",
                ["releaseYear"] = 1960
            }
        }
    };

    Dictionary<int, MediaItem> dictionaryLibrary = new();
    LinkedList<MediaItem> linkedListLibrary = new();
}
