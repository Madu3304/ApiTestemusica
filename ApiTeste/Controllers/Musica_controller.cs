using System.Net.Http;
using System.Text.Json;
using ApiTeste.Models;
using ApiTeste.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTeste.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class Musica_controller : ControllerBase
    {

        private readonly ConecxaoApiDbContext _apiService;

        public Musica_controller(ConecxaoApiDbContext apiService)
        {
            _apiService = apiService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSongs([FromQuery] string? song = null)
        {
            var songs = await _apiService.GetSongsAsync(song);
            return Ok(songs);
        }
    }
}   


