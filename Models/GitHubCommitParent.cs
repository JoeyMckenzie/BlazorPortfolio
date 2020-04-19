using System;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class GitHubCommitParent
    {
        [JsonPropertyName("sha")]
        public string? Sha { get; set; }

        [JsonPropertyName("url")]
        public Uri? Url { get; set; }

        [JsonPropertyName("html_url")]
        public Uri? HtmlUrl { get; set; }
    }
}
