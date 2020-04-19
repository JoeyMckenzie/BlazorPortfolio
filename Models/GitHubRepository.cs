﻿using System;
using System.Text.Json.Serialization;

namespace Portfolio.Models
{
    public class GitHubRepository
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        [JsonPropertyName("private")]
        public bool Private { get; set; }

        [JsonPropertyName("owner")]
        public GitHubUser? Owner { get; set; }

        [JsonPropertyName("html_url")]
        public Uri? HtmlUrl { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("fork")]
        public bool Fork { get; set; }

        [JsonPropertyName("url")]
        public Uri? Url { get; set; }

        [JsonPropertyName("forks_url")]
        public Uri? ForksUrl { get; set; }

        [JsonPropertyName("keys_url")]
        public string? KeysUrl { get; set; }

        [JsonPropertyName("collaborators_url")]
        public string? CollaboratorsUrl { get; set; }

        [JsonPropertyName("teams_url")]
        public Uri? TeamsUrl { get; set; }

        [JsonPropertyName("hooks_url")]
        public Uri? HooksUrl { get; set; }

        [JsonPropertyName("issue_events_url")]
        public Uri? IssueEventsUrl { get; set; }

        [JsonPropertyName("events_url")]
        public Uri? EventsUrl { get; set; }

        [JsonPropertyName("assignees_url")]
        public Uri? AssigneesUrl { get; set; }

        [JsonPropertyName("branches_url")]
        public Uri? BranchesUrl { get; set; }

        [JsonPropertyName("tags_url")]
        public Uri? TagsUrl { get; set; }

        [JsonPropertyName("blobs_url")]
        public Uri? BlobsUrl { get; set; }

        [JsonPropertyName("git_tags_url")]
        public Uri? GitTagsUrl { get; set; }

        [JsonPropertyName("git_refs_url")]
        public Uri? GitRefsUrl { get; set; }

        [JsonPropertyName("trees_url")]
        public string? TreesUrl { get; set; }

        [JsonPropertyName("statuses_url")]
        public string? StatusesUrl { get; set; }

        [JsonPropertyName("languages_url")]
        public Uri? LanguagesUrl { get; set; }

        [JsonPropertyName("stargazers_url")]
        public Uri? StargazersUrl { get; set; }

        [JsonPropertyName("contributors_url")]
        public Uri? ContributorsUrl { get; set; }

        [JsonPropertyName("subscribers_url")]
        public Uri? SubscribersUrl { get; set; }

        [JsonPropertyName("subscription_url")]
        public Uri? SubscriptionUrl { get; set; }

        [JsonPropertyName("commits_url")]
        public string? CommitsUrl { get; set; }

        [JsonPropertyName("git_commits_url")]
        public Uri? GitCommitsUrl { get; set; }

        [JsonPropertyName("comments_url")]
        public Uri? CommentsUrl { get; set; }

        [JsonPropertyName("issue_comment_url")]
        public Uri? IssueCommentUrl { get; set; }

        [JsonPropertyName("contents_url")]
        public Uri? ContentsUrl { get; set; }

        [JsonPropertyName("compare_url")]
        public Uri? CompareUrl { get; set; }

        [JsonPropertyName("merges_url")]
        public Uri? MergesUrl { get; set; }

        [JsonPropertyName("archive_url")]
        public Uri? ArchiveUrl { get; set; }

        [JsonPropertyName("downloads_url")]
        public Uri? DownloadsUrl { get; set; }

        [JsonPropertyName("issues_url")]
        public Uri? IssuesUrl { get; set; }

        [JsonPropertyName("pulls_url")]
        public Uri? PullsUrl { get; set; }

        [JsonPropertyName("milestones_url")]
        public Uri? MilestonesUrl { get; set; }

        [JsonPropertyName("notifications_url")]
        public Uri? NotificationsUrl { get; set; }

        [JsonPropertyName("labels_url")]
        public Uri? LabelsUrl { get; set; }

        [JsonPropertyName("releases_url")]
        public Uri? ReleasesUrl { get; set; }

        [JsonPropertyName("deployments_url")]
        public Uri? DeploymentsUrl { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("pushed_at")]
        public DateTimeOffset PushedAt { get; set; }

        [JsonPropertyName("git_url")]
        public Uri? GitUrl { get; set; }

        [JsonPropertyName("ssh_url")]
        public Uri? SshUrl { get; set; }

        [JsonPropertyName("clone_url")]
        public Uri? CloneUrl { get; set; }

        [JsonPropertyName("svn_url")]
        public Uri? SvnUrl { get; set; }

        [JsonPropertyName("homepage")]
        public object? Homepage { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("stargazers_count")]
        public long StargazersCount { get; set; }

        [JsonPropertyName("watchers_count")]
        public long WatchersCount { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("has_issues")]
        public bool HasIssues { get; set; }

        [JsonPropertyName("has_projects")]
        public bool HasProjects { get; set; }

        [JsonPropertyName("has_downloads")]
        public bool HasDownloads { get; set; }

        [JsonPropertyName("has_wiki")]
        public bool HasWiki { get; set; }

        [JsonPropertyName("has_pages")]
        public bool HasPages { get; set; }

        [JsonPropertyName("forks_count")]
        public long ForksCount { get; set; }

        [JsonPropertyName("mirror_url")]
        public object? MirrorUrl { get; set; }

        [JsonPropertyName("archived")]
        public bool Archived { get; set; }

        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }

        [JsonPropertyName("open_issues_count")]
        public long OpenIssuesCount { get; set; }

        [JsonPropertyName("license")]
        public object? License { get; set; }

        [JsonPropertyName("forks")]
        public long Forks { get; set; }

        [JsonPropertyName("open_issues")]
        public long OpenIssues { get; set; }

        [JsonPropertyName("watchers")]
        public long Watchers { get; set; }

        [JsonPropertyName("default_branch")]
        public string? DefaultBranch { get; set; }
    }
}