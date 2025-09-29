using ClientHub.Application;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientHub.App.Forms
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly ClienteService _clienteService;
        private readonly CidadeService _cidadeService;
        private readonly EstadoService _estadoService;
        private readonly RelatorioService _relatorioService;
        public Home(ClienteService clienteService, CidadeService cidadeService, EstadoService estadoService, RelatorioService relatorioService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _cidadeService = cidadeService;
            BackColor = Color.LightGray;
            _estadoService = estadoService;
            _relatorioService = relatorioService;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            pn_Dashboard.Dock = DockStyle.Fill;
            pn_Dashboard.FlowDirection = FlowDirection.TopDown;
            pn_Dashboard.Padding = new Padding(20);

            Label lblBemVindo = new Label()
            {
                Text = "Bem-vindo ao ClientHub!",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = true
            };

            Label lblTotalClientes = new Label()
            {
                Text = $"Número de clientes cadastrados: {_clienteService.GetCountAllClients()}",
                AutoSize = true
            };

            Label lblUltimoClienteCad = new Label()
            {
                Text = $"Último cliente cadastrado: {_clienteService.GetLastClient()}",
                AutoSize = true
            };

            Label lblDataUltimoCad = new Label()
            {
                Text = $"Data do último cadastro: {_clienteService.GetLastCreateClient():dd/MM/yyyy}",
                AutoSize = true
            };

            pn_Dashboard.Controls.Add(lblBemVindo);
            pn_Dashboard.Controls.Add(lblTotalClientes);
            pn_Dashboard.Controls.Add(lblUltimoClienteCad);
            pn_Dashboard.Controls.Add(lblDataUltimoCad);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Cliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente(_clienteService, _cidadeService);

            cadastroCliente.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RelatorioCliente relatorioCliente = new RelatorioCliente(_cidadeService, _estadoService, _clienteService, _relatorioService);

            relatorioCliente.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
