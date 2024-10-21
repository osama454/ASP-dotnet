using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace HealthHive.Data{
public class ApplicationUser : PageModel
{
  [BindProperty]
  public required string Name { get; set; }
  [BindProperty]
  public required string Surname { get; set; }
  [BindProperty]
  public required string Title { get; set; }
  [BindProperty]
  public required string Gender { get; set; }
  [BindProperty]
  public DateTime DateOfBirth { get; set; }
  [BindProperty]
  public required string Ethnicity { get; set; }
  [BindProperty]
  public required string IdNumber { get; set; }
  [BindProperty]
  public required string PhoneNumber { get; set; }
  [BindProperty]
  public int SpecialtyId { get; set; }
  [BindProperty]
  public required string AddressLine1 { get; set; }

  public void OnGet()
  {
    // Initialize the properties with sample data
    Name = "John";
    Surname = "Doe";
    Title = "Dr";
    Gender = "Male";
    DateOfBirth = new DateTime(1980, 1, 1);
    Ethnicity = "White";
    IdNumber = "123456789";
    PhoneNumber = "555-1234";
    SpecialtyId = 1;
    AddressLine1 = "123 Main Street";

    // Sample data for specializations (if needed)
    ViewData["Specializations"] = new[]
    {
                new { Id = 1, Name = "Cardiology" },
                new { Id = 2, Name = "Dermatology" },
                new { Id = 3, Name = "Pediatrics" },
                new { Id = 4, Name = "Neurology" }
            };
  }

  public IActionResult OnPost()
  {
    if (!ModelState.IsValid)
    {
      return Page();
    }

    // Handle form submission
    return RedirectToPage("./Index");
  }
}
}