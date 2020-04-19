using System;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class GitHubAuthorMeta
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }
    }
}
