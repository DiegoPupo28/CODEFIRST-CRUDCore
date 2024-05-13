using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using POOII_T1_DIEGOENRIQUEZ.Datos;
using POOII_T1_DIEGOENRIQUEZ.Modelos;
//inyeccion de datos//
namespace POOII_T1_DIEGOENRIQUEZ.Pages.Productos
{
    public class CrearModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CrearModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Personal Personal { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

      

            _context.Add(Personal);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}