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
    public class validacao_ContPagar
    {
        //Objeto de conexao
        private Utilizacao_Conexao conexao;

        public validacao_ContPagar(Utilizacao_Conexao cx)
        {
            this.conexao = cx;
        }

        //Metodo de validação de GravarS
        public void SalvarContPagar(modelo_ContPagar modelo_contPagar)
        {
            if (modelo_contPagar.Pag_numDoc.ToString().Length == 0)
            {
                MessageBox.Show("O número do documento é obrigatório!", "VALIDAÇÃO CONTAS A PAGAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_ContPagar negocio_contPagar = new negocio_ContPagar(conexao);
            negocio_contPagar.SalvarContPagar(modelo_contPagar);
        }

        //Metodo de validação Editar
        public void EditarContPagar(modelo_ContPagar modelo_contPagar)
        {
            if (modelo_contPagar.Pag_id <= 0)
            {
                MessageBox.Show("O código é obrigatório!", "VALIDAÇÃO CONTAS A PAGAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (modelo_contPagar.Pag_numDoc.ToString().Length == 0)
            {
                MessageBox.Show("O número do documento é obrigatório!", "VALIDAÇÃO CONTAS A PAGAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_ContPagar negocio_contPagar = new negocio_ContPagar(conexao);
            negocio_contPagar.EditarContPagar(modelo_contPagar);
        }

        //Metodo de validação Excluir
        public void ExcluirContPagar(int codigo)
        {
            negocio_ContPagar negocio_contPagar = new negocio_ContPagar(conexao);
            negocio_contPagar.ExcluirContPagar(codigo);
        }

        //Metodo de validação Listar
        public DataTable ListarContPagar(String valor)
        {
            negocio_ContPagar negocio_contPagar = new negocio_ContPagar(conexao);
            return negocio_contPagar.ListaContPagar(valor);
        }

        //Metodo de validação Carregar
        public modelo_ContPagar CarregarContPagar(int codigo)
        {
            negocio_ContPagar negocio_contPagar = new negocio_ContPagar(conexao);
            return negocio_contPagar.CarregarContPagar(codigo);
        }

        // Metodo de negocio para realizar a verificação se ja existe;
        // Se retornar 0 (não existe) || Se retornar 1 (existe)
        public int VerificaContPagar(String valor)
        {
            negocio_ContPagar negocio_contPagar = new negocio_ContPagar(conexao);
            return negocio_contPagar.VerificaContPagar(valor);
        }
    }
}
