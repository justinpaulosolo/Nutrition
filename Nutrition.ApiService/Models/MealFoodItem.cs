namespace Nutrition.ApiService.Models
{
    public class MealFoodItem
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public int FoodItemId { get; set; }
        public decimal ServingsConsumed { get; set; }

        public Meal Meal { get; set; }
        public FoodItem FoodItem { get; set; }
    }
}
