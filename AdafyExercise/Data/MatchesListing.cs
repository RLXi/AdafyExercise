using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdafyExercise.Data {
    public class MatchesListing {
        //NOTE: There's a lot of unnecessary properties for this exercise. Consider removing them.
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Round")]
        public dynamic Round { get; set; }
        [JsonPropertyName("RoundNumber")]
        public int RoundNumber { get; set; }
        [JsonPropertyName("MatchDate")]
        public DateTime MatchDate { get; set; }
        [JsonPropertyName("HomeTeam")]
        public Team HomeTeam { get; set; }
        [JsonPropertyName("AwayTeam")]
        public Team AwayTeam { get; set; }
        [JsonPropertyName("HomeGoals")]
        public int HomeGoals { get; set; }
        [JsonPropertyName("AwayGoals")]
        public int AwayGoals { get; set; }
        [JsonPropertyName("Status")]
        public int Status { get; set; }
        [JsonPropertyName("PlayedMinuts")]
        public int PlayedMinutes { get; set; }
        [JsonPropertyName("SecondHalfStarted")]
        public dynamic SecondHalfStarted { get; set; }
        [JsonPropertyName("GameStarted")]
        public dynamic GameStarted { get; set; }
        [JsonPropertyName("MatchEvents")]
        public List<MatchEvent> MatchEvents { get; set; }
        [JsonPropertyName("PeriodResults")]
        public List<dynamic> PeriodResults { get; set; }
        [JsonPropertyName("OnlyResultAvailable")]
        public bool OnlyResultAvailable { get; set; }
        [JsonPropertyName("Season")]
        public int Season { get; set; }
        [JsonPropertyName("Country")]
        public string Country { get; set; }
        [JsonPropertyName("League")]
        public string League { get; set; }
    }
}
