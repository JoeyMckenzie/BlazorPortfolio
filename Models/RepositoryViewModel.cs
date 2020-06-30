using System;

namespace Portfolio.Models
{
    public class RepositoryViewModel
    {
        public RepositoryViewModel(string name, string repositoryLink, string sha, string message, string author, string commitLink, DateTime? commitDate)
        {
            Name = name;
            RepositoryLink = repositoryLink;
            Sha = sha;
            Message = message;
            Author = author;
            CommitLink = commitLink;
            CommitDate = commitDate;
        }

        public string Name { get; }

        public string RepositoryLink { get; }

        public string Sha { get; }

        public string Message { get; }

        public string Author { get; }

        public string CommitLink { get; }

        public DateTime? CommitDate { get; }
    }
}
