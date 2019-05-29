using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSlides.Client.Services.Contracts
{
    public interface IMarkdownService
    {
        string MarkdownToHtml(string markdown);
    }
}
