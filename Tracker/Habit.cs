namespace Tracker
{
    public class Habit
    {
        public string Name { get; set; }
        public Dictionary<DateTime, bool> DailyCompletion { get; set; } = new(); // Updated to DateTime key
        public string Color { get; set; } = "#FFFFFF";
    }
}
