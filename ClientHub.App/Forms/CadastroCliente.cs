using ClientHub.Application;
using System;
using System.Linq;
using System.Windows.Forms;
using FastReport;
using FastReport.Data;

namespace ClientHub.App.Forms
{
    public partial class CadastroCliente : Form
    {
        private readonly ClienteService _clienteService;
        private readonly CidadeService _cidadeService;
        ClientHubEntities1 db = new ClientHubEntities1();

        public CadastroCliente(ClienteService clienteService, CidadeService cidadeService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _cidadeService = cidadeService;
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarClienteForm adicionarClienteForm = new AdicionarClienteForm(_clienteService, _cidadeService);

            if (adicionarClienteForm.ShowDialog() == DialogResult.OK)
            {
                RefreshTable();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as cliente;

            if (selectedRow == null)
            {
                MessageBox.Show("Selecione um cliente para excluir.");
                return;
            }

            int clienteId = selectedRow.id;

            int[] bloqueados = { 1, 5, 8, 10, 15 };

            if (bloqueados.Contains(clienteId))
            {
                MessageBox.Show("Não é possível excluir esse cliente.");
                return;
            }

            var confirm = MessageBox.Show($"Deseja realmente excluir o cliente {selectedRow.nome}?",
                                          "Confirmação", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                _clienteService.DeleteCliente(clienteId);
                MessageBox.Show("Cliente excluído com sucesso!");

                RefreshTable();
            }
        }

        private void RefreshTable()
        {
            clienteBindingSource.DataSource = db.clientes.AsNoTracking().ToList();
            cidadeBindingSource.DataSource = db.cidades.AsNoTracking().ToList();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as cliente;

            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.Id = selectedRow.id;
            clienteDTO.Nome = selectedRow.nome;
            clienteDTO.CEP = selectedRow.cep;
            clienteDTO.CPF_CNPJ = selectedRow.cpf_cnpj;
            clienteDTO.Endereco = selectedRow.endereco;
            clienteDTO.Numero = selectedRow.numero;
            clienteDTO.Complemento = selectedRow.complemento;
            clienteDTO.Bairro = selectedRow.bairro;
            clienteDTO.DataNascimento = selectedRow.data_nascimento;
            clienteDTO.CidadeId = selectedRow.cidadeId;

            AdicionarClienteForm adicionarClienteForm = new AdicionarClienteForm(_clienteService, _cidadeService, clienteDTO);

            if (adicionarClienteForm.ShowDialog() == DialogResult.OK)
            {
                RefreshTable();
            }
        }
    }
}
