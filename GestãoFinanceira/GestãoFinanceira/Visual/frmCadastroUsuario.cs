using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GestãoFinanceira.Utilizacao;
using MetroFramework;
using GestãoFinanceira.Modelo;
using GestãoFinanceira.Validacao;

namespace GestãoFinanceira.Visual
{
    public partial class frmCadastroUsuario : Form
    {
        //Variavel Global da classe
        Utilizacao_Conexao conexao = new Utilizacao_Conexao(Utilizacao_DadosConexao.StringConexao);
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

        public frmCadastroUsuario()
        {
            InitializeComponent();
            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
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

        //Metodo que verifica usuario cadastrado
        public void VerificaUsuario(String usuario)
        {
            int r = 0;
            validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
            r = valida_usuario.VerificaUsuario(txtUsuario.Text);
            if (r > 0)
            {
                MetroMessageBox.Show(this, "Este usuário já está cadastrado!", "VERIFICAÇÃO DE USUÁRIO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampos();
                txtUsuario.Focus();

            }
        }

        // Função Habilita campos do formulario
        public void HabilitaCampos()
        {
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
        }

        // Função desabilita campos do formulario
        public void DesabilitaCampos()
        {
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
        }

        //Metodo limpar campos
        public void LimpaCampos()
        {
            txtCodigo.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        // Metodo botao novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.AlteraBotoes(2);
            this.txtUsuario.Focus();
        }

        // Metodo botao Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlteraBotoes(2);
            this.txtUsuario.Focus();
        }

        //Metodo botão Gravar
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Usuario mod_usuario = new modelo_Usuario();
                mod_usuario.User_usuario = txtUsuario.Text;
                mod_usuario.User_password = txtPassword.Text;
                validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                if (operacao == "cadastrar")
                {
                    valida_usuario.SalvarUsuario(mod_usuario);
                    MetroMessageBox.Show(this, "\n\n Cadastrado com sucesso!", "CADASTRO DE USUÁRIO",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    mod_usuario.User_id = Convert.ToInt32(txtCodigo.Text);
                    valida_usuario.EditarUsuario(mod_usuario);
                    MetroMessageBox.Show(this, "\n\n Editado com sucesso!", "USUÁRIO EDITADO",
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

        //Metodo Excluir usuario
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MetroMessageBox.Show(this, "\n\n Tem certeza que deseja excluir permanentemente?", "CONFIRMAR EXCLUSÂO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                    valida_usuario.ExcluirUsuario(Convert.ToInt32(txtCodigo.Text));
                    MetroMessageBox.Show(this, "\n\n Excluido com sucesso!", "EXCLUSÂO DE USUÁRIO",
                       MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotoes(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n Não foi possivel excluir. \n Detalhes:" + ex.Message,
                   "ERROR AO EXCLUIR USUÁRIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                this.AlteraBotoes(3);
            }
        }

        //metodo botao pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuario fRelatorioUsuario = new frmRelatorioUsuario();
            fRelatorioUsuario.ShowDialog();
            if (fRelatorioUsuario.codigo != 0)
            {
                validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                modelo_Usuario modelo_usuario = valida_usuario.CarregarUsuario(fRelatorioUsuario.codigo);
                txtCodigo.Text = modelo_usuario.User_id.ToString();
                txtUsuario.Text = modelo_usuario.User_usuario;
                txtPassword.Text = modelo_usuario.User_password;
                AlteraBotoes(3);
            }
            else
            {
                LimpaCampos();
                txtUsuario.Focus();
                AlteraBotoes(1);
            }
            fRelatorioUsuario.Dispose();
        }

        //Metodo para pular para outro textbox
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        //Evento que verifica usuário
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            VerificaUsuario(usuario);
        }

        //metodo botao Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.txtUsuario.Focus();
            this.DesabilitaCampos();
            this.AlteraBotoes(1);
        }

        //metodo botao voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //metodo load
        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotoes(1);
        }
    }
}
