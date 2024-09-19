var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHostedService<BackgroundWorkerService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
<<<<<<< Updated upstream
// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.

=======
>>>>>>> Stashed changes
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
