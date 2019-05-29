using BlazorSlides.Client.Services.Contracts;
using Markdig;
using Markdig.SyntaxHighlighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSlides.Client.Services.Implementations
{

    public class MarkdownService : IMarkdownService
    {
        public string MarkdownToHtml(string markdown)
        {
            return Markdown.ToHtml(
                markdown: markdown,
                pipeline: new MarkdownPipelineBuilder().UseAdvancedExtensions()
                                                       .UseSyntaxHighlighting().Build()
            );
        }
    }
}
