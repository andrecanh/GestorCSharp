using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MetroFramework.Forms;
using GestãoFinanceira.Utilizacao;
using GestãoFinanceira.Validacao;
using GestãoFinanceira.Modelo;
using MetroFramework;

namespace GestãoFinanceira.Visual
{
    public partial class frmCadastroCliente : Form
    {
        Utilizacao_Conexao conexao = new Utilizacao_Conexao(Utilizacao_DadosConexao.StringConexao);
        utilidade_FormatarCampos utilidade_formatarCampos = new utilidade_FormatarCampos();
        utilidade_ValidaCep valida_cep = new utilidade_ValidaCep();
        utilidade_ValidaCpf valida_cpf = new utilidade_ValidaCpf();
        private string usuario, operacao;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public frmCadastroCliente()
        {
            InitializeComponent();
            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public void VerificaCpf(String Usuario)
        {
            string cpfFormat = txtCpf.Text;
            int r = 0;
            validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
            r = valida_cliente.VerificaCliente(txtCpf.Text);
            if (r > 0)
            {
                MetroMessageBox.Show(this, "\n\n CPF: " + cpfFormat + " já está cadastrado!", "VERIFICACAO DE CPF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpf.Text = "";
                txtCpf.Focus();
            }
        }

        // Altera os estados dos botoes
        public void AlteraBotoes(int op)
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = false;

            if (op == 1)
            {
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
            }
            if (op == 2)
            {
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        // Função Habilita campos
        public void HabilitaCampos()
        {
            txtDataCadastro.Enabled = true;
            txtCpf.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtCep.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtObervacao.Enabled = true;
        }

        // Função desabilita campos
        public void DesabilitaCampos()
        {
            txtDataCadastro.Enabled = false;
            txtCpf.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtObervacao.Enabled = false;
        }

        //Metodo limpar campos
        public void LimpaCampos()
        {
            txtDataCadastro.Text = "";
            txtCpf.Text = "";
            txtNomeCliente.Text = "";
            txtCep.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtObervacao.Text = "";
        }

        //Metodo botão voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //metodo load
        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotoes(1);
            this.labelCpfInvalido.Visible = false;
        }

        //metodo botao cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.DesabilitaCampos();
            this.AlteraBotoes(1);
        }

        //metodo botao editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlteraBotoes(2);
            this.txtDataCadastro.Focus();
        }

        //Metodo botao excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MetroMessageBox.Show(this, "\n\n Tem certeza que deseja excluir permanentemente?", "CONFIRMAR EXCLUSÂO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                    valida_cliente.ExcluirCliente(Convert.ToInt32(txtCodigo.Text));
                    MetroMessageBox.Show(this, "\n\n Excluido com sucesso!", "EXCLUSÂO DE CLIENTE",
                       MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotoes(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n Não foi possivel excluir. \n Detalhes:" + ex.Message,
                   "ERROR AO EXCLUIR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtDataCadastro.Focus();
                this.AlteraBotoes(3);
            }
        }

