using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_AP1.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public decimal Total { get; set; }

        public virtual List<CategoriasDetalle> CategoriaDetalle { get; set; }

        public Estudiantes()
        {
            Id = 0;
            Fecha = DateTime.Now;
            Nombre = string.Empty;
            Total = 0;
            CategoriaDetalle = new List<CategoriasDetalle>();
        }

        public Estudiantes(int id, DateTime fecha, string nombre, decimal total, List<CategoriasDetalle> estudianteDetalle)
        {
            Id = id;
            Fecha = fecha;
            Nombre = nombre;
            Total = total;
            CategoriaDetalle = estudianteDetalle;
        }
    }
}
