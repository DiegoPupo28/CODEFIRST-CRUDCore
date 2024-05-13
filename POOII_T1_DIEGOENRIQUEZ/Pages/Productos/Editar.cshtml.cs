using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using POOII_T1_DIEGOENRIQUEZ.Datos;
using POOII_T1_DIEGOENRIQUEZ.Modelos;

//inyeccion de datos//
namespace POOII_T1_DIEGOENRIQUEZ.Pages.Productos
{
    public class EditarModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditarModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Personal Personal { get; set; }
        public async Task OnGet(int id)
        {
            Personal = await _context.Personal.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)

            {
                var PersonalDB = await _context.Personal.FindAsync(Personal.Id);
                PersonalDB.Nombre = Personal.Nombre;
                PersonalDB.Apellido = Personal.Apellido;
                PersonalDB.FechaIngreso = Personal.FechaIngreso;
                PersonalDB.Area = Personal.Area;
                PersonalDB.Sueldo = Personal.Sueldo;
                PersonalDB.Seniority = Personal.Seniority;

                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }
    }
}
