using System;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class GitHubCommitMeta
    {
        [JsonPropertyName("author")]
        public GitHubAuthorMeta? Author { get; set; }

        [JsonPropertyName("committer")]
        public GitHubAuthorMeta? Committer { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("tree")]
        public GitHubCommitTree? Tree { get; set; }

        [JsonPropertyName("url")]
        public Uri? Url { get; set; }

        [JsonPropertyName("comment_count")]
        public long CommentCount { get; set; }

        [JsonPropertyName("verification")]
        public GitHubCommitVerification? Verification { get; set; }
    }
}
