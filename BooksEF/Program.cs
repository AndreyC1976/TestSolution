using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using BooksEF.MyClasses.Books;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Подкючение к базе данных
// Подкючение к базе данных из Program.cs
//builder.Services.AddDbContext<BookContext>(options =>
//options.UseNpgsql("Host=localhost;Database=BooksEF;Username=postgres;Password=1234")); //BookStoreDB

// Подключение к базе данных через appsettings.json
var connectionString = builder.Configuration.GetConnectionString("BookStoreDB");
Console.WriteLine($"Строка подключения: {connectionString}");
builder.Services.AddDbContext<BookContext>(options =>
options.UseNpgsql(connectionString));

var app = builder.Build();

// Проверка подключения к БД
//using (var scope = app.Services.CreateScope())
//{
//    var context = scope.ServiceProvider.GetRequiredService<BookContext>();
//    try
//    {
//        context.Database.EnsureCreated(); // ← Попробует создать БД, если её нет
//        Console.WriteLine("✅ Подключение к БД успешно!");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"❌ Ошибка подключения: {ex.Message}");
//    }
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
