using ApiTeste.Data;
using ApiTeste.Models;
using ApiTeste.Services;
using Microsoft.Extensions.DependencyInjection;


        var builder = WebApplication.CreateBuilder();

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddHttpClient<ConecxaoApiDbContext>(client =>
        {
            client.BaseAddress = new Uri("https://guilhermeonrails.github.io/api-csharp-songs/");
        })
        .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
        {
        ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
        });


        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run(); 

//https://medium.com/reprogramabr/consumindo-a-api-do-spotify-um-breve-passo-a-passo-fd210312fdd

//https://balta.io/blog/minimal-apis-especificar-porta

//List<PlayList_model> songs = new();
//songs = await apiService.GetSongsAsync();
//songs = await apiService.GetSongsAsync(genre: musica);
//songs = await apiService.GetSongsAsync(artist: artist);
//songs = await apiService.GetSongsAsync(genre: genre);

//foreach (var song in songs)
//{
//    Console.WriteLine($"{song.Song} - {song.Artist} - {song.Duration_ms} -  {song.Year} - {song.Popularity} - {song.Danceability} - {song.Tempo} - {song.Genre}");
//}
