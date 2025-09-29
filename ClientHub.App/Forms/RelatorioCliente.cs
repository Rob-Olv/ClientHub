using ClientHub.Application;
using FastReport;
using FastReport.Export.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinApp = System.Windows.Forms;

namespace ClientHub.App.Forms
{
    public partial class RelatorioCliente : Form
    {
        private readonly CidadeService _cidadeService;
        private readonly EstadoService _estadoService;
        private readonly ClienteService _clienteService;
        private readonly RelatorioService _relatorioService;
        public RelatorioCliente(CidadeService cidadeService, EstadoService estadoService, ClienteService clienteService, RelatorioService relatorioService)
        {
            InitializeComponent();
            _cidadeService = cidadeService;
            _estadoService = estadoService;
            _clienteService = clienteService;
            _relatorioService = relatorioService;
        }

        private void RelatorioCliente_Load(object sender, EventArgs e)
        {
            cmbCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadStates();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            int? idInicial = null;
            int? idFinal = null;
            int? cidadeId = null;
            int? estadoId = null;

            if (!cbTodos.Checked)
            {
                idInicial = string.IsNullOrEmpty(txtIdInicial.Text) ? (int?)null : Convert.ToInt32(txtIdInicial.Text);
                idFinal = string.IsNullOrEmpty(txtIdFinal.Text) ? (int?)null : Convert.ToInt32(txtIdFinal.Text);
                cidadeId = cmbCidade.SelectedValue == null ? (int?)null : (int)cmbCidade.SelectedValue;
                estadoId = cmbEstado.SelectedValue == null ? (int?)null : (int)cmbEstado.SelectedValue;
            }

             var clientesDto = _relatorioService.FiltrarRelatorio(idInicial, idFinal, cidadeId, estadoId);

            if (clientesDto == null || clientesDto.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado para os filtros selecionados.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AbrirRelatorio(clientesDto);
        }

        private void AbrirRelatorio(List<ClienteDTO> clientes)
        {
            Report report = new Report();
            string reportPath = Path.Combine(WinApp.Application.StartupPath, "RelatorioClientes.frx");
            report.Load(reportPath);

            report.RegisterData(clientes, "Clientes");
            report.GetDataSource("Clientes").Enabled = true;

            string pastaRelatorio = Path.Combine(WinApp.Application.StartupPath, "Relatorios");
            if (!Directory.Exists(pastaRelatorio))
                Directory.CreateDirectory(pastaRelatorio);

            string caminhoPdf = Path.Combine(pastaRelatorio, "RelatorioClientes.pdf");

            if (report.Prepare())
            {
                PDFExport export = new PDFExport();
                report.Export(export, caminhoPdf);

                Process.Start(new ProcessStartInfo
                {
                    FileName = caminhoPdf,
                    UseShellExecute = true
                });
            }
            report.Dispose();
        }

        private void txtIdInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtIdFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //private void GerarTemplateRelatorio(List<ClienteDTO> clientes)
        //{
        //    var caminhoReport = "C:\\Projetos pessoais\\ClientHub\\ClientHub.App\\RelatorioClientes.frx";
        //    var reportFile = caminhoReport;

        //    var freport = new FastReport.Report();

        //    freport.Dictionary.RegisterBusinessObject(clientes, "Clientes", 10, true);
        //    freport.Report.Save(reportFile);
        //}

        private void LoadCities(int estadoId)
        {
            var cities = _cidadeService.GetAllCitiesForState(estadoId);

            cmbCidade.DataSource = cities.ToList();
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "Id";
            cmbCidade.SelectedIndex = -1;
            cmbCidade.Enabled = true;
            cmbCidade.BackColor = Color.White;
        }

        private void LoadStates()
        {
            var states = _estadoService.GetAllStates();

            cmbEstado.DataSource = states.ToList();
            cmbEstado.DisplayMember = "Nome";
            cmbEstado.ValueMember = "Id";
            cmbEstado.SelectedIndex = -1;

            cmbCidade.Enabled = false;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex == -1)
            {
                cmbCidade.DataSource = null;
                cmbCidade.Enabled = false;
                return;
            }

            if (!int.TryParse(cmbEstado.SelectedValue.ToString(), out int estadoId))
            {
                return;
            }

            LoadCities(estadoId);
        }

        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbTodos.Checked)
            {
                cmbCidade.Enabled = true;

                cmbEstado.Enabled = true;

                txtIdFinal.Enabled = true;

                txtIdInicial.Enabled = true;
            }
            else
            {
                cmbCidade.Enabled = false;
                cmbCidade.SelectedValue = -1;

                cmbEstado.Enabled = false;
                cmbEstado.SelectedValue = -1;

                txtIdFinal.Enabled = false;
                txtIdFinal.Text = "";

                txtIdInicial.Enabled = false;
                txtIdInicial.Text = "";
            }
        }
    }
}
