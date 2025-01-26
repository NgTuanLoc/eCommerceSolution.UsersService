using eCommerce.Infrastructure;
using eCommerce.Core;
using eCommerce.API.Middlewares;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure();
builder.Services.AddCore();
builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// Add controllers to the service collection
builder.Services.AddControllers();

var app = builder.Build();

app.UseExceptionHandlingMiddleware();
// Routing
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Controller routes
app.MapControllers();
await app.RunAsync();
