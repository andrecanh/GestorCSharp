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
using GestãoFinanceira.Validacao;
using GestãoFinanceira.Modelo;
using MetroFramework;

namespace GestãoFinanceira.Visual
{
    public partial class frmCadastroContPagar : Form
    {
        Utilizacao_Conexao conexao = new Utilizacao_Conexao(Utilizacao_DadosConexao.StringConexao);
        utilidade_FormatarCampos utilidade_formatarCampos = new utilidade_FormatarCampos();
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

        public frmCadastroContPagar()
        {
            InitializeComponent();
            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //metodo botao voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtNumDoc.Enabled = true;
            txtDataContPagar.Enabled = true;
            txtFormaPagto.Enabled = true;
            txtValorPrincipal.Enabled = true;
            txtValorJuros.Enabled = true;
            txtValorMulta.Enabled = true;
            txtValorTotal.Enabled = false;
            txtDescricao.Enabled = true;
            btnSinc.Enabled = true;
        }

        // Função desabilita campos
        public void DesabilitaCampos()
        {
            txtNumDoc.Enabled = false;
            txtDataContPagar.Enabled = false;
            txtFormaPagto.Enabled = false;
            txtValorPrincipal.Enabled = false;
            txtValorJuros.Enabled = false;
            txtValorMulta.Enabled = false;
            txtValorTotal.Enabled = false;
            txtDescricao.Enabled = false;
            btnSinc.Enabled = false;
        }

        //Metodo limpar campos
        public void LimpaCampos()
        {
            txtNumDoc.Text = "";
            txtDataContPagar.Text = "";
            txtFormaPagto.Text = "";
            txtValorPrincipal.Text = "";
            txtValorJuros.Text = "";
            txtValorMulta.Text = "";
            txtValorTotal.Text = "";
            txtDescricao.Text = "";
        }

        //Metodo botão editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlteraBotoes(2);
            this.txtNumDoc.Focus();
        }

        //metodo botao excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MetroMessageBox.Show(this, "\n\n Tem certeza que deseja excluir permanentemente?", "CONFIRMAR EXCLUSÂO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    validacao_ContPagar valida_ContPagar = new validacao_ContPagar(conexao);
                    valida_ContPagar.ExcluirContPagar(Convert.ToInt32(txtCodigo.Text));
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
                this.txtNumDoc.Focus();
                this.AlteraBotoes(3);
            }
        }

        //metodo botao gravar
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_ContPagar modelo_ContPagar = new modelo_ContPagar();
                modelo_ContPagar.Pag_numDoc = Convert.ToInt32(txtNumDoc.Text);
                modelo_ContPagar.Pag_dataDoc = Convert.ToDateTime(txtDataContPagar.Text);
                modelo_ContPagar.Pag_formaPag = txtFormaPagto.Text;
                modelo_ContPagar.Pag_valorPrincipal = Convert.ToDecimal(txtValorPrincipal.Text.Replace(",", ".")); //Replace substitui a , para . dentro do banco.
                modelo_ContPagar.Pag_valorJuros = Convert.ToDecimal(txtValorJuros.Text.Replace("%", "").Replace(",", "."));
                modelo_ContPagar.Pag_valorMulta = Convert.ToDecimal(txtValorMulta.Text.Replace(",", "."));
                modelo_ContPagar.Pag_valorTotal = Convert.ToDecimal(txtValorTotal.Text.Replace("R$", "").Replace(",", "."));
                modelo_ContPagar.Pag_descDoc = txtDescricao.Text;
                validacao_ContPagar valida_ContPagar = new validacao_ContPagar(conexao);
                if (operacao == "cadastrar")
                {
                    valida_ContPagar.SalvarContPagar(modelo_ContPagar);
                    MetroMessageBox.Show(this, "\n\n Cadastrado com sucesso!", "CADASTRO DE CONTAS À PAGAR",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    modelo_ContPagar.Pag_id = Convert.ToInt32(txtCodigo.Text);
                    valida_ContPagar.EditarContPagar(modelo_ContPagar);
                    MetroMessageBox.Show(this, "\n\n Editado com sucesso!", "CONTAS À PAGAR EDITADO!",
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

        //metodo botao pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioContPagar fRelatorioContPagar = new frmRelatorioContPagar();
            fRelatorioContPagar.ShowDialog();
            if (fRelatorioContPagar.codigo != 0)
            {
                validacao_ContPagar valida_ContPagar = new validacao_ContPagar(conexao);
                modelo_ContPagar modelo_ContPagar = valida_ContPagar.CarregarContPagar(fRelatorioContPagar.codigo);

                txtCodigo.Text = modelo_ContPagar.Pag_id.ToString();
                txtNumDoc.Text = modelo_ContPagar.Pag_numDoc.ToString();
                txtDataContPagar.Text = modelo_ContPagar.Pag_dataDoc.ToShortDateString();
                txtFormaPagto.Text = modelo_ContPagar.Pag_formaPag;
                txtValorPrincipal.Text = Convert.ToString(modelo_ContPagar.Pag_valorPrincipal);
                txtValorJuros.Text = Convert.ToString(modelo_ContPagar.Pag_valorJuros);
                txtValorMulta.Text = Convert.ToString(modelo_ContPagar.Pag_valorMulta);
                txtValorTotal.Text = Convert.ToString(modelo_ContPagar.Pag_valorTotal);
                txtDescricao.Text = modelo_ContPagar.Pag_descDoc;

                AlteraBotoes(3);
            }
            else
            {
                LimpaCampos();
                txtNumDoc.Focus();
                AlteraBotoes(1);
            }
            fRelatorioContPagar.Dispose();
        }

        //metodo evento keypress
        private void txtDataContPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FormatarCampos.Campos edit = utilidade_FormatarCampos.Campos.DATA;
                utilidade_formatarCampos.Maskara(edit, txtDataContPagar);
            }
        }

        //metodo botao novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.AlteraBotoes(2);
            this.txtNumDoc.Focus();
        }

        //metodo botao sincroniza
        private void btnSinc_Click(object sender, EventArgs e)
        {
            double M;
            double P = Convert.ToDouble(txtValorPrincipal.Text.Replace(",", "."));
            double I = Convert.ToDouble(txtValorJuros.Text.Replace(",", ".")) / 100;
            double N = Convert.ToDouble(txtValorMulta.Text.Replace(",", "."));

            M = P + N * (1 + (I / 30));

            txtValorTotal.Text = M.ToString("C");
        }

        //metodo load
        private void frmCadastroContPagar_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotoes(1);
        }

        //metodo botao cancela
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.DesabilitaCampos();
            this.AlteraBotoes(1);
        }
    }
}
