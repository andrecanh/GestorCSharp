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
    public partial class frmCadastroEmpresa : Form
    {
        Utilizacao_Conexao conexao = new Utilizacao_Conexao(Utilizacao_DadosConexao.StringConexao);
        utilidade_FormatarCampos utilidade_formatarCampos = new utilidade_FormatarCampos();
        utilidade_ValidaCep valida_cep = new utilidade_ValidaCep();
        utilidade_ValidaCnpj valida_cnpj = new utilidade_ValidaCnpj();
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

        public frmCadastroEmpresa()
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

        public void VerificaCnpj(String Usuario)
        {
            string cnpjFormat = txtCnpj.Text;
            int r = 0;
            validacao_Empresa valida_empresa = new validacao_Empresa(conexao);
            r = valida_empresa.VerificaEmpresa(txtCnpj.Text);
            if (r > 0)
            {
                MetroMessageBox.Show(this, "\n\n CNPJ: " + cnpjFormat + " já está cadastrado!", "VERIFICACAO DE CNPJ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCnpj.Text = "";
                txtCnpj.Focus();
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
            txtCnpj.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtCep.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtTelefoneCelular.Enabled = true;
            txtTelefoneFixo.Enabled = true;
            txtEmail.Enabled = true;
            txtObervacao.Enabled = true;
        }

        // Função desabilita campos
        public void DesabilitaCampos()
        {
            txtDataCadastro.Enabled = false;
            txtCnpj.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtTelefoneCelular.Enabled = false;
            txtTelefoneFixo.Enabled = false;
            txtEmail.Enabled = false;
            txtObervacao.Enabled = false;
        }
        
        //Metodo limpar campos
        public void LimpaCampos()
        {
            txtDataCadastro.Text = "";
            txtCnpj.Text = "";
            txtRazaoSocial.Text = "";
            txtCep.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtTelefoneCelular.Text = "";
            txtTelefoneFixo.Text = "";
            txtEmail.Text = "";
            txtObervacao.Text = "";
        }

        //metodo botao Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlteraBotoes(2);
            this.txtDataCadastro.Focus();
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
                    validacao_Empresa valida_empresa = new validacao_Empresa(conexao);
                    valida_empresa.ExcluirEmpresa(Convert.ToInt32(txtCodigo.Text));
                    MetroMessageBox.Show(this, "\n\n Excluido com sucesso!", "EXCLUSÂO DE EMPRESA",
                       MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotoes(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n Não foi possivel excluir. \n Detalhes:" + ex.Message,
                   "ERROR AO EXCLUIR EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtDataCadastro.Focus();
                this.AlteraBotoes(3);
            }
        }

        //metodo botao gravar
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Empresa modelo_Empresa = new modelo_Empresa();
                modelo_Empresa.Emp_dataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                modelo_Empresa.Emp_cnpj = txtCnpj.Text;
                modelo_Empresa.Emp_razao = txtRazaoSocial.Text;
                modelo_Empresa.Emp_cep = txtCep.Text;
                modelo_Empresa.Emp_endereco = txtEndereco.Text;
                modelo_Empresa.Emp_numero = Convert.ToInt32(txtNumero.Text);
                modelo_Empresa.Emp_complemento = txtComplemento.Text;
                modelo_Empresa.Emp_bairro = txtBairro.Text;
                modelo_Empresa.Emp_cidade = txtCidade.Text;
                modelo_Empresa.Emp_estado = txtEstado.Text;
                modelo_Empresa.Emp_fonefixo = txtTelefoneFixo.Text;
                modelo_Empresa.Emp_fonecelular = txtTelefoneCelular.Text;
                modelo_Empresa.Emp_email = txtEmail.Text;
                modelo_Empresa.Emp_observacao = txtObervacao.Text;

                validacao_Empresa valida_empresa = new validacao_Empresa(conexao);
                if (operacao == "cadastrar")
                {
                    valida_empresa.SalvarEmpresa(modelo_Empresa);
                    MetroMessageBox.Show(this, "\n\n Cadastrado com sucesso!", "CADASTRO DE EMPRESA",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    modelo_Empresa.Emp_id = Convert.ToInt32(txtCodigo.Text);
                    valida_empresa.EditarEmpresa(modelo_Empresa);
                    MetroMessageBox.Show(this, "\n\n Editado com sucesso!", "EMPRESA EDITADA",
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
            frmRelatorioEmpresa fRelatorioEmpresa = new frmRelatorioEmpresa();
            fRelatorioEmpresa.ShowDialog();
            if (fRelatorioEmpresa.codigo != 0)
            {
                validacao_Empresa valida_empresa = new validacao_Empresa(conexao);
                modelo_Empresa modelo_empresa = valida_empresa.CarregarEmpresa(fRelatorioEmpresa.codigo);
                txtCodigo.Text = modelo_empresa.Emp_id.ToString();
                txtDataCadastro.Text = modelo_empresa.Emp_dataCadastro.ToShortDateString();
                txtCnpj.Text = modelo_empresa.Emp_cnpj;
                txtRazaoSocial.Text = modelo_empresa.Emp_razao;
                txtCep.Text = modelo_empresa.Emp_cep;
                txtEndereco.Text = modelo_empresa.Emp_endereco;
                txtNumero.Text = modelo_empresa.Emp_numero.ToString();
                txtComplemento.Text = modelo_empresa.Emp_complemento;
                txtBairro.Text = modelo_empresa.Emp_bairro;
                txtCidade.Text = modelo_empresa.Emp_cidade;
                txtEstado.Text = modelo_empresa.Emp_estado;
                txtTelefoneFixo.Text = modelo_empresa.Emp_fonefixo;
                txtTelefoneCelular.Text = modelo_empresa.Emp_fonecelular;
                txtEmail.Text = modelo_empresa.Emp_email;
                txtObervacao.Text = modelo_empresa.Emp_observacao;
                AlteraBotoes(3);
            }
            else
            {
                LimpaCampos();
                txtDataCadastro.Focus();
                AlteraBotoes(1);
            }
            fRelatorioEmpresa.Dispose();
        }

        //metodo botao novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.AlteraBotoes(2);
            this.txtDataCadastro.Focus();
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

        //Evento KeyPress TXT CNPJ
        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FormatarCampos.Campos edit = utilidade_FormatarCampos.Campos.CNPJ;
                utilidade_formatarCampos.Maskara(edit, txtCnpj);
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

        //Evento KeyPress TXT CELULAR
        private void txtTelefoneCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FormatarCampos.Campos edit = utilidade_FormatarCampos.Campos.CELULAR;
                utilidade_formatarCampos.Maskara(edit, txtTelefoneCelular);
            }
        }

        //Evento KeyPress TXT TELEFONE FIXO
        private void txtTelefoneFixo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FormatarCampos.Campos edit = utilidade_FormatarCampos.Campos.FIXO;
                utilidade_formatarCampos.Maskara(edit, txtTelefoneFixo);
            }
        }

        //metodo evento leave CEP
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

        //metodo evento leave CNPJ
        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            VerificaCnpj(usuario);
            if (txtCnpj.Visible == true)
            {
                if (valida_cnpj.ValidaCnpj(txtCnpj.Text) == false)
                {
                    labelCnpjInvalido.Visible = true;
                }
                else
                {
                    labelCnpjInvalido.Visible = false;
                }
            }
            if (txtCnpj.Text == "")
            {
                labelCnpjInvalido.Visible = false;
            }
        }

        //metodo load
        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotoes(1);
            this.labelCnpjInvalido.Visible = false;
        }

        //metodo botao cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.DesabilitaCampos();
            this.AlteraBotoes(1);
        }
    }
}
