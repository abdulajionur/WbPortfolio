using WbPortfolio.Api.Extensions;
using WbPortfolio.Application.Extensions;
using WbPortfolio.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddApplicationLayer();
builder.Services.AddCors(options =>
{
    options.AddPolicy("BlazorWeb", builder =>
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapEndpoints(builder.Services);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("BlazorWeb");

app.Run();
