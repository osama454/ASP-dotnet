using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class testModel : PageModel
    {
        public int y = 1;

        private readonly ILogger<testModel> _logger;

        public testModel(ILogger<testModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
        public void Incr()
        {
            y++;
            // Console.WriteLine(y.ToString());
        }
        public JsonResult OnPostIncrement()
        {
            Incr(); // Increment the counter
            return new JsonResult(y); // Return the new count as JSON
        }
    }
}
