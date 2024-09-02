using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Config
{
    public interface IContext
    {
        public List<T> GetEntity<T>() where T : Entity;
        public void InsertEntity<T>(T entity) where T : Entity;
        public void DeleteEntity<T>(T entity) where T : Entity;
        public void UpdateEntity<T>(T entity) where T : Entity;

    }
}
