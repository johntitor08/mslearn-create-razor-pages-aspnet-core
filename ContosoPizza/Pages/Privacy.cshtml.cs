using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoPizza.Pages
{
    public class PrivacyModel(ILogger<PrivacyModel> logger) : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger = logger;

        public void OnGet()
        {
        }

        public int DaysSince(DateTime startDate)
        {
            return (int)(DateTime.Now - startDate).TotalDays;
        }
    }
}
