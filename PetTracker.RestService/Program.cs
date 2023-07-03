using PetTracker.Business;
using PetTracker.Business.Abstraction;
using PetTracker.DataAccess.EntityRepositories;
using PetTracker.DataAccess.EntityRepositories.Abstraction;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InjectBusinessDependencies(builder);
InjectDataAccessDependencies(builder);

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



void InjectBusinessDependencies(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IUserService, UserService>();
    builder.Services.AddTransient<ICoiffeurService, CoiffeurService>();
    builder.Services.AddTransient<IFoodService, FoodService>();
    builder.Services.AddTransient<IMedicineService, MedicineService>();
    builder.Services.AddTransient<IPetService, PetService>();
    builder.Services.AddTransient<ITreatmentService, TreatmentService>();
    builder.Services.AddTransient<VaccineService, VaccineService>();
}

void InjectDataAccessDependencies(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<ICoiffeurRepository, CoiffeurRepository>();
    builder.Services.AddTransient<IFoodRepository, FoodRepository>();
    builder.Services.AddTransient<IMedicineDocumentRepository, MedicineDocumentRepository>();
    builder.Services.AddTransient<IMedicineRepository, MedicineRepository>();
    builder.Services.AddTransient<IPetRepository, PetRepository>();
    builder.Services.AddTransient<ITreatmentDocumentRepository, TreatmentDocumentRepository>();
    builder.Services.AddTransient<ITreatmentRepository, TreatmentRepository>();
    builder.Services.AddTransient<IUserRepository, UserRepository>();
    builder.Services.AddTransient<IVaccineRepository, VaccineRepository>();
}