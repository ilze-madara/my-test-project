using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyTestWebpage.ViewModels;

namespace MyTestWebpage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var tests = new List<TestListItem>();
            tests.Add(new TestListItem { Id = 1, Name = "Math" });
            tests.Add(new TestListItem { Id = 2, Name = "Physics" });
            tests.Add(new TestListItem { Id = 3, Name = "Biology" });
            tests.Add(new TestListItem { Id = 4, Name = "Marketing" });

            ViewData["Tests"] = tests;
        }
    }
}
