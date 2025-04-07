using SoapCore;
using WebAPISoapService.Services;
using static WebAPISoapService.Models.CustomerServiceContract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<ICustomerService, CustomerService>();
                              
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();
app.UseSoapEndpoint<ICustomerService>("/Services/CustomerService.asmx", new SoapEncoderOptions());

app.Run();
