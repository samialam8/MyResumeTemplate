using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ResumeTemplate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string FullName { get; set; }
        public string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> Languages { get; set; }

        public void OnGet()
        {
            FullName = "Mohammad Sami Alam";
            LinkedInUsername = "";
            YearsOfExperience = 3;
            Languages = new List<string> {
                "C#",
                "Javascript",
                "Java",
                "Python"

            };

        }
    }
}
