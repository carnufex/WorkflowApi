using App1.Controllers;
using App1.Data;
using App1.Data.Abstract;
using App1.Mediators;

using MediatR;

using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(ModelTranslator));
builder.Services.AddMediatR(typeof(PersonMediator).Assembly);
builder.Services.AddDbContext<IWorkloadsContext, WorkloadContext>(optionsBuilder =>
{
    optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("MyWorkloads"));
});
builder.Services.AddTransient<IWorkloadService, WorkloadService>();

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
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
