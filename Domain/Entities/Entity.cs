using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Entity
    {
        public Entity() { SetId(); }
        public Guid Id { get; private set; }

        private void SetId()
        {
            Id = Guid.NewGuid();
        }
    }
}
