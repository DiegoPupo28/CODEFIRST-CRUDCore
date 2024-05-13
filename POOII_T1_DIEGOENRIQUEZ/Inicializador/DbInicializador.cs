using Microsoft.EntityFrameworkCore;
using POOII_T1_DIEGOENRIQUEZ.Datos;

namespace POOII_T1_DIEGOENRIQUEZ.Inicializador
{
    public class DbInicializador : IDbInicializador
    {
        private readonly ApplicationDbContext _context;
        public DbInicializador(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Inicializar()
        {
            try
            {
                if(_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            } catch(Exception)
            {
               throw;  
            }
            throw new NotImplementedException();
        }
    }
}
