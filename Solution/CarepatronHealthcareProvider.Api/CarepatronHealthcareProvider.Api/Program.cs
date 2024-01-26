using CarepatronHealthcareProvider.Data;
using CarepatronHealthcareProvider.Data.Repository;
using CarepatronHealthcareProvider.Domain;
using CarepatronHealthcareProvider.Domain.Mapper;
using CarepatronHealthcareProvider.Domain.Repository;
using CarepatronHealthcareProvider.Domain.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// DB
SetDbConnection();

// Injections
SetInjections();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
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

ApplyMigration();

app.Run();

void SetDbConnection()
{
    builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("CHPConnection"),
            b => b.MigrationsAssembly(typeof(DataContext).Assembly.FullName)));
}

void SetInjections()
{
    // Unit Of Work
    builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

    // Mapper
    //builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    builder.Services.AddAutoMapper(typeof(Program), typeof(DieticianPatientMapper));

    // Repositories
    builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
    builder.Services.AddTransient<IPatientRepository, PatientRepository>();
    builder.Services.AddTransient<ICompany1PatientRepository, Company1PatientRepository>();
    builder.Services.AddTransient<ICompany2PatientRepository, Company2PatientRepository>();
    builder.Services.AddTransient<IDieticianPatientRepository, DieticianPatientRepository>();
    builder.Services.AddTransient<IPrimaryHealthcareProviderPhysicalAssessmentRepository, PrimaryHealthcareProviderPhysicalAssessmentRepository>();

    // Services
    builder.Services.AddTransient<IPatientService, PatientService>();
    builder.Services.AddTransient<ICompany1PatientService, Company1PatientService>();
    builder.Services.AddTransient<ICompany2PatientService, Company2PatientService>();
    builder.Services.AddTransient<IDieticianPatientService, DieticianPatientService>();
}

void ApplyMigration()
{
    using (var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
    {
        scope.ServiceProvider.GetService<DataContext>()?.Database.Migrate();
    }
}