        //metodo botão gravar
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Cliente modelo_cliente = new modelo_Cliente();
                modelo_cliente.Cli_dtCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                modelo_cliente.Cli_cpf = txtCpf.Text;
                modelo_cliente.Cli_nome = txtNomeCliente.Text;
                modelo_cliente.Cli_cep = txtCep.Text;
                modelo_cliente.Cli_endereco = txtEndereco.Text;
                modelo_cliente.Cli_numero = Convert.ToInt32(txtNumero.Text);
                modelo_cliente.Cli_complemento = txtComplemento.Text;
                modelo_cliente.Cli_bairro = txtBairro.Text;
                modelo_cliente.Cli_cidade = txtCidade.Text;
                modelo_cliente.Cli_estado = txtEstado.Text;
                modelo_cliente.Cli_fonecelular = txtTelefone.Text;
                modelo_cliente.Cli_email = txtEmail.Text;
                modelo_cliente.Cli_observacao = txtObervacao.Text;
                validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                if (operacao == "cadastrar")
                {
                    valida_cliente.SalvarCliente(modelo_cliente);
                    MetroMessageBox.Show(this, "\n\n Cadastrado com sucesso!", "CADASTRO DE CLIENTE",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    modelo_cliente.Cli_id = Convert.ToInt32(txtCodigo.Text);
                    valida_cliente.EditarCliente(modelo_cliente);
                    MetroMessageBox.Show(this, "\n\n Editado com sucesso!", "CLIENTE EDITADO",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                this.LimpaCampos();
                this.AlteraBotoes(1);
                this.DesabilitaCampos();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n Não foi possivel efeturar está operação. \n Detalhes:" + ex.Message,
                    "ERROR AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        //Metodo botao pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente fRelatorioCliente = new frmRelatorioCliente();
            fRelatorioCliente.ShowDialog();
            if (fRelatorioCliente.codigo != 0)
            {
                validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                modelo_Cliente modelo_cliente = valida_cliente.CarregarCliente(fRelatorioCliente.codigo);
                txtCodigo.Text = modelo_cliente.Cli_id.ToString();
                txtDataCadastro.Text = modelo_cliente.Cli_dtCadastro.ToShortDateString();
                txtCpf.Text = modelo_cliente.Cli_cpf;
                txtNomeCliente.Text = modelo_cliente.Cli_nome;
                txtCep.Text = modelo_cliente.Cli_cep;
                txtEndereco.Text = modelo_cliente.Cli_endereco;
                txtNumero.Text = modelo_cliente.Cli_numero.ToString();
                txtComplemento.Text = modelo_cliente.Cli_complemento;
                txtBairro.Text = modelo_cliente.Cli_bairro;
                txtCidade.Text = modelo_cliente.Cli_cidade;
                txtEstado.Text = modelo_cliente.Cli_estado;
                txtTelefone.Text = modelo_cliente.Cli_fonecelular;
                txtEmail.Text = modelo_cliente.Cli_email;
                txtObervacao.Text = modelo_cliente.Cli_observacao;
                AlteraBotoes(3);
            }
            else
            {
                LimpaCampos();
                txtDataCadastro.Focus();
                AlteraBotoes(1);
            }
            fRelatorioCliente.Dispose();
        }

        //Evento KeyPress TXT CEP
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FormatarCampos.Campos edit = utilidade_FormatarCampos.Campos.CEP;
                utilidade_formatarCampos.Maskara(edit, txtCep);
            }
        }

        //Evento KeyPress TXT CPF
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FormatarCampos.Campos edit = utilidade_FormatarCampos.Campos.CPF;
                utilidade_formatarCampos.Maskara(edit, txtCpf);
            }
        }

        //Evento KeyPress DATETIME DATA
        private void txtDataCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FormatarCampos.Campos edit = utilidade_FormatarCampos.Campos.DATA;
                utilidade_formatarCampos.Maskara(edit, txtDataCadastro);
            }
        }

        //Evento KeyPress TXT TELEFONE
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FormatarCampos.Campos edit = utilidade_FormatarCampos.Campos.CELULAR;
                utilidade_formatarCampos.Maskara(edit, txtTelefone);
            }
        }

        //Evento Leave CEP
        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (valida_cep.verificaCEP(txtCep.Text) == true)
            {
                txtBairro.Text = utilidade_ValidaCep.bairro;
                txtEstado.Text = utilidade_ValidaCep.estado;
                txtCidade.Text = utilidade_ValidaCep.cidade;
                txtEndereco.Text = utilidade_ValidaCep.endereco;
                txtComplemento.Text = utilidade_ValidaCep.complemento;
            }
        }

        //Evento Leave CPF
        private void txtCpf_Leave(object sender, EventArgs e)
        {
            VerificaCpf(usuario);
            if (txtCpf.Visible == true)
            {
                if (valida_cpf.ValidaCPF(txtCpf.Text) == false)
                {
                    labelCpfInvalido.Visible = true;
                }

                else
                {
                    labelCpfInvalido.Visible = false;
                }
            }
            if (txtCpf.Text == "")
            {
                labelCpfInvalido.Visible = false;
            }
        }

        //metodo botao novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.AlteraBotoes(2);
            this.txtDataCadastro.Focus();
        }

    }
}
