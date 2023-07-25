using ApiRealState.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Core;
using NuGet.Protocol.Core.Types;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddScoped<PaverloProjectContext, PaverloProjectContext>;
builder.Services.AddDbContext<PaverloProjectContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("YourConnectionStringKeyName_From_AppSettings.json")));
builder.Services.AddControllers();
//builder.Services.AddDbContext<PaverloProjectContext>;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();



//public void ConfigureServices(IServiceCollection services)
//{
//    services.AddDbContext<ApplicationDbContext>(options =>
//     options.UseInMemoryDatabase()
//    );
//    services.AddScoped<IRepository, MemoRepostory>();

//}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
