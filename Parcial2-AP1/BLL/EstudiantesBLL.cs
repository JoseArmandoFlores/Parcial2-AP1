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
    public class EstudiantesBLL
    {
        public static bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.Estudiante.Find(estudiante.Id);

                foreach (var Item in Anterior.CategoriaDetalle)
                {
                    if (!estudiante.CategoriaDetalle.Exists(d => d.CategoriaID == Item.CategoriaID))
                        db.Entry(Item).State = EntityState.Deleted;
                }

                db.Entry(estudiante).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

    }
}
