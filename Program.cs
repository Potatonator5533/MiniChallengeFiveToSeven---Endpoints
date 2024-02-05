using MiniChallengeFiveToSeven___Endpoints.Services.Endpoint1;
using MiniChallengeFiveToSeven___Endpoints.Services.Endpoint2;
using MiniChallengeFiveToSeven___Endpoints.Services.Endpoint3;
using MiniChallengeFiveToSeven___Endpoints.Services.Endpoint4;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLib ,MadLib>();
builder.Services.AddScoped<IOddOrEven ,OddOrEven>();
builder.Services.AddScoped<IReverseIt_Alphanumeric ,ReverseIt_Alphanumeric>();
builder.Services.AddScoped<IReverseIt_NumbersOnly ,ReverseIt_NumbersOnly>();

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
