using ClientHub.Application;
using ClientHub.Application.DTOs;
using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHub.App.Forms
{
    public partial class AdicionarClienteForm : Form
    {
        private readonly ClienteService _clienteService;
        private readonly CidadeService _cidadeService;
        private ClienteDTO _clienteDTO;

        public AdicionarClienteForm(ClienteService clienteService, CidadeService cidadeService, ClienteDTO clienteDTO = null)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _cidadeService = cidadeService;
            _clienteDTO = clienteDTO;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var formValid = ValidateForm();

            if (!formValid)
                return;

            string cpfCnpj = new string(maskedCpfCnpj.Text.Where(char.IsDigit).ToArray());

            var clienteDto = new ClienteDTO
            {
                Nome = txtNome.Text,
                CEP = maskedCEP.Text.Replace("-", ""),
                CPF_CNPJ = cpfCnpj,
                Endereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                DataNascimento = dataNascimentoPicker.Value, 
                CidadeId = (int)cmbCidade.SelectedValue
            };

            try
            {
                if (_clienteDTO != null)
                {
                    clienteDto.Id = _clienteDTO.Id;
                    await _clienteService.UpdateCliente(clienteDto);

                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _clienteService.CreateCliente(clienteDto);

                    MessageBox.Show("Cliente adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Número é obrigatório!");
                return false;
            }

            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro é obrigatório!");
                return false;
            }

            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereço é obrigatório!");
                return false;
            }

            if (!maskedCEP.MaskFull)
            {
                MessageBox.Show("CEP incompleto!");
                return false;
            }

            if (dataNascimentoPicker.Value > DateTime.Today)
            {
                MessageBox.Show("Data de nascimento inválida!");
                return false;
            }

            if (txtNumero.Text.Length > 20)
            {
                MessageBox.Show("Número não pode ter mais de 20 dígitos!");
                return false;
            }

            return true;
        }

        private void AdicionarClienteForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(AdicionarClienteForm_KeyDown);

            rbCPF.Checked = true;

            SetCpfCnpjMask();

            cmbCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadCities();

            maskedCEP.Mask = "00000-000";
            maskedCEP.PromptChar = '_';
            maskedCEP.ValidatingType = typeof(string);

            dataNascimentoPicker.Format = DateTimePickerFormat.Short;
            dataNascimentoPicker.MaxDate = DateTime.Today;

            maskedCpfCnpj.PromptChar = '_';
            maskedCpfCnpj.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            if (_clienteDTO != null)
            {
                txtNome.Text = _clienteDTO.Nome;
                maskedCEP.Text = _clienteDTO.CEP;
                maskedCpfCnpj.Text = _clienteDTO.CPF_CNPJ;
                txtEndereco.Text = _clienteDTO.Endereco;
                txtNumero.Text = _clienteDTO.Numero;
                txtComplemento.Text = _clienteDTO.Complemento;
                txtBairro.Text = _clienteDTO.Bairro;
                dataNascimentoPicker.Value = _clienteDTO.DataNascimento;
                cmbCidade.SelectedValue = _clienteDTO.CidadeId;

                btnSalvar.Text = "Atualizar";
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            SetCpfCnpjMask();
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            SetCpfCnpjMask();
        }

        private void SetCpfCnpjMask()
        {
            if (rbCPF.Checked)
                maskedCpfCnpj.Mask = "000.000.000-00";
            else
                maskedCpfCnpj.Mask = "00.000.000/0000-00";

            maskedCpfCnpj.Text = "";
        }

        private void LoadCities()
        {
            var cities = _cidadeService.GetAllCities();

            cmbCidade.DataSource = cities.ToList();
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "Id";
        }

        private async void maskedCEP_Leave(object sender, EventArgs e)
        {
            string cep = maskedCEP.Text.Trim().Replace("-", "").Replace(".", "");

            if (string.IsNullOrEmpty(cep)) return;

            var dados = await ConsultarCepAsync(cep);

            if (dados == null || dados.Erro == "true")
            {
                MessageBox.Show("CEP inválido.");
                return;
            }

            txtEndereco.Text = dados.Logradouro;
            txtBairro.Text = dados.Bairro;

            var cidade = _cidadeService.GetCityForName(dados.Localidade);

            if (cidade != null)
            {
                cmbCidade.SelectedValue = cidade.Id;
            }
        }

        public async Task<ViaCepResponse> ConsultarCepAsync(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                if (!response.IsSuccessStatusCode)
                    return null;

                var json = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ViaCepResponse>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return result;
            }
        }

        private void AdicionarClienteForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
