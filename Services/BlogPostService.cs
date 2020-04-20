using System;
using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Services
{
    public static class BlogPostService
    {
        private readonly static IEnumerable<BlogPostViewModel> _blogPosts = new List<BlogPostViewModel>
        {
            new BlogPostViewModel(".NET Core, Dapper, MediatR, and Buzzword Bingo (Part 4)", "https://betweentwobrackets.netlify.app/2020-02-02-net-core-dapper-and-crud-buzzword-bingo-part-4/", new DateTime(2020, 2, 20)),
            new BlogPostViewModel(".NET Core, Dapper, MediatR, and Buzzword Bingo (Part 3)", "https://betweentwobrackets.netlify.app/2019-11-19-net-core-dapper-and-crud-buzzword-bingo-part-3/", new DateTime(2019, 11, 19)),
            new BlogPostViewModel("A Tale of Two Types - C# 8.0, Nullable References, and Designing with Intent", "https://betweentwobrackets.netlify.app/2019-11-05-csharp-8-nullable-reference-types/", new DateTime(2019, 11, 5)),
            new BlogPostViewModel(".NET Core, Dapper, MediatR, and Buzzword Bingo (Part 2)", "https://betweentwobrackets.netlify.app/2019-10-21-net-core-dapper-and-crud-buzzword-bingo-part-2/", new DateTime(2019, 10, 19)),
            new BlogPostViewModel(".NET Core, Dapper, MediatR, and Buzzword Bingo (Part 1)", "https://betweentwobrackets.netlify.app/2019-10-06-net-core-dapper-and-crud-buzzword-bingo/", new DateTime(2019, 10, 6))
        };

        public static IEnumerable<BlogPostViewModel> GetBlogPosts() => _blogPosts;
    }
}
