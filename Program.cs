using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModel;
using StudentAdminPortal.API.Repositories;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// Add services to the container.


builder.Services.AddDbContext<StudentAdminContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentAdminPortalDb"));

});
builder.Services.AddScoped<IStudentRepository, SqlStudentRepository>();


builder.Services.AddAutoMapper(typeof(Program));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
