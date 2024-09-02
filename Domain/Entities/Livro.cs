using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Livro : Entity
    {
        public string Titulo { get; set; } = null!;
        public string Autor {  get; set; } = null!;
        public string Genero { get; set; } = null!;
        public string Isbn {  get; set; } = null!;
        public int Ano { get; set; }

    }
}
