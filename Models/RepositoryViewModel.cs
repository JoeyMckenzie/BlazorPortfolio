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

        public string Name { get; set; }

        public string RepositoryLink { get; set; }

        public string Sha { get; set; }

        public string Message { get; set; }

        public string Author { get; set; }

        public string CommitLink { get; set; }

        public DateTime? CommitDate { get; set; }
    }
}
