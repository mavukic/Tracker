using System;
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

            // Initialize completion status for the current month
            var today = DateTime.Today;
            int daysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
            for (int day = 1; day <= daysInMonth; day++)
            {
                var date = new DateTime(today.Year, today.Month, day);
                habit.DailyCompletion[date] = false;
            }

            Habits.Add(habit);
        }

        public void ToggleHabitCompletion(Habit habit, DateTime date)
        {
            if (habit.DailyCompletion.ContainsKey(date))
            {
                // Toggle completion status for the specified date
                habit.DailyCompletion[date] = !habit.DailyCompletion[date];
            }
            else
            {
                // Add a new entry if the date is not present
                habit.DailyCompletion[date] = true;
            }
        }

        // Optional: method to get habits (for testing or future use)
        public List<Habit> GetHabits() => Habits;
    }
}
