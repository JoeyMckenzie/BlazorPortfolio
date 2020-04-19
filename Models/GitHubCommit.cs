using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class GitHubCommit
    {
        [JsonPropertyName("sha")]
        public string? Sha { get; set; }

        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        [JsonPropertyName("commit")]
        public GitHubCommitMeta? Commit { get; set; }

        [JsonPropertyName("url")]
        public Uri? Url { get; set; }

        [JsonPropertyName("html_url")]
        public Uri? HtmlUrl { get; set; }

        [JsonPropertyName("comments_url")]
        public Uri? CommentsUrl { get; set; }

        [JsonPropertyName("author")]
        public GitHubUser? Author { get; set; }

        [JsonPropertyName("committer")]
        public GitHubUser? Committer { get; set; }

        [JsonPropertyName("parents")]
        public IEnumerable<GitHubCommitParent>? Parents { get; set; }
    }
}
