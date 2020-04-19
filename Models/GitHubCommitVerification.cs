using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class GitHubCommitVerification
    {
        [JsonPropertyName("verified")]
        public bool Verified { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("signature")]
        public object? Signature { get; set; }

        [JsonPropertyName("payload")]
        public object? Payload { get; set; }
    }
}
