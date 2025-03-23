using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args); //creates a new web application builder.
var app = builder.Build(); //builder.Build() method creates a web app instance

List<GameDto> games = [
    new GameDto(1, "The Witcher 3: Wild Hunt", "RPG", 39.99m, new DateOnly(2015, 5, 19)),
    new GameDto(2, "God of War", "Action", 49.99m, new DateOnly(2018, 4, 20)),
    new GameDto(3, "Cyberpunk 2077", "RPG", 59.99m, new DateOnly(2020, 12, 10)),
    new GameDto(4, "Minecraft", "Sandbox", 29.99m, new DateOnly(2011, 11, 18)),
    new GameDto(5, "Elden Ring", "Action RPG", 59.99m, new DateOnly(2022, 2, 25)),
    new GameDto(6, "Red Dead Redemption 2", "Action", 49.99m, new DateOnly(2018, 10, 26)),
    new GameDto(7, "Halo Infinite", "Shooter", 59.99m, new DateOnly(2021, 12, 8)),
    new GameDto(8, "The Legend of Zelda: Breath of the Wild", "Adventure", 59.99m, new DateOnly(2017, 3, 3)),
    new GameDto(9, "Dark Souls III", "Action RPG", 39.99m, new DateOnly(2016, 3, 24)),
    new GameDto(10, "Grand Theft Auto V", "Open World", 29.99m, new DateOnly(2013, 9, 17))
];
app.MapGet("games" , ()=> games);

app.MapGet("/", () => "Hello World!"); // Sets up a simple GET route

app.Run(); // Starts the web server, making it listen for requests.
