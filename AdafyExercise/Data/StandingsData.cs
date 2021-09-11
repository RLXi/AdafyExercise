using System;

namespace AdafyExercise.Data {
    public class StandingsData {
        public int TeamId { get; set; }
        public int TeamRanking { get; set; } //1. for the team with the most points, 2. for the team with the second highest number of points etc.
        public string TeamName { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Ties { get; set; }
        public int Losses { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifference { get; set; } //GoalsScored - GoalsAgainst
        public int Points { get; set; } //1 Win = 3 points, 1 Tie = 1 point.
    }
}
