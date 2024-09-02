using Application.Queries.Acervos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.Pages.Dashboard.ModalAddEdit
{
    public partial class AddEdit : Form
    {
        IAcervoQuery _acervoQuery;
        public AddEdit(IAcervoQuery acervoQuery)
        {
            InitializeComponent();
            _acervoQuery = acervoQuery;
        }

        private bool ValidarCampos()
        {
            if (TxtAno.Text.Length != 4|| !int.TryParse(TxtAno.Text, out _))
            {
                throw new FormatException("Ano Invalido");
            }

            if (string.IsNullOrWhiteSpace(TxtTitulo.Text))
            {
                throw new FormatException("Titulo Obrigatório");
            }

            if (string.IsNullOrWhiteSpace(TxtAutor.Text))
            {
                throw new FormatException("Autor Obrigatório");
            }

            if (string.IsNullOrWhiteSpace(TxtGenero.Text))
            {
                throw new FormatException("Genero Obrigatório");
            }

            if (_acervoQuery.GetAcervos().Any(a => a.Isbn == TxtIsbn.Text))
            {
                throw new FormatException("Livro já cadastrado anteriormente");
            }

            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            _acervoQuery.CreateNewAcervo(new Livro
            {
                Ano = Convert.ToInt32(TxtAno.Text),
                Autor = TxtAutor.Text,
                Isbn = TxtIsbn.Text,
                Genero = TxtGenero.Text,
                Titulo = TxtTitulo.Text,
            });

            Close();
        }
    }
}
