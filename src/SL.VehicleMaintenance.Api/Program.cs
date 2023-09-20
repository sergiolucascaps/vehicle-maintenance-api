using SL.VehicleMaintenance.Infrastructure.CrossCutting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// register DI
builder.Services.RegisterServices();

// AutoMapper
builder.Services.AddAutoMapper(cfg => {
	cfg.AddProfile(new SL.VehicleMaintenance.Infrastructure.CrossCutting.AutoMapperProfiles.AutoMapper());
});

builder.Services.RegisterAppDbContext(connection: builder.Configuration.GetConnectionString("VehicleMaintenanceConnection"));

builder.Services.AddSwaggerGen();

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
