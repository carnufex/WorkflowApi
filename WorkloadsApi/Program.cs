using App1;
using App1.Controllers;
using App1.Data;
using App1.Data.Abstract;
using App1.Mediators;

using Azure.Identity;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddStatusList();
string keyVaultUrl = builder.Configuration["AzureKeyVault:Uri"];
if (!builder.Environment.IsDevelopment())
{
    _ = builder.Configuration.AddAzureKeyVault(new Uri(keyVaultUrl), new DefaultAzureCredential());
}

builder.Services.AddMediatorStuff();
builder.Services.AddDbStuff(config => config.GetConnectionString("MyWorkloads"));

builder.Services.AddControllers().AddApplicationPart(typeof(PersonController).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

using (IServiceScope scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<IWorkloadsContext>().EnsureExists();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}
_ = app.UseSwagger();
_ = app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
