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
    public partial class frmRelatorioCliente : Form
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

        public frmRelatorioCliente()
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

        //metodo load
        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {
            //Muda a cor do DATAGRIDVIEW
            dgvCliente.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaCliente(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);
            //dgvCliente.Columns["cli_id"].HeaderText = "Código";
            //dgvCliente.Columns["cli_id"].Width = 50;

            dgvCliente.Columns["cli_cpf"].HeaderText = "CPF";
            dgvCliente.Columns["cli_cpf"].Width = 90;
            dgvCliente.Columns["cli_cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCliente.Columns["cli_nome"].HeaderText = "Nome";
            dgvCliente.Columns["cli_nome"].Width = 162;
            dgvCliente.Columns["cli_nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCliente.Columns["cli_endereco"].HeaderText = "Endereço";
            dgvCliente.Columns["cli_endereco"].Width = 150;
            dgvCliente.Columns["cli_endereco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCliente.Columns["cli_numero"].HeaderText = "Número";
            dgvCliente.Columns["cli_numero"].Width = 50;
            dgvCliente.Columns["cli_numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCliente.Columns["cli_cep"].HeaderText = "CEP";
            dgvCliente.Columns["cli_cep"].Width = 65;
            dgvCliente.Columns["cli_cep"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCliente.Columns["cli_bairro"].HeaderText = "Bairro";
            dgvCliente.Columns["cli_bairro"].Width = 150;
            dgvCliente.Columns["cli_bairro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCliente.Columns["cli_foneCelular"].HeaderText = "Telefone";
            dgvCliente.Columns["cli_foneCelular"].Width = 85;
            dgvCliente.Columns["cli_foneCelular"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Desabilita a coluna
            dgvCliente.Columns["cli_id"].Visible = false;
            dgvCliente.Columns["cli_dataCadastro"].Visible = false;
            dgvCliente.Columns["cli_complemento"].Visible = false;
            dgvCliente.Columns["cli_cidade"].Visible = false;
            dgvCliente.Columns["cli_estado"].Visible = false;
            dgvCliente.Columns["cli_email"].Visible = false;
            dgvCliente.Columns["cli_observacao"].Visible = false;
        }

        //Metodo carrega informações do banco de dados;
        public void CarregaCliente(int codigo)
        {
            validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
            dgvCliente.DataSource = valida_cliente.CarregarCliente(codigo);
        }

        //Metodo duplo click dgv
        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        //metodo botão pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                dgvCliente.DataSource = valida_cliente.ListarCliente(txtPesquisaCliente.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter imprimir = new DGVPrinter();
            imprimir.Title = "RELATÓRIO DE CLIENTE";
            imprimir.SubTitle = string.Format("", imprimir.SubTitle);
            imprimir.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            imprimir.PageNumbers = true;
            imprimir.PageNumberInHeader = false;
            imprimir.PorportionalColumns = true;
            imprimir.Footer = "Relatório de Clientes";
            imprimir.FooterSpacing = 15;
            imprimir.PrintPreviewDataGridView(dgvCliente);
        }
    }
}
