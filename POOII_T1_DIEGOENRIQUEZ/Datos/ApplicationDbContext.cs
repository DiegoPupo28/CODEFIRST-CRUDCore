using Microsoft.EntityFrameworkCore;
using POOII_T1_DIEGOENRIQUEZ.Modelos;

namespace POOII_T1_DIEGOENRIQUEZ.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //modelos//
        public DbSet<Personal> Personal { get; set; }
    }
}
    

