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
    public class validacao_Empresa
    {
        //Objeto de conexao
        private Utilizacao_Conexao conexao;

        public validacao_Empresa(Utilizacao_Conexao cx)
        {
            this.conexao = cx;
        }

        //Metodo de validação de Salvar
        public void SalvarEmpresa(modelo_Empresa modelo_empresa)
        {
            if (modelo_empresa.Emp_razao.Trim().Length == 0)
            {
                MessageBox.Show("O nome da empresa é obrigatório!", "VALIDAÇÃO EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_Empresa negocio_empresa = new negocio_Empresa(conexao);
            negocio_empresa.SalvarEmpresa(modelo_empresa);
        }

        //Metodo de validação Editar
        public void EditarEmpresa(modelo_Empresa modelo_empresa)
        {
            if (modelo_empresa.Emp_id <= 0)
            {
                MessageBox.Show("O código da empresa é obrigatório!", "VALIDAÇÃO EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (modelo_empresa.Emp_razao.Trim().Length == 0)
            {
                MessageBox.Show("O nome da empresa é obrigatório!", "VALIDAÇÃO EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_Empresa negocio_empresa = new negocio_Empresa(conexao);
            negocio_empresa.EditarEmpresa(modelo_empresa);
        }

        //Metodo de validação Excluir
        public void ExcluirEmpresa(int codigo)
        {
            negocio_Empresa negocio_empresa = new negocio_Empresa(conexao);
            negocio_empresa.ExcluirEmpresa(codigo);
        }

        //Metodo de validação Listar
        public DataTable ListarEmpresa(String valor)
        {
            negocio_Empresa negocio_empresa = new negocio_Empresa(conexao);
            return negocio_empresa.ListaEmpresa(valor);
        }

        //Metodo de validação Carregar usuario
        public modelo_Empresa CarregarEmpresa(int codigo)
        {
            negocio_Empresa negocio_empresa = new negocio_Empresa(conexao);
            return negocio_empresa.CarregarEmpresa(codigo);
        }

        // Metodo de negocio para realizar a verificação se ja existe um usuario gravado no banco de dados;
        // Se retornar 0 (não existe) || Se retornar 1 (existe)
        public int VerificaEmpresa(String valor)
        {
            negocio_Empresa negocio_empresa = new negocio_Empresa(conexao);
            return negocio_empresa.VerificaEmpresa(valor);
        }
    }
}
