using Newtonsoft.Json;
using SongProject;

var song = new Song();
var songQuestion = SongQuestionnaire.GetSongData(song);

var json = JsonConvert.SerializeObject(songQuestion , Formatting.Indented);

Console.WriteLine(json);