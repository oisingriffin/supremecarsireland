var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Serve static files from wwwroot
app.UseStaticFiles();

// Set up a default page (index.html) with correct content type
app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/html"; // Ensure the content type is set to HTML
    await context.Response.SendFileAsync(Path.Combine(app.Environment.WebRootPath, "index.html"));
});

app.Run();
