using GestãoFinanceira.Visual;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GestãoFinanceira
{
    public partial class frmPrincipal : Form
    {
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

        frmLogin flogin = new frmLogin();
        private string data = "" + DateTime.Now.ToShortDateString();
        Timer t = new Timer();

        public frmPrincipal()
        {
            InitializeComponent();

            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
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
        
        //Metodo Load
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin.usuario_logado = "Mr. Calc Gestor";
            Data();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer_Tick);
            t.Start();
            CarregaUsuarioLogado();
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

        //Evento Leave
        private void btnCadastro_Leave(object sender, EventArgs e)
        {
            btnCadastro.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Chama tela de relatorio
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new frmRelatorio();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            f.Dispose();
        }

        //Evento Leave
        private void btnRelatorio_Leave(object sender, EventArgs e)
        {
            btnRelatorio.BackColor = Color.FromArgb(24, 30, 54);
        }

        // Chama Tela de sobre;
        private void btnContato_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new frmSobre();
            f.Closed += (s, args) => this.Close();

            f.ShowDialog();
            f.Dispose();
        }

        //Evento Leave
        private void btnContato_Leave(object sender, EventArgs e)
        {
            btnContato.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Metodo calculado de juros simples
        private void btnCalcJuros_Click(object sender, EventArgs e)
        {
            btnCalcJuros.BackColor = Color.FromArgb(46, 51, 73);
            frmCalculaJurosSimples f = new frmCalculaJurosSimples();
            f.ShowDialog();
            f.Dispose();
        }

        //Evento Leave
        private void btnCalcJuros_Leave(object sender, EventArgs e)
        {
            btnCalcJuros.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
