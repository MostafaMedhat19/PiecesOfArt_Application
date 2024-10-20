using Microsoft.EntityFrameworkCore;
using PiecesOfArt_Application.Business_Layer.BLL.Models;
using PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Mapper;
using PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Vaildation_Data.Implementation;
using PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Vaildation_Data.Interface;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.DAO.Implementation_DAO;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.DAO.Interface_DAO;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.Data;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.Repository.Implementation;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddScoped(typeof(IBaseDao<>), typeof(BaseDao<>));
builder.Services.AddScoped<IUserServices2,UserServices2>();
builder.Services.AddScoped(typeof(IUserService<>), typeof(UserService<>));
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());
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
