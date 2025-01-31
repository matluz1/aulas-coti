using ProductsApp.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(config => config.LowercaseUrls = true);
builder.Services.AddSwaggerConfig(); //m�todo de extens�o

var app = builder.Build();

app.UseSwaggerConfig(); //m�todo de extens�o
app.UseAuthorization();
app.MapControllers();
app.Run();
