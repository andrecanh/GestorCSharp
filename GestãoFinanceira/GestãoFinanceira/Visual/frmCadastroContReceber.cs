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
    public partial class frmCadastroContReceber : Form
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

        public frmCadastroContReceber()
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

        // Função Habilita campos
        public void HabilitaCampos()
        {
            txtNumDoc.Enabled = true;
            txtDataContReceber.Enabled = true;
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
            txtDataContReceber.Enabled = false;
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
            txtDataContReceber.Text = "";
            txtFormaPagto.Text = "";
            txtValorPrincipal.Text = "";
            txtValorJuros.Text = "";
            txtValorMulta.Text = "";
            txtValorTotal.Text = "";
            txtDescricao.Text = "";
        }

        //metodo botao cancela
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.DesabilitaCampos();
            this.AlteraBotoes(1);
        }

        //metodo botao gravar
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_ContReceber modelo_ContReceber = new modelo_ContReceber();
                modelo_ContReceber.Rec_numDoc = Convert.ToInt32(txtNumDoc.Text);
                modelo_ContReceber.Rec_dataDoc = Convert.ToDateTime(txtDataContReceber.Text);
                modelo_ContReceber.Rec_formaPagto = txtFormaPagto.Text;
                modelo_ContReceber.Rec_valorPrincipal = Convert.ToDecimal(txtValorPrincipal.Text.Replace(",", ".")); //Replace substitui a , para . dentro do banco.
                modelo_ContReceber.Rec_valorJuros = Convert.ToDecimal(txtValorJuros.Text.Replace("%", "").Replace(",", "."));
                modelo_ContReceber.Rec_valorMulta = Convert.ToDecimal(txtValorMulta.Text.Replace(",", "."));
                modelo_ContReceber.Rec_valorTotal = Convert.ToDecimal(txtValorTotal.Text.Replace("R$", "").Replace(",", "."));
                modelo_ContReceber.Rec_descricaoDoc = txtDescricao.Text;
                validacao_ContReceber valida_ContReceber = new validacao_ContReceber(conexao);
                if (operacao == "cadastrar")
                {
                    valida_ContReceber.SalvarContReceber(modelo_ContReceber);
                    MetroMessageBox.Show(this, "\n\n Cadastrado com sucesso!", "CADASTRO DE CONTA A RECEBER",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    modelo_ContReceber.Rec_id = Convert.ToInt32(txtCodigo.Text);
                    valida_ContReceber.EditarContReceber(modelo_ContReceber);
                    MetroMessageBox.Show(this, "\n\n Editado com sucesso!", "CONTA A RECEBER EDITADO!",
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

        //metodo evento keypress
        private void txtDataContReceber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FormatarCampos.Campos edit = utilidade_FormatarCampos.Campos.DATA;
                utilidade_formatarCampos.Maskara(edit, txtDataContReceber);
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

        //metodo botao sincronizar
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
        private void frmCadastroContReceber_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotoes(1);
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
                    validacao_ContReceber valida_ContReceber = new validacao_ContReceber(conexao);
                    valida_ContReceber.ExcluirContReceber(Convert.ToInt32(txtCodigo.Text));
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

        //metodo botao pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioContReceber fRelatorioContReceber = new frmRelatorioContReceber();
            fRelatorioContReceber.ShowDialog();
            if (fRelatorioContReceber.codigo != 0)
            {
                validacao_ContReceber valida_ContReceber = new validacao_ContReceber(conexao);
                modelo_ContReceber modelo_ContReceber = valida_ContReceber.CarregarContReceber(fRelatorioContReceber.codigo);

                txtCodigo.Text = modelo_ContReceber.Rec_id.ToString();
                txtNumDoc.Text = modelo_ContReceber.Rec_numDoc.ToString();
                txtDataContReceber.Text = modelo_ContReceber.Rec_dataDoc.ToShortDateString();
                txtFormaPagto.Text = modelo_ContReceber.Rec_formaPagto;
                txtValorPrincipal.Text = Convert.ToString(modelo_ContReceber.Rec_valorPrincipal);
                txtValorJuros.Text = Convert.ToString(modelo_ContReceber.Rec_valorJuros);
                txtValorMulta.Text = Convert.ToString(modelo_ContReceber.Rec_valorMulta);
                txtValorTotal.Text = Convert.ToString(modelo_ContReceber.Rec_valorTotal);
                txtDescricao.Text = modelo_ContReceber.Rec_descricaoDoc;

                AlteraBotoes(3);
            }
            else
            {
                LimpaCampos();
                txtNumDoc.Focus();
                AlteraBotoes(1);
            }
            fRelatorioContReceber.Dispose();
        }

        //metodo botao voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //metodo botao editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlteraBotoes(2);
            this.txtNumDoc.Focus();
        }
    }
}
