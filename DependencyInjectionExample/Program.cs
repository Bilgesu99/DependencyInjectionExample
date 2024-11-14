using DependencyInjectionExample;  // Teacher ve ClassRoom s�n�flar�n� kullanabilmek i�in
using DependencyInjectionExample.Interfaces;  // IOgretmen aray�z�n� kullanabilmek i�in

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Dependency Injection yap�land�rmas�
builder.Services.AddSingleton<IOgretmen, Teacher>();  // IOgretmen'i Teacher ile e�liyoruz
builder.Services.AddSingleton<ClassRoom>();            // ClassRoom'u DI container'�na ekliyoruz

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
