var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// Enable serving static files from wwwroot
app.UseDefaultFiles(); // This looks for index.html by default
app.UseStaticFiles();  // This serves the HTML/CSS/JS files

app.Run();
