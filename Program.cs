using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using ServiceLayer.Service.Contract;
using ServiceLayer.Service.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

//Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// DI
builder.Services.AddScoped<IUser, UserService>();

var app = builder.Build();

//Swagger UI (dev only — move outside if() to enable in all envs)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // browse /swagger
}

// Middleware
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
