using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NetCloudGestMovies;
using NetCloudGestMovies.Domain.Films;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddValidation(); // Uniquement si validation imbriquée
builder.Services.AddHttpClient("api", o => { o.BaseAddress = new Uri("https://localhost:7217/api/"); });
builder.Services.AddSingleton<IList<Film>>(sp => new List<Film>
{
    new Film(1,  "Retour vers le futur", 1985),
    new Film(2,  "Blade Runner", 1982),
    new Film(3,  "E.T. l'extra-terrestre", 1982),
    new Film(4,  "Terminator", 1984),
    new Film(5,  "Terminator 2 : Le Jugement dernier", 1991),
    new Film(6,  "Les Aventuriers de l'arche perdue", 1981),
    new Film(7,  "L'Empire contre-attaque", 1980),
    new Film(8,  "Shining", 1980),
    new Film(9,  "Alien, le retour", 1986),
    new Film(10, "Piège de cristal", 1988),
    new Film(11, "SOS Fantômes", 1984),
    new Film(12, "Les Goonies", 1985),
    new Film(13, "Le Grand Bleu", 1988),
    new Film(14, "Scarface", 1983),
    new Film(15, "Le Silence des agneaux", 1991),
    new Film(16, "Jurassic Park", 1993),
    new Film(17, "Pulp Fiction", 1994),
    new Film(18, "Forrest Gump", 1994),
    new Film(19, "Les Évadés", 1994),
    new Film(20, "Léon", 1994),
    new Film(21, "Seven", 1995),
    new Film(22, "Le Dîner de cons", 1998),
    new Film(23, "Titanic", 1997),
    new Film(24, "Fight Club", 1999),
    new Film(25, "Matrix", 1999)
});
builder.Services.AddScoped<IFilmRepository, FilmService>();


await builder.Build().RunAsync();
