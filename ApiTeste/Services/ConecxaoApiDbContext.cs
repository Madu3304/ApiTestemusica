using System.Net.Http;
using System.Text.Json;
using ApiTeste.Models;

namespace ApiTeste.Services
{
    public class ConecxaoApiDbContext
    {
        private readonly HttpClient _httpClient;

        public ConecxaoApiDbContext(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Musica_model>> GetSongsAsync(string? artist = null, string? genre = null, string? song = null)
        {
            var response = await _httpClient.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
            var allSongs = JsonSerializer.Deserialize<List<Musica_model>>(response);


            if (!string.IsNullOrEmpty(artist)) //artista
            {
                allSongs = allSongs.Where(song => song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(song)) //musica
            {
                allSongs = allSongs.Where(song => song.Song.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(genre)) //gênero
            {
                allSongs = allSongs.Where(song => song.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return allSongs;
        }

    }
}
