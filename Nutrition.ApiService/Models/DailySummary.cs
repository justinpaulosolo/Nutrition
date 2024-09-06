namespace Nutrition.ApiService.Models
{
    public class DailySummary
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal TotalCalories { get; set; }
        public decimal TotalProtein { get; set; }
        public decimal TotalCarbohydrates { get; set; }
        public decimal TotalFat { get; set; }
        public decimal TotalFiber { get; set; }
        public decimal TotalSugar { get; set; }

        public NutritionUser User { get; set; }
    }
}
