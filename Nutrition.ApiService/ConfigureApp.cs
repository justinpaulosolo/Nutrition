using Nutrition.ApiService.Data;

namespace Nutrition.ApiService;

public static class ConfigureApp
{
    public static async Task Configure(this WebApplication app)
    {
        app.UseExceptionHandler();
        app.MapDefaultEndpoints();
        app.MapEndpoints();

        if (app.Environment.IsDevelopment())
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<NutritionDataContext>();
            context.Database.EnsureCreated();
        }
        else
        {
            app.UseExceptionHandler("/error", createScopeForErrors: true);
            app.UseHsts();
        }
        app.UseAuthorization();
        app.Run();
    }
}
