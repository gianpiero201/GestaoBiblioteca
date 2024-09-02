using Domain.Entities;
using Infra.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Acervos
{
    public class AcervoQuery : IAcervoQuery
    {
        private IContext _context;
        public AcervoQuery(IContext context)
        {
            _context = context;
        }

        public IEnumerable<Livro> GetAcervos()
            => _context.GetEntity<Livro>().ToList();

        public void CreateNewAcervo(Livro livro)
            => _context.InsertEntity(livro);

        public void DeleteAcervo(Livro livro)
            => _context.DeleteEntity(livro);

        public void UpdateAcervo(Livro livro)
            => _context.UpdateEntity(livro);
    }
}
