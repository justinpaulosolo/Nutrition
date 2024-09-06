using Nutrition.ApiService.Models.Enums;

namespace Nutrition.ApiService.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public MealType MealType { get; set; }
        public DateTime Date { get; set; }

        public NutritionUser User { get; set; }
        public ICollection<MealFoodItem> MealFoodItems { get; set; }
    }
}
