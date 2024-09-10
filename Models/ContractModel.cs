using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace PROG6212_POEPART1.Models
{
    public class ContractModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; } = "";
        [BindProperty]
        public string LastName { get; set; } = "";
        [BindProperty]
        public string Department { get; set; } = "";
        [BindProperty]
        public string Email { get; set; } = "";
        [BindProperty]
        public string Date { get; set; } = "";

        public string successMessage = "";
        public string errorMessage = "";

        public void OnGet()
        {
            
        }

        public void OnPost() 
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Data validation failed";
                return;
            }

            successMessage = "Your message has been received correctly";
            FirstName = "";
            LastName = "";
            Email = "";
            Department = "";
            Date = "";

            ModelState.Clear();
        }
    }
}
