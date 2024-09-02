using Application.Pages.Dashboard.ModalAddEdit;
using Application.Queries.Acervos;

namespace Application.Pages.Dashboard
{
    public partial class DashboardPage : Form
    {
        private IAcervoQuery _acervoQuery;
        public DashboardPage(IAcervoQuery acervoQuery)
        {
            InitializeComponent();
            _acervoQuery = acervoQuery;
        }

        private void DashboardPage_Load(object sender, EventArgs e) => LoadData();

        private void BtnAdicionar_Click(object sender, EventArgs e) => AdicionarItem();

        private void LoadData()
        {
            DgvAcervos.DataSource = _acervoQuery.GetAcervos();
        }

        private void AdicionarItem()
        {
            AddEdit modal = new AddEdit(_acervoQuery);

            modal.ShowDialog();

            LoadData();
        }
    }
}
