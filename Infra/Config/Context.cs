using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Config
{
    public class Context : IContext
    {
        public Context()
        {
            InitContext();
        }
        public List<Livro> Livros { get; set; }

        public void DeleteEntity<T>(T entity) where T : Entity
        {
            List<T> entityC = GetType().GetProperties().FirstOrDefault(p => p.PropertyType == typeof(List<T>))?.GetValue(this) as List<T>;

            entityC = entityC.Where(e => e.Id != entity.Id).ToList();
        }

        public List<T> GetEntity<T>() where T : Entity
        {
            return GetType().GetProperties().FirstOrDefault(p => p.PropertyType == typeof(List<T>))?.GetValue(this) as List<T> ?? Enumerable.Empty<T>().ToList();
        }

        public void InsertEntity<T>(T entity) where T : Entity
        {
            List<T> entityC = GetType().GetProperties().FirstOrDefault(p => p.PropertyType == typeof(List<T>))?.GetValue(this) as List<T>;

            entityC.Add(entity);
        }

        public void UpdateEntity<T>(T entity) where T : Entity
        {
            List<T> entityC = GetType().GetProperties().FirstOrDefault(p => p.PropertyType == typeof(List<T>))?.GetValue(this) as List<T>;

            entityC = entityC.Where(e => e.Id != entity.Id).ToList();
            entityC.Add(entity);
        }

        private void InitContext()
        {
            Livros = Enumerable.Empty<Livro>().ToList();
        }
    }
}
