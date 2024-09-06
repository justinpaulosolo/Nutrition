using Nutrition.ApiService.Models.Enums;

namespace Nutrition.ApiService.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public ActivityLevel ActivityLevel { get; set; }

        public NutritionUser User { get; set; }
    }
}
