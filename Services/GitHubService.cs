using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class GitHubService
    {
        private const string Username = "joey32793";
        private const string GitHubApiUrl = "https://api.github.com";

        private readonly HttpClient _httpClient;

        public GitHubService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(GitHubApiUrl);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        }

        public static IList<RepositoryViewModel>? ProjectRepositoryCache { get; set; }

        public async Task<IEnumerable<GitHubRepository>> GetRepositories()
        {
            Console.WriteLine("Retrieve user root...");
            var user = await _httpClient.GetJsonAsync<GitHubUser>($"/users/{Username}");

            if (user is null)
            {
                throw new HttpRequestException("Could not retrieve user root from GitHub API");
            }

            Console.WriteLine("User root retrieved");

            if (user.ReposUrl is null || string.IsNullOrWhiteSpace(user.ReposUrl.AbsoluteUri))
            {
                throw new HttpRequestException("No repository URL was available");
            }

            Console.WriteLine("Retrieving user repositories...");
            var repositories = await _httpClient.GetJsonAsync<IEnumerable<GitHubRepository>>(user.ReposUrl.AbsoluteUri);

            if (repositories is null)
            {
                throw new HttpRequestException("Could not retrieve repository root");
            }

            Console.WriteLine("User repositories retrieved");
            return repositories;
        }

        public async Task<IEnumerable<GitHubCommit>> GetRepositoryCommits(string repository, Uri? commitsLink)
        {
            if (commitsLink is null || string.IsNullOrWhiteSpace(commitsLink.AbsoluteUri))
            {
                throw new HttpRequestException($"Bad commits link was passed when retrieving commits for repository {repository}");
            }

            Console.WriteLine($"Retrieving commits for repository {repository}...");
            var commits = await _httpClient.GetJsonAsync<IEnumerable<GitHubCommit>>(commitsLink.AbsoluteUri);

            if (commits is null)
            {
                throw new HttpRequestException($"No commit list was returned for repository {repository}");
            }

            return commits;
        }
    }
}
