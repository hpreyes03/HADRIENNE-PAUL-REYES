using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ayen.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Properties to hold data
        public string Message { get; set; }

        public void OnGet()
        {
            // Handle GET requests
            Message = "Welcome to the Index page!";
            _logger.LogInformation("Index page loaded.");
        }

        public void OnPost()
        {
            // Handle POST requests
            Message = "Form submitted successfully!";
            _logger.LogInformation("Form submitted.");
        }
    }
}