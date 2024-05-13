using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using POOII_T1_DIEGOENRIQUEZ.Datos;
using POOII_T1_DIEGOENRIQUEZ.Modelos;
//inyeccion de datos//
namespace POOII_T1_DIEGOENRIQUEZ.Pages.Productos
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Personal> Personal { get; set; }

        public async Task OnGet()
        {
            Personal = await _context.Personal.ToListAsync();
        }

        public async Task<IActionResult> OnPostBorrar(int id)
        {
            var producto = await _context.Personal.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Personal.Remove(producto);
            await _context.SaveChangesAsync();
            //Redigiremos a la pagina index//
            return RedirectToPage("Index");
        }
    }
}

