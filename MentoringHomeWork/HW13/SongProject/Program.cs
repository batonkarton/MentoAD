using Newtonsoft.Json;
using SongProject;

var song = new Song();
var askUser = new AskUser();
var songData = askUser.GetSongData(song);

var json = JsonConvert.SerializeObject(songData , Formatting.Indented);

Console.WriteLine(json);