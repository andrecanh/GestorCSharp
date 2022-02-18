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
    public partial class frmRelatorioContPagar : Form
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

        public frmRelatorioContPagar()
        {
            InitializeComponent();
            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //metodo load
        private void frmRelatorioContPagar_Load(object sender, EventArgs e)
        {
            //Muda a cor do DATAGRIDVIEW
            dgvPagar.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvPagar.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvPagar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvPagar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaContPagar(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);

            dgvPagar.Columns["pag_numDoc"].HeaderText = "Nº Documento";
            dgvPagar.Columns["pag_numDoc"].Width = 110;
            dgvPagar.Columns["pag_numDoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPagar.Columns["pag_dataDoc"].HeaderText = "Data";
            dgvPagar.Columns["pag_dataDoc"].Width = 110;
            dgvPagar.Columns["pag_dataDoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPagar.Columns["pag_formaPag"].HeaderText = "Pagamento";
            dgvPagar.Columns["pag_formaPag"].Width = 110;
            dgvPagar.Columns["pag_formaPag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPagar.Columns["pag_valorPrincipal"].HeaderText = "Valor";
            dgvPagar.Columns["pag_valorPrincipal"].Width = 110;
            dgvPagar.Columns["pag_valorPrincipal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPagar.Columns["pag_valorJuros"].HeaderText = "Juros";
            dgvPagar.Columns["pag_valorJuros"].Width = 110;
            dgvPagar.Columns["pag_valorJuros"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPagar.Columns["pag_valorMulta"].HeaderText = "Multar";
            dgvPagar.Columns["pag_valorMulta"].Width = 106;
            dgvPagar.Columns["pag_valorMulta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPagar.Columns["pag_valorTotal"].HeaderText = "Total";
            dgvPagar.Columns["pag_valorTotal"].Width = 100;
            dgvPagar.Columns["pag_valorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Desabilita a coluna
            dgvPagar.Columns["pag_id"].Visible = false;
            dgvPagar.Columns["pag_descDoc"].Visible = false;
        }

        //Metodo carrega informações do banco de dados;
        public void CarregaContPagar(int codigo)
        {
            validacao_ContPagar valida_ContPagar = new validacao_ContPagar(conexao);
            dgvPagar.DataSource = valida_ContPagar.CarregarContPagar(codigo);
        }

        //Metodo duplo click dgv
        private void dgvPagar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvPagar.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        //metodo botao voltar
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //metodo imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter imprimir = new DGVPrinter();
            imprimir.Title = "RELATÓRIO DE CONTA À PAGAR";
            imprimir.SubTitle = string.Format("", imprimir.SubTitle);
            imprimir.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            imprimir.PageNumbers = true;
            imprimir.PageNumberInHeader = false;
            imprimir.PorportionalColumns = true;
            imprimir.Footer = "Relatório de Contas à Pagar";
            imprimir.FooterSpacing = 15;
            imprimir.PrintPreviewDataGridView(dgvPagar);
        }

        //metodo botao pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_ContPagar valida_ContPagar = new validacao_ContPagar(conexao);
                dgvPagar.DataSource = valida_ContPagar.ListarContPagar(txtPesquisaPagar.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
