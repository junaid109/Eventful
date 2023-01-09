using Eventful.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
try
{
    builder.Services.AddDbContext<DataContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        
    });

    // configure seed data into database
    using (var scope = builder.Services.BuildServiceProvider().CreateScope())
    {
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<DataContext>();
        context.Database.EnsureCreated();
        SeedData.SeedDatabase(context);
    }


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

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
