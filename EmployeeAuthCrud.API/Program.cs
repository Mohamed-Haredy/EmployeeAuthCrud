using EmployeeAuthCrud.Domain;
using EmployeeAuthCrud.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*---------------------------------------------------------------------------------------------------*/
/*                                   Enable CORS                                                     */
/*---------------------------------------------------------------------------------------------------*/
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddSingleton<IDatabaseConnectionString>((serviceProvider) => new DatabaseConnectionString(builder.Configuration.GetConnectionString("Connection_DEV")));
//builder.Services.AddDatabaseConectionStrings(builder.Configuration);
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();


var app = builder.Build();
//Enable CORS
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
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
