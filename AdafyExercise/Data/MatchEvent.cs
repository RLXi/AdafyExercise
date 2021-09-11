using System;
using System.Text.Json.Serialization;

namespace AdafyExercise.Data {
    public class MatchEvent {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("MatchId")]
        public int MatchId { get; set; }
        [JsonPropertyName("ElapsedSeconds")]
        public int ElapsedSeconds { get; set; }
        [JsonPropertyName("TeamId")]
        public int TeamId { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
        [JsonPropertyName("FullDescription")]
        public string FullDescrtiption { get; set; }
        [JsonPropertyName("EventTypeIcon")]
        public string EventTypeIcon { get; set; }
        [JsonPropertyName("EventType")]
        public string EventType { get; set; }
        [JsonPropertyName("EventTypeEnum")]
        public int EventTypeEnum { get; set; }
        [JsonPropertyName("PlayerId")]
        public dynamic PlayerId { get; set; }
        [JsonPropertyName("Identifier")]
        public string Identifier { get; set; }
        [JsonPropertyName("AssistPlayers")]
        public dynamic AssistPlayers { get; set; }
        [JsonPropertyName("AssistsPlayerNames")]
        public dynamic AssistPlayerNames { get; set; }
        [JsonPropertyName("Modifier")]
        public dynamic Modifier { get; set; }
        [JsonPropertyName("Score")]
        public dynamic Score { get; set; }
        [JsonPropertyName("IsGoal")]
        public bool IsGoal { get; set; }
    }
}
