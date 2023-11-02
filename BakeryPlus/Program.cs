  using Microsoft.AspNetCore.Builder;
  using Microsoft.EntityFrameworkCore;
  using Microsoft.Extensions.DependencyInjection;
  using BakeryPlus.Models;
  // be sure to change the namespace to match your project
  namespace BakeryPlus
  {
    class Program
    {
      static void Main(string[] args)
      {
      
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        // be sure to update the line below for your project
        builder.Services.AddDbContext<BakeryPlusContext>(
                          dbContextOptions => dbContextOptions
                            .UseMySql(
                              builder.Configuration["ConnectionStrings:DefaultConnection"]ServerVersion.AutoDetect(builder.Configuratio["ConnectionStrings:DefaultConnection"]
                            )
                          )
                        );

        WebApplication app = builder.Build();

        app.UseDeveloperExceptionPage();
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
          );

        app.Run();
      }
    }
  }