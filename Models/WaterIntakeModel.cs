namespace WaterWise.Models
{
    public class WaterIntakeModel
    {
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Gender { get; set; }
        public string ActivityLevel { get; set; }
        public string Climate { get; set; }
        public double RecommendedWaterIntake { get; set; }
    }
}