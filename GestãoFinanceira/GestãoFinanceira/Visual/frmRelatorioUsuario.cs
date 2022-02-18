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
    public partial class frmRelatorioUsuario : Form
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

        public frmRelatorioUsuario()
        {
            InitializeComponent();
            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo carrega informações do banco de dados;
        public void CarregaUsuario(int codigo)
        {
            validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
            dgvUsuario.DataSource = valida_usuario.CarregarUsuario(codigo);
        }

        //Metodo duplo click dgv usuario
        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvUsuario.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        //Metodo load do formulário relátorio de usuario
        private void frmRelatorioUsuario_Load(object sender, EventArgs e)
        {
            //Muda a cor do DATAGRIDVIEW
            dgvUsuario.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaUsuario(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);
            dgvUsuario.Columns["user_id"].Visible = false;

            dgvUsuario.Columns["user_usuario"].HeaderText = "Nome";
            dgvUsuario.Columns["user_usuario"].Width = 379;
            dgvUsuario.Columns["user_usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Disabilita a coluna
            dgvUsuario.Columns["user_password"].HeaderText = "Senha";
            dgvUsuario.Columns["user_password"].Width = 378;
            dgvUsuario.Columns["user_password"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //metodo pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                dgvUsuario.DataSource = valida_usuario.ListarUsuario(txtPesquisaUsuario.Text);
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
            imprimir.Title = "RELATÓRIO DE USUÁRIO";
            imprimir.SubTitle = string.Format("", imprimir.SubTitle);
            imprimir.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            imprimir.PageNumbers = true;
            imprimir.PageNumberInHeader = false;
            imprimir.PorportionalColumns = true;
            imprimir.Footer = "Relatório de Usuários";
            imprimir.FooterSpacing = 15;
            imprimir.PrintPreviewDataGridView(dgvUsuario);
        }
    }
}
