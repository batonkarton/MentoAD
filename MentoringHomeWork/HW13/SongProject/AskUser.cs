namespace SongProject;

public class AskUser
{
    public object GetSongData(Song song)
    {
        AskSongInformation(song);

        var result = new { song.Name, AlbгmYear = song.AlbumYear, song.Artist, song.Minutes ,SongGenre = song.SongGenre.ToString()};
        return result;
    }

    private static void AskSongInformation(Song song)
    {
        Console.WriteLine("Please enter the name of the song:");
        song.Name = Console.ReadLine();

        Console.WriteLine("Please enter the year of the song:");
        song.AlbumYear = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the time of the song:");
        song.Minutes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the artist of the song:");
        song.Artist = Console.ReadLine();
        
        Console.WriteLine("Please enter the genre of the song (e.g. 0, 1, 2 or Classical, Rok, Romance...):");
        var genreInput = Console.ReadLine();

        if (int.TryParse(genreInput, out int genreNumber) && Enum.IsDefined(typeof(Song.Genre), genreNumber))
        {
            song.SongGenre = (Song.Genre)genreNumber;
        }
        else if (Enum.TryParse(genreInput, out Song.Genre parsedGenre))
        {
            song.SongGenre = parsedGenre;
        }
        else
        {
            Console.WriteLine("Invalid genre, setting default (Classical).");
            song.SongGenre = Song.Genre.Classical;
        }
    }
}