using Microsoft.EntityFrameworkCore;
using MovieApi.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

// ?? Veritabaný baðlantýsýný ekle
builder.Services.AddDbContext<MovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

// ?? Swagger'ý sadece Development ortamýnda aktif et
if (app.Environment.IsDevelopment())
{
    
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
