using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoFinanceira.Utilizacao
{
    public class utilidade_FormatarCampos
    {
        public enum Campos
        {
            CEP = 1,
            CPF = 2,
            CNPJ = 3,
            CELULAR = 4,
            FIXO = 5,
            DATA = 6,
        }
        public void Maskara(Campos valor, MetroTextBox txtTexto)
        {
            switch (valor)
            {
                //Mascara CEP
                case Campos.CEP:
                    txtTexto.MaxLength = 10;
                    if (txtTexto.Text.Length == 2)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                //Mascara CPF
                case Campos.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                //Mascara CNPJ
                case Campos.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                //Mascara DATA
                case Campos.DATA:
                    txtTexto.MaxLength = 10;
                    if (txtTexto.Text.Length == 2)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                //Mascara CELULAR
                case Campos.CELULAR:
                    txtTexto.MaxLength = 16;
                    if (txtTexto.Text.Length == 0)
                    {
                        txtTexto.Text = txtTexto.Text + "(";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ")";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 4)
                    {
                        txtTexto.Text = txtTexto.Text + " ";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                //Mascara FIXO
                case Campos.FIXO:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 0)
                    {
                        txtTexto.Text = txtTexto.Text + "(";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ")";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 4)
                    {
                        txtTexto.Text = txtTexto.Text + " ";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 9)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }
    }
}
