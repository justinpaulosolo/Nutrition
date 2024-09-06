namespace Nutrition.ApiService.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Calories { get; set; }
        public decimal Protein { get; set; }
        public decimal Carbohydrates { get; set; }
        public decimal Fat { get; set; }
        public decimal Fiber { get; set; }
        public decimal Sugar { get; set; }
        public int ServingSizeInGrams { get; set; }

        public ICollection<MealFoodItem> MealFoodItems { get; set; }
    }
}
