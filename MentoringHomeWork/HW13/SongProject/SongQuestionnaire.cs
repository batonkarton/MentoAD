namespace SongProject;
public static class SongQuestionnaire
{
    public static object GetSongData(Song song)
    {
        InputInformationFromUser(song);

        var result = new { song.Name, song.AlbumYear, song.Artist, song.Minutes, SongGenre = song.Genre.ToString() };
        
        return result;
    }

    private static void InputInformationFromUser(Song song)
    {
        ValidateName(song);
        ValidateYear(song);
        ValidateTime(song);
        ValidateArtist(song);

        ValidateGenre(song);
    }

    private static void ValidateGenre(Song song)
    {
        while (true)
        {
            Console.WriteLine("Please enter the genre of the song (e.g. 0, 1, 2 or Classical, Rock, Romance...):");
            var genreInput = Console.ReadLine();

            if (int.TryParse(genreInput, out int genreNumber) && Enum.IsDefined(typeof(Song.GenreOfMusic), genreNumber))
            {
                song.Genre = (Song.GenreOfMusic)genreNumber;
            }
            else if (Enum.TryParse(genreInput, out Song.GenreOfMusic parsedGenre) && Enum.IsDefined(typeof(Song.GenreOfMusic), parsedGenre))
            {
                song.Genre = parsedGenre;
            }
            else
            {
                Console.WriteLine("Invalid genre, setting default (Classical).");
                song.Genre = Song.GenreOfMusic.Classical;
            }

            return;
        }
    }

    private static void ValidateArtist(Song song)
    {
        while (true)
        {
            Console.WriteLine("Please enter the artist of the song:");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                song.Artist = input;
                
                break;
            } Console.WriteLine("Artist name cannot be empty. Please try again.");
        }
    }

    private static void ValidateTime(Song song)
    {
        while (true)
        {
            Console.WriteLine("Please enter the time of the song (in minutes):");
            var minutesInput = Console.ReadLine();
            if (int.TryParse(minutesInput, out var songMinute) && songMinute > 0)
            {
                song.Minutes = songMinute;
                
                break;
            } Console.WriteLine("Invalid time. Please enter a positive number.");
        }
    }

    private static void ValidateYear(Song song)
    {
        while (true)
        {
            Console.WriteLine("Please enter the year of the song:");
            var yearInput = Console.ReadLine();
            
            if (int.TryParse(yearInput, out var songAlbumYear))
            {
                song.AlbumYear = songAlbumYear;
                
                break;
            } Console.WriteLine("Invalid year. Please enter a valid year (1900-Current Year).");
        }
    }

    private static void ValidateName(Song song)
    {
        while (true)
        {
            Console.WriteLine("Please enter the name of the song:");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                song.Name = input;
                
                break;
            } Console.WriteLine("Song name cannot be empty. Please try again.");
        }
    }
}