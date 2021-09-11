using System;
using System.Text.Json.Serialization;

namespace AdafyExercise.Data {
    public class Team {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("FullName")]
        public string FullName { get; set; }
        [JsonPropertyName("Logo")]
        public string Logo { get; set; }
        [JsonPropertyName("LogoUrl")]
        public string LogoUrl { get; set; }
        [JsonPropertyName("Ranking")]
        public int Ranking { get; set; }
        [JsonPropertyName("Message")]
        public string Message { get; set; }
    }
}
