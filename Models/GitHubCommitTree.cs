using System;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class GitHubCommitTree
    {
        [JsonPropertyName("sha")]
        public string? Sha { get; set; }

        [JsonPropertyName("url")]
        public Uri? Url { get; set; }
    }
}
