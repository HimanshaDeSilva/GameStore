var builder = WebApplication.CreateBuilder(args); //creates a new web application builder.
var app = builder.Build(); //builder.Build() method creates a web app instance

app.MapGet("/", () => "Hello World!"); // Sets up a simple GET route

app.Run(); // Starts the web server, making it listen for requests.
