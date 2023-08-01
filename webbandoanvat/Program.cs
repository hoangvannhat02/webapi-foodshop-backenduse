using BLL;
using BLL.Intefaces;
using DAL;
using DAL.Helper;
using DAL.Helper.Interfaces;
using DAL.Interfaces;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IViewSanPham, ViewSanPhamBLL>();
builder.Services.AddTransient<ISanPhamDAL, SanPhamDAL>();
builder.Services.AddTransient<IDonHangBLL, DonHangBLL>();
builder.Services.AddTransient<IDonHangDAL, DonHangDAL>();
builder.Services.AddTransient<IDataHelper, DatabaseAccess>();
builder.Services.AddTransient<IKhachHangBLL, KhachHangBLL>();
builder.Services.AddTransient<IKhachHangDAL, KhachHangDAL>();
builder.Services.AddTransient<ILoaiSanPhamBLL, LoaiSanPhamBLL>();
builder.Services.AddTransient<ILoaiSanPhamDAL, LoaiSanPhamDAL>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddControllers();
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

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
