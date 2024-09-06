using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nutrition.ApiService.Models;

namespace Nutrition.ApiService.Data;

public class NutritionDataContext(DbContextOptions<NutritionDataContext> options) : IdentityDbContext<NutritionUser>(options)
{
}
