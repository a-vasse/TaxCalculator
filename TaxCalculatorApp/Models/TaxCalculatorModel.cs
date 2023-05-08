using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TaxCalculatorApp.Models
{
    public class TaxCalculatorModel : PageModel
    {
        [BindProperty]
        public decimal? Income { get; set; }

        public decimal? TaxAmount { get; private set; }

        public void OnPost()
        {
            if (Income.HasValue)
            {
                // Calculate tax amount based on your tax rules
                // Replace this with your actual tax calculation logic
                TaxAmount = Income.Value * 0.2m;
            }
        }
    }
}