using System;
using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Services
{
    public static class BlogPostService
    {
        private readonly static IEnumerable<BlogPostViewModel> _blogPosts = new List<BlogPostViewModel>
        {
            new BlogPostViewModel("State Management with Blazor using Fluxor (Part 1)", "https://betweentwobrackets.dev/posts/2020/06/state-management-with-blazor-using-fluxor-part-1/", new DateTime(2020, 06, 26)),
            new BlogPostViewModel("Blazor Basics - Consuming External APIs from the Frontend", "https://betweentwobrackets.dev/posts/2020/04/blazor-basics-consuming-external-apis-from-the-frontend/", new DateTime(2020, 4, 24)),
            new BlogPostViewModel("Clean Architecture, Dapper, MediatR, and Buzzword Bingo (Part 4)", "https://betweentwobrackets.dev/posts/2020/02/clean-architecture-dapper-mediatr-and-buzzword-bingo-part-4/", new DateTime(2020, 2, 20)),
            new BlogPostViewModel("Clean Architecture, Dapper, MediatR, and Buzzword Bingo (Part 3)", "https://betweentwobrackets.dev/posts/2019/11/clean-architecture-dapper-mediatr-and-buzzword-bingo-part-3/", new DateTime(2019, 11, 19)),
            new BlogPostViewModel("A Tale of Two Types - C# 8.0, Nullable References, and Designing with Intent", "https://betweentwobrackets.dev/posts/2019/11/a-tale-of-two-types-nullable-references-types-and-designing-with-intent/", new DateTime(2019, 11, 5)),
            new BlogPostViewModel("Clean Architecture, Dapper, MediatR, and Buzzword Bingo (Part 2)", "https://betweentwobrackets.dev/posts/2019/10/clean-architecture-dapper-mediatr-and-buzzword-bingo-part-2/", new DateTime(2019, 10, 19)),
            new BlogPostViewModel("Clean Architecture, Dapper, MediatR, and Buzzword Bingo (Part 1)", "https://betweentwobrackets.dev/posts/2019/10/clean-architecture-dapper-mediatr-and-buzzword-bingo-part-1/", new DateTime(2019, 10, 6))
        };

        public static IEnumerable<BlogPostViewModel> GetBlogPosts() => _blogPosts;
    }
}
