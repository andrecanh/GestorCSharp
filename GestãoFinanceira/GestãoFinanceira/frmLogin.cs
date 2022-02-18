using GestãoFinanceira.Modelo;
using GestãoFinanceira.Utilizacao;
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
using MySql.Data.MySqlClient;

namespace GestãoFinanceira
{
    public partial class frmLogin : Form
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

        Utilizacao_Conexao conexao = new Utilizacao_Conexao(Utilizacao_DadosConexao.StringConexao);
        modelo_Usuario modelo_usuario = new modelo_Usuario();
        public static string usuario_logado;

        public frmLogin()
        {
            InitializeComponent();
            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Metodo botao SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //metodo load
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        //metodo limpa campos
        public void LimparCampos()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        // Metodo para realizar a verificação e validação do usuario;
        public void LogarSistema()
        {
            MySqlConnection cx = new MySqlConnection("server=localhost; user id=root; database = gestaofinanceira; Password = ");
            cx.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conectamos = new MySqlConnection();
            cmd.Connection = cx;
            cmd.CommandText = ("SELECT * FROM usuario WHERE user_usuario = @user_usuario AND user_password = @user_password");
            cmd.Parameters.Add("@user_usuario", MySqlDbType.Text).Value = txtUsuario.Text;
            cmd.Parameters.Add("@user_password", MySqlDbType.Text).Value = txtPassword.Text;
            MySqlDataReader leer = null;
            leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                usuario_logado = txtUsuario.Text;
                frmPrincipal f = new frmPrincipal();
                f.Show();
                this.Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "\n Usuário ou senha incorretos",
            "ERRO AO ACESSAR SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
                txtUsuario.Focus();
            }
            cx.Close();
        }

        //Metodo Botao Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "\n Usuário e senha são obrigatório.", "VALIDAÇÃO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
                txtUsuario.Focus();
                return;
            }
            else
            {
                LogarSistema();
            }
        }

        //Evento KeyDown
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        //Evento KeyDown
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        //Evento KeyDown
        private void btnEntrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        //Evento KeyDown
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
