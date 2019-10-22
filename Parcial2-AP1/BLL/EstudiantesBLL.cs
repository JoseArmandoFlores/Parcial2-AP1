using Parcial2_AP1.DAL;
using Parcial2_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_AP1.BLL
{
    public class EstudiantesBLL : RepositorioBase<Estudiantes>
    {

        public override bool Modificar(Estudiantes estudiante)
        {
            
            var Anterior = _Contexto.Estudiante.Find(estudiante.Id);

            foreach (var Item in Anterior.CategoriaDetalle)
            {
                if (!estudiante.CategoriaDetalle.Exists(d => d.CategoriaID == Item.CategoriaID))
                    _Contexto.Entry(Item).State = EntityState.Deleted;
            }

            bool paso = base.Modificar(estudiante);
            return paso;
        }
    }
}
