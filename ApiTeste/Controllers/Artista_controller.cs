using ApiTeste.Models;
using ApiTeste.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ApiTeste.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class Artista_controller : ControllerBase
    {
        private readonly ConecxaoApiDbContext _apiService;

        public Artista_controller(ConecxaoApiDbContext apiService)
        {
            _apiService = apiService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSongs([FromQuery] string? artist = null)
        {
            var artists = await _apiService.GetSongsAsync(artist);
            return Ok(artists);
        }
    }      
}
