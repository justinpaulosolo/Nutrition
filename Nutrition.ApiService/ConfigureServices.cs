using Nutrition.ApiService.Data;
using Nutrition.ApiService.Models;

namespace Nutrition.ApiService;

public static class ConfigureServices
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        // 👇 Add the authorization services
        builder.Services.AddAuthorization();

        builder.AddDatabase();

        builder.AddIdentityApiEndpoints();

        // Add service defaults & Aspire components.
        builder.AddServiceDefaults();

        // Add services to the container.
        builder.Services.AddProblemDetails();
    }

    public static void AddDatabase(this WebApplicationBuilder builder)
    {
        builder.AddSqlServerDbContext<NutritionDataContext>("nutritiondatabase");
    }

    public static void AddIdentityApiEndpoints(this WebApplicationBuilder builder)
    {
        builder.Services.AddIdentityApiEndpoints<NutritionUser>()
            .AddEntityFrameworkStores<NutritionDataContext>();
    }
}

