using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Acervos
{
    public interface IAcervoQuery
    {
        public IEnumerable<Livro> GetAcervos();
        public void CreateNewAcervo(Livro livro);
        public void DeleteAcervo(Livro livro);
        public void UpdateAcervo(Livro livro);

    }
}
