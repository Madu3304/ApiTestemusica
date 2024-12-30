namespace ApiTeste.Models
{
    public class Musica_model
    {
        public string? Artist { get; set; }
        public string? Song { get; set; }
        public float Duration_ms { get; set; }
        public int Year { get; set; }
        public int Popularity { get; set; }
        public float Danceability { get; set; }
        public float Tempo { get; set; }
        public string? Genre { get; set; }
    }
}
