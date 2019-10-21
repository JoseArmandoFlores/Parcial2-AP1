using Parcial2_AP1.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_AP1.BLL
{
    public class RepositorioBase<T> : IDisposable, IRepository<T> where T : class
    {
        internal Contexto _Contexto;

        public RepositorioBase()
        {
            _Contexto = new Contexto();
        }

        public virtual T Buscar(int id)
        {
            T entidad;

            try
            {
                entidad = _Contexto.Set<T>().Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return entidad;
        }

        public void Dispose()
        {
            _Contexto.Dispose();
        }

        public virtual bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                T entidad = _Contexto.Set<T>().Find(id);
                _Contexto.Set<T>().Remove(entidad);
                paso = _Contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> Lista = new List<T>();

            try
            {
                Lista = _Contexto.Set<T>().Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }


        public virtual bool Guardar(T entidad)
        {
            bool paso = false;

            try
            {
                if (_Contexto.Set<T>().Add(entidad) != null)
                    paso = _Contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public virtual bool Modificar(T entidad)
        {
            bool paso = false;

            try
            {
                _Contexto.Entry(entidad).State = EntityState.Modified;
                paso = _Contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
    }
}
