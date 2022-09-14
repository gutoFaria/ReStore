using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// var host = WebApplication.CreateBuilder(args).Build();
// using var scope = host.Services.CreateScope();
// var context = scope.ServiceProvider.GetRequiredService<StoreContext>();
// var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

// try
// {
//     context.Database.Migrate();
//     DbInitializer.Initialize(context);
// }
// catch (System.Exception ex)
// {
//     logger.LogError(ex,"Problem migrating data");
// }
// finally
// {
//     scope.Dispose();
// }

// host.Run();

// Add services to the container.

/*
    MIGRATIONS
    dotnet ef migrations add InitialMigration
    dotnet ef database update
*/
builder.Services.AddDbContext<StoreContext>(opt =>
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(opt =>{
    opt.AllowAnyHeader()
        .AllowAnyMethod()
        .WithOrigins("http://localhost:3000");
});

app.UseAuthorization();

app.MapControllers();

app.Run();
