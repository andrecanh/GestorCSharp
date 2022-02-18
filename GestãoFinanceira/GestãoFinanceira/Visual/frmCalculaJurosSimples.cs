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
using MetroFramework.Forms;

namespace GestãoFinanceira.Visual
{
    public partial class frmCalculaJurosSimples : MetroForm
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

        public frmCalculaJurosSimples()
        {
            InitializeComponent();
            //Curvas nas bordas
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Metodo botão Calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double M;
            double P = Convert.ToDouble(txtValorParcela.Text);
            double I = Convert.ToDouble(txtTaxaJuros.Text) / 100;
            double N = Convert.ToDouble(txtDiasAtraso.Text);

            M = P * (1 + (I * (N / 30)));

            txtValorPagar.Text = M.ToString("C");
        }

        //Metodo botão limpa campos
        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            this.txtValorParcela.Text = "";
            this.txtValorPagar.Text = "";
            this.txtTaxaJuros.Text = "";
            this.txtDiasAtraso.Text = "";
            txtValorParcela.Focus();
        }

        //Evento Leave
        private void txtValorParcela_Leave(object sender, EventArgs e)
        {
            if (txtValorParcela.Text.Contains(",") == false)
            {
                txtValorParcela.Text += ",00";
            }
            else
            {
                if (txtValorParcela.Text.IndexOf(",") == txtValorParcela.Text.Length - 1)
                {
                    txtValorParcela.Text += "00";
                }
            }
        }

        //Evento Keypress
        private void txtValorParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorParcela.Text.Contains(","))
                {
                    e.KeyChar = '.';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        //Evento KeyDown
        private void frmCalculaJurosSimples_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        //Evento Leave
        private void txtValorPagar_Leave(object sender, EventArgs e)
        {
            if (txtValorPagar.Text.Contains(",") == false)
            {
                txtValorPagar.Text += ",00";
            }
            else
            {
                if (txtValorPagar.Text.IndexOf(",") == txtValorPagar.Text.Length - 1)
                {
                    txtValorPagar.Text += "00";
                }
            }
        }

        //Evento KeyPress
        private void txtValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPagar.Text.Contains(","))
                {
                    e.KeyChar = '.';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
