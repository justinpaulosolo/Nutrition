using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nutrition.ApiService.Models;
using System.Reflection.Emit;

namespace Nutrition.ApiService.Data;

public class NutritionDataContext(DbContextOptions<NutritionDataContext> options) : IdentityDbContext<NutritionUser>(options)
{
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<MealFoodItem> MealFoodItems { get; set; }
    public DbSet<FoodItem> FoodItems { get; set; }
    public DbSet<DailySummary> DailySummary { get; set; }
}
