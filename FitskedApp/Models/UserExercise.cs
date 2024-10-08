﻿namespace FitskedApp.Models
{
    public class UserExercise
    {
        public int Id { get; set; }
        public int UserWorkoutId { get; set; }
        public string? Name { get; set; }
        public Exercise? Exercise { get; set; }
        public int Repetitions { get; set; }
        public int Sets { get; set; }
        public int Weight { get; set; }
        public WorkoutType WorkoutType { get; set; }

        // Navigation Property
        public UserWorkout? UserWorkout { get; set; }
    }
}
