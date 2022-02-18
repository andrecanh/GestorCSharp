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
    public partial class frmSobre : Form
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

        public frmSobre()
        {
            InitializeComponent();
            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Metodo botao Whatsapp
        private void btnWpp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=5517992186996&text=Ol%C3%A1%2C%20vim%20pela%20Mr.%20Calc%20e%20gostaria%20de%20mais%20informa%C3%A7%C3%B5es.");
        }

        //Metodo botao LinkedIn
        private void btnLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/andre-canh/");
        }

        //Metodo botao GitHub
        private void btnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/andrecanh");
        }

        /*-----------------------------------------------------------------------------*/

        //Metodo Load Sobre
        private void frmSobre_Load(object sender, EventArgs e)
        {
            labellVersao.Text = Application.ProductVersion;
            frmLogin.usuario_logado = "Admin";
            Data();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer_Tick);
            t.Start();
            CarregaUsuarioLogado();
        }

        //metodo botao cadastrar
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            btnCadastro.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            var f = new frmCadastro();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            f.Dispose();
        }

        //metodo botao relatorio
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            btnRelatorio.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            var f = new frmRelatorio();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            f.Dispose();
        }

        //metodo botao calculadora de juros
        private void btnCalcJuros_Click(object sender, EventArgs e)
        {
            btnCalcJuros.BackColor = Color.FromArgb(46, 51, 73);

            frmCalculaJurosSimples f = new frmCalculaJurosSimples();
            f.ShowDialog();
            f.Dispose();
        }

        //metodo botao contato
        private void btnContato_Click(object sender, EventArgs e)
        {
            btnContato.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            var f = new frmSobre();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            f.Dispose();
        }

        //metodo botao sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "\n\n Desejar realmente fechar o sistema? ",
                "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Evento leave 
        private void btnCadastro_Leave(object sender, EventArgs e)
        {
            btnCadastro.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Evento leave
        private void btnRelatorio_Leave(object sender, EventArgs e)
        {
            btnRelatorio.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Evento leave
        private void btnCalcJuros_Leave(object sender, EventArgs e)
        {
            btnCalcJuros.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Evento leave
        private void btnContato_Leave(object sender, EventArgs e)
        {
            btnContato.BackColor = Color.FromArgb(24, 30, 54);
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
    }
}
