using System.ComponentModel.DataAnnotations;
// aqui se relejara la cabeza de la base de datos//
namespace POOII_T1_DIEGOENRIQUEZ.Modelos
{
    public class Personal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Display(Name = "Fecha de Ingreso")]
        public string FechaIngreso { get; set; }
        [Display(Name = "Area")]
        public string Area { get; set; }
        public double Sueldo { get; set; }
        public string Seniority { get; set; }
    }
}

    
