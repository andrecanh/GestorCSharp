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
using DGVPrinterHelper;

namespace GestãoFinanceira.Visual
{
    public partial class frmRelatorioEmpresa : Form
    {
        //Variavel Global da classe
        public int codigo = 0;
        Utilizacao_Conexao conexao = new Utilizacao_Conexao(Utilizacao_DadosConexao.StringConexao);

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

        public frmRelatorioEmpresa()
        {
            InitializeComponent();
            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRelatorioEmpresa_Load(object sender, EventArgs e)
        {
            //Muda a cor do DATAGRIDVIEW
            dgvEmpresa.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvEmpresa.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvEmpresa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvEmpresa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaEmpresa(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);
            //dgvEmpresa.Columns["emp_id"].HeaderText = "Código";
            //dgvEmpresa.Columns["emp_id"].Width = 50;

            dgvEmpresa.Columns["emp_cnpj"].HeaderText = "CNPJ";
            dgvEmpresa.Columns["emp_cnpj"].Width = 105;
            dgvEmpresa.Columns["emp_cnpj"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmpresa.Columns["emp_razao"].HeaderText = "Nome";
            dgvEmpresa.Columns["emp_razao"].Width = 170;
            dgvEmpresa.Columns["emp_razao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmpresa.Columns["emp_endereco"].HeaderText = "Endereço";
            dgvEmpresa.Columns["emp_endereco"].Width = 140;
            dgvEmpresa.Columns["emp_endereco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmpresa.Columns["emp_numero"].HeaderText = "Nº";
            dgvEmpresa.Columns["emp_numero"].Width = 50;
            dgvEmpresa.Columns["emp_numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmpresa.Columns["emp_cep"].HeaderText = "CEP";
            dgvEmpresa.Columns["emp_cep"].Width = 65;
            dgvEmpresa.Columns["emp_cep"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmpresa.Columns["emp_bairro"].HeaderText = "Bairro";
            dgvEmpresa.Columns["emp_bairro"].Width = 160;
            dgvEmpresa.Columns["emp_bairro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmpresa.Columns["emp_fonefixo"].HeaderText = "Tel Fixo";
            dgvEmpresa.Columns["emp_fonefixo"].Width = 85;
            dgvEmpresa.Columns["emp_fonefixo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmpresa.Columns["emp_foneCelular"].HeaderText = "Celular";
            dgvEmpresa.Columns["emp_foneCelular"].Width = 85;
            dgvEmpresa.Columns["emp_foneCelular"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Desabilita a coluna
            dgvEmpresa.Columns["emp_id"].Visible = false;
            dgvEmpresa.Columns["emp_dataCadastro"].Visible = false;
            dgvEmpresa.Columns["emp_complemento"].Visible = false;
            dgvEmpresa.Columns["emp_cidade"].Visible = false;
            dgvEmpresa.Columns["emp_estado"].Visible = false;
            dgvEmpresa.Columns["emp_email"].Visible = false;
            dgvEmpresa.Columns["emp_observacao"].Visible = false;
        }

        //Metodo carrega informações do banco de dados;
        public void CarregaEmpresa(int codigo)
        {
            validacao_Empresa valida_empresa = new validacao_Empresa(conexao);
            dgvEmpresa.DataSource = valida_empresa.CarregarEmpresa(codigo);
        }

        //Metodo duplo click dgv
        private void dvgEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvEmpresa.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        //Metodo botão pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Empresa valida_empresa = new validacao_Empresa(conexao);
                dgvEmpresa.DataSource = valida_empresa.ListarEmpresa(txtPesquisaEmpresa.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo botao imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter imprimir = new DGVPrinter();
            imprimir.Title = "RELATÓRIO DE EMPRESA";
            imprimir.SubTitle = string.Format("", imprimir.SubTitle);
            imprimir.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            imprimir.PageNumbers = true;
            imprimir.PageNumberInHeader = false;
            imprimir.PorportionalColumns = true;
            imprimir.Footer = "Relatório de Empresa";
            imprimir.FooterSpacing = 15;
            imprimir.PrintPreviewDataGridView(dgvEmpresa);
        }
    }
}
