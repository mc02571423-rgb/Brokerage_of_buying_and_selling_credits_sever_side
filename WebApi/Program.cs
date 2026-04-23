using BLL.functions;
using BLL.interfaces;
using DAL.db_classes;
using DAL.functions;
using DAL.interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opotion => opotion.AddPolicy("AllowAll",
    p => p.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()));

//("server=SQL2019\\Hishdb; Database=credit; Trusted_Connection=True;TrustServerCertificate" +
//"=True"))

builder.Services.AddDbContext<CreditContext>(o => o.UseSqlServer
("server=localhost\\SQLEXPRESS; Database=credit; Trusted_Connection=True;TrustServerCertificate" +
"=True"));

builder.Services.AddScoped(typeof(ICategoriesDal), typeof(CategoriesDal));
builder.Services.AddScoped(typeof(IStoreDal), typeof(StoreDal));
builder.Services.AddScoped(typeof(IZikuyDal), typeof(ZikuyDal));
builder.Services.AddScoped(typeof(IUserDal), typeof(UserDal));

builder.Services.AddScoped(typeof(ICategoriesBll), typeof(CategoriesBll));
builder.Services.AddScoped(typeof(IStoresBll), typeof(StoresBll));
builder.Services.AddScoped(typeof(IZikuyBll), typeof(ZikuyBll));
builder.Services.AddScoped(typeof(IUserBll), typeof(UserBll));
builder.Services.AddAutoMapper(typeof(Program));
var app = builder.Build();

app.UseCors("AllowAll");

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
