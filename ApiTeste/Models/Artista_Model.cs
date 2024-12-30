namespace ApiTeste.Models
{
    public class Artista_Model
    {
        public string? Artist { get; set; }
        public string? Song { get; set; }
        public float Duration_ms { get; set; }
        public int Year { get; set; }
        public int Popularity { get; set; }
        public int Key { get; set; }
        public float Speechiness { get; set; }
        public float Acousticness { get; set; }
        public float Instrumentalness { get; set; }
        public float Liveness { get; set; }
        public float Valence { get; set; }
        public float Tempo { get; set; }
    }
}
