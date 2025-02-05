using ProductsApp.API.Extensions;
using ProductsApp.Infra.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(config => config.LowercaseUrls = true);
builder.Services.AddSwaggerConfig(); //m�todo de extens�o
builder.Services.AddEntityFramework(builder.Configuration); //m�todo de extens�o

var app = builder.Build();

app.UseSwaggerConfig(); //m�todo de extens�o
app.UseAuthorization();
app.MapControllers();
app.Run();
