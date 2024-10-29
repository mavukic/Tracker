using System.Collections.Generic;
namespace Tracker
{


    public class HabitService
    {
        public List<Habit> Habits { get; private set; } = new();

        public void AddHabit(string name, string color)
        {
            var habit = new Habit
            {
                Name = name,
                Color = color
            };

            // Initialize completion status for each day (for a 30-day month)
            for (int day = 1; day <= 30; day++)
            {
                habit.DailyCompletion[day] = false;
            }

            Habits.Add(habit);
        }
        public void ToggleHabitCompletion(Habit habit, int day)
        {
            if (habit.DailyCompletion.ContainsKey(day))
            {
                habit.DailyCompletion[day] = !habit.DailyCompletion[day];
            }
        }
    // Optional: method to get habits (for testing or future use)
    public List<Habit> GetHabits() => Habits;

    }
}