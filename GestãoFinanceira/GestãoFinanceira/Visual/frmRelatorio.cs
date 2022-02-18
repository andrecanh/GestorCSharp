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
using MetroFramework;

namespace GestãoFinanceira.Visual
{
    public partial class frmRelatorio : Form
    {
        frmLogin flogin = new frmLogin();
        private string data = "" + DateTime.Now.ToShortDateString();
        Timer t = new Timer();

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

        public frmRelatorio()
        {
            InitializeComponent();
            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Chama tela de relatorio de usuario
        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuario f = new frmRelatorioUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        //Chama tela de relatorio de cliente
        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente f = new frmRelatorioCliente();
            f.ShowDialog();
            f.Dispose();
        }

        //Chama tela de relatorio de empresa
        private void btnCadastroEmpresa_Click(object sender, EventArgs e)
        {
            frmRelatorioEmpresa f = new frmRelatorioEmpresa();
            f.ShowDialog();
            f.Dispose();
        }

        //Chama tela de relatorio da Contas a pagar
        private void btnContPagar_Click(object sender, EventArgs e)
        {
            frmRelatorioContPagar f = new frmRelatorioContPagar();
            f.ShowDialog();
            f.Dispose();
        }

        //Chama tela de relatorio da Contas a receber
        private void btnContReceber_Click(object sender, EventArgs e)
        {
            frmRelatorioContReceber f = new frmRelatorioContReceber();
            f.ShowDialog();
            f.Dispose();
        }

        /*-----------------------------------------------------------------------------*/

        // Chama Tela de Cadastro;
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            btnCadastro.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            var f = new frmCadastro();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            f.Dispose();
        }

        //metodo chama tela de relatorio
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            btnRelatorio.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            var f = new frmRelatorio();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            f.Dispose();
        }

        //Metodo calculado de juros simples
        private void btnCalcJuros_Click(object sender, EventArgs e)
        {
            btnCalcJuros.BackColor = Color.FromArgb(46, 51, 73);

            frmCalculaJurosSimples f = new frmCalculaJurosSimples();
            f.ShowDialog();
            f.Dispose();
        }

        //metodo chama tela de contato
        private void btnContato_Click(object sender, EventArgs e)
        {
            btnContato.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            var f = new frmSobre();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            f.Dispose();
        }

        //Metodo botao sair;
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "\n\n Desejar realmente fechar o sistema? ",
                "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Metodo para trazer hora real;
        private void timer_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            labelHora.Text = "" + time;
        }

        // Metodo carregar data e hora;
        public void Data()
        {
            labelData.Text = data;
        }

        // Metodo carrega usuário logado no sistema em uma textbox ou label;
        private void CarregaUsuarioLogado()
        {
            labelUsuarioConectado.Text = frmLogin.usuario_logado;
        }

        //Evento Leave
        private void btnCadastro_Leave(object sender, EventArgs e)
        {
            btnCadastro.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Evento Leave
        private void btnRelatorio_Leave(object sender, EventArgs e)
        {
            btnRelatorio.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Evento Leave
        private void btnCalcJuros_Leave(object sender, EventArgs e)
        {
            btnCalcJuros.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Evento Leave
        private void btnContato_Leave(object sender, EventArgs e)
        {
            btnContato.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Metodo load
        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            frmLogin.usuario_logado = "Admin";
            Data();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer_Tick);
            t.Start();
            CarregaUsuarioLogado();
        }
    }
}
