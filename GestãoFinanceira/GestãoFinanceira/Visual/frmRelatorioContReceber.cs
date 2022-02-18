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
    public partial class frmRelatorioContReceber : Form
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

        public frmRelatorioContReceber()
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

        //metodo botao load
        private void frmRelatorioContReceber_Load(object sender, EventArgs e)
        {
            //Muda a cor do DATAGRIDVIEW
            dvgReceber.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dvgReceber.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dvgReceber.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dvgReceber.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaContReceber(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);

            dvgReceber.Columns["rec_numDoc"].HeaderText = "Nº Documento";
            dvgReceber.Columns["rec_numDoc"].Width = 110;
            dvgReceber.Columns["rec_numDoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgReceber.Columns["rec_dataDoc"].HeaderText = "Data";
            dvgReceber.Columns["rec_dataDoc"].Width = 110;
            dvgReceber.Columns["rec_dataDoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgReceber.Columns["rec_formaPagto"].HeaderText = "Pagamento";
            dvgReceber.Columns["rec_formaPagto"].Width = 110;
            dvgReceber.Columns["rec_formaPagto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgReceber.Columns["rec_valorPrincipal"].HeaderText = "Valor";
            dvgReceber.Columns["rec_valorPrincipal"].Width = 110;
            dvgReceber.Columns["rec_valorPrincipal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgReceber.Columns["rec_valorJuros"].HeaderText = "Juros";
            dvgReceber.Columns["rec_valorJuros"].Width = 110;
            dvgReceber.Columns["rec_valorJuros"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgReceber.Columns["rec_valorMulta"].HeaderText = "Multar";
            dvgReceber.Columns["rec_valorMulta"].Width = 106;
            dvgReceber.Columns["rec_valorMulta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgReceber.Columns["rec_valorTotal"].HeaderText = "Total";
            dvgReceber.Columns["rec_valorTotal"].Width = 100;
            dvgReceber.Columns["rec_valorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Desabilita a coluna
            dvgReceber.Columns["rec_id"].Visible = false;
            dvgReceber.Columns["rec_descricaoDoc"].Visible = false;
        }

        //evento double click
        private void dvgReceber_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dvgReceber.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        //Metodo carrega informações do banco de dados;
        public void CarregaContReceber(int codigo)
        {
            validacao_ContReceber valida_ContReceber = new validacao_ContReceber(conexao);
            dvgReceber.DataSource = valida_ContReceber.CarregarContReceber(codigo);
        }

        //Metodo botão pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_ContReceber valida_ContReceber = new validacao_ContReceber(conexao);
                dvgReceber.DataSource = valida_ContReceber.ListarContReceber(txtPesquisaReceber.Text);
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
            imprimir.Title = "RELATÓRIO DE CONTA À RECEBER";
            imprimir.SubTitle = string.Format("", imprimir.SubTitle);
            imprimir.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            imprimir.PageNumbers = true;
            imprimir.PageNumberInHeader = false;
            imprimir.PorportionalColumns = true;
            imprimir.Footer = "Relatório de Contas à Receber";
            imprimir.FooterSpacing = 15;
            imprimir.PrintPreviewDataGridView(dvgReceber);
        }
    }
}
