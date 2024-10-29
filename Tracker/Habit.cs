namespace Tracker
{
    public class Habit
    {
        public string Name { get; set; }
        public Dictionary<int, bool> DailyCompletion { get; set; } = new();
        public string Color { get; set; } = "#FFFFFF"; // Default color
    }
}
