using IspRipCore.Services.IspDataProvider;
using IspRipCore.Services.IspStatusAggregator;
using IspRipCore.Services.IspStatusProvider;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IIspStatusAggregatorService, DummyIspAggregator>();
builder.Services.AddSingleton<IIspDataProviderService, DummyIspDataProvider>();
builder.Services.AddSingleton<IIspStatusProviderService, RipeStatusProvider>();

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