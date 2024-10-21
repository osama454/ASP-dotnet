using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages;

public class IndexModel : PageModel
{
   
        private const string CounterKey = "Counter";
        int count=0;

        public int Counter;

        public void OnGet()
        {
        }

        public JsonResult OnGetXxx()
        {
            Counter = Counter +1; // Increment the counter
            return new JsonResult(new { counter = Counter });
        }
}
