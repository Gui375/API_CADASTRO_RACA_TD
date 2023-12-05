using Interno.Api.Configuracoes;
using Microsoft.EntityFrameworkCore;
using PSF.Dados.EntityFramework;
using PSF.Dados.Interface;
using PSF.Dados.Repositorio;
using PSF.Servico.Interface;
using PSF.Servico.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllersWithViews();
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(@"Data source = 201.62.57.93,1434; 
                                    Database = BD047106; 
                                    User ID = RA047106; 
                                    Password = 047106;
                                    TrustServerCertificate=True")
);

builder.Services.ResolveDependencies();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "Cookies";

})
    .AddCookie("Cookies", c => c.ExpireTimeSpan = TimeSpan.FromMinutes(60));
   

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors("corsapp");
//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
