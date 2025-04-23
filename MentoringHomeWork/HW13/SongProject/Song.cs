namespace SongProject;

public class Song
{
    public string Name { get; set; }
    public int Minutes { get; set; }
    public string Artist { get; set; }
    public int AlbumYear { get; set; }
    public Genre SongGenre { get; set; }

    public enum Genre
    {
        Classical = 0,
        Rok = 1,
        Romance = 2,
        Jazz = 3,
        HipHop = 4
    }
}