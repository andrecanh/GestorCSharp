using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestãoFinanceira.Utilizacao;
using GestãoFinanceira.Modelo;
using GestãoFinanceira.Negocio;
using System.Windows.Forms;
using System.Data;

namespace GestãoFinanceira.Validacao
{
    public class validacao_ContReceber
    {
        //Objeto de conexao
        private Utilizacao_Conexao conexao;

        public validacao_ContReceber(Utilizacao_Conexao cx)
        {
            this.conexao = cx;
        }

        //Metodo de validação de Salvar
        public void SalvarContReceber(modelo_ContReceber modelo_ContReceber)
        {
            if (modelo_ContReceber.Rec_numDoc.ToString().Length == 0)
            {
                MessageBox.Show("O número do documento é obrigatório!", "VALIDAÇÃO CONTAS A RECEBER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_ContReceber negocio_ContReceber = new negocio_ContReceber(conexao);
            negocio_ContReceber.SalvarContReceber(modelo_ContReceber);
        }

        //Metodo de validação Editar
        public void EditarContReceber(modelo_ContReceber modelo_ContReceber)
        {
            if (modelo_ContReceber.Rec_id <= 0)
            {
                MessageBox.Show("O código é obrigatório!", "VALIDAÇÃO CONTAS A RECEBER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (modelo_ContReceber.Rec_numDoc.ToString().Length == 0)
            {
                MessageBox.Show("O número do documento é obrigatório!", "VALIDAÇÃO CONTAS A RECEBER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_ContReceber negocio_ContReceber = new negocio_ContReceber(conexao);
            negocio_ContReceber.EditarContReceber(modelo_ContReceber);
        }

        //Metodo de validação Excluir
        public void ExcluirContReceber(int codigo)
        {
            negocio_ContReceber negocio_ContReceber = new negocio_ContReceber(conexao);
            negocio_ContReceber.ExcluirContReceber(codigo);
        }

        //Metodo de validação Listar
        public DataTable ListarContReceber(String valor)
        {
            negocio_ContReceber negocio_ContReceber = new negocio_ContReceber(conexao);
            return negocio_ContReceber.ListaContReceber(valor);
        }

        //Metodo de validação Carregar
        public modelo_ContReceber CarregarContReceber(int codigo)
        {
            negocio_ContReceber negocio_ContReceber = new negocio_ContReceber(conexao);
            return negocio_ContReceber.CarregarContReceber(codigo);
        }

        // Metodo de negocio para realizar a verificação se ja existe;
        // Se retornar 0 (não existe) || Se retornar 1 (existe)
        public int VerificaContReceber(String valor)
        {
            negocio_ContReceber negocio_ContReceber = new negocio_ContReceber(conexao);
            return negocio_ContReceber.VerificaContReceber(valor);
        }
    }
}
