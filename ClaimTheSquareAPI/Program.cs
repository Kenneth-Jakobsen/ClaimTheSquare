using ClaimTheSquare;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthorization();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();
const string path = "squares.json";
        
app.MapGet("/square", (int index, string text, string bgColor, string fontColor) => new TextObject
{
    Index =  index,
    Content = text,
    BgColor =  bgColor,
    FontColor = fontColor
});

app.MapPost("/square", (TextObject textObject) =>
{
    var squares = File.Exists(path)
        ? JsonSerializer.Deserialize<List<TextObject>>(File.ReadAllText(path)) ?? new()
        : new List<TextObject>();
            
    squares.Add(textObject);
    File.WriteAllText(path, JsonSerializer.Serialize(squares));
    return Results.Ok(textObject);
});
        
app.Run();