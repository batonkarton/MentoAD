namespace SongProject;

public class Song
{
    public enum GenreOfMusic
    {
        Classical = 0,
        Rock = 1,
        Romance = 2,
        Jazz = 3,
        HipHop = 4
    }

    public string Name { get; set; }
    public int Minutes { get; set; }
    public string Artist { get; set; }
    public int AlbumYear { get; set; }
    public GenreOfMusic Genre { get; set; }
}