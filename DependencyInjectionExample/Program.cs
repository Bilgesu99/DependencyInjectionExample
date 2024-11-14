using DependencyInjectionExample;  // Teacher ve ClassRoom sýnýflarýný kullanabilmek için
using DependencyInjectionExample.Interfaces;  // IOgretmen arayüzünü kullanabilmek için

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Dependency Injection yapýlandýrmasý
builder.Services.AddSingleton<IOgretmen, Teacher>();  // IOgretmen'i Teacher ile eþliyoruz
builder.Services.AddSingleton<ClassRoom>();            // ClassRoom'u DI container'ýna ekliyoruz

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
