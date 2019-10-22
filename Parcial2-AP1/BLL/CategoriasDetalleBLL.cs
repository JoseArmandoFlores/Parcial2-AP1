using Parcial2_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_AP1.BLL
{
    public class CategoriasDetalleBLL
    {
        public static decimal CalcularTotal()
        {
            decimal suma=0;

            var Lista = new List<CategoriasDetalle>();
            RepositorioBase<CategoriasDetalle> Metodos = new RepositorioBase<CategoriasDetalle>();
            Lista = Metodos.GetList(p => true);

            foreach (var item in Lista)
            {
                suma += item.Importe;
            }

            return suma;
        }
    }
}
