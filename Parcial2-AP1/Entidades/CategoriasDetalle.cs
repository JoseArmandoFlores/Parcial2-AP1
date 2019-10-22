using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_AP1.Entidades
{
    public class CategoriasDetalle
    {
        [Key]
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public CategoriasDetalle()
        {
            CategoriaID = 0;
            Nombre = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
        }

        public CategoriasDetalle(int categoriaID, string nombre, int cantidad, decimal precio, decimal importe)
        {
            CategoriaID = categoriaID;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
