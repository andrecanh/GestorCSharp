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
    public class validacao_Cliente
    {
        //Objeto de conexao
        private Utilizacao_Conexao conexao;

        public validacao_Cliente(Utilizacao_Conexao cx)
        {
            this.conexao = cx;
        }

        //Metodo de validação de Salvar
        public void SalvarCliente(modelo_Cliente cliente)
        {
            if (cliente.Cli_nome.Trim().Length == 0)
            {
                MessageBox.Show("O nome do cliente é obrigatório!", "VALIDAÇÃO CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            negocio_cliente.SalvarCliente(cliente);
        }

        //Metodo de validação Editar
        public void EditarCliente(modelo_Cliente modelo_cliente)
        {
            if (modelo_cliente.Cli_id <= 0)
            {
                MessageBox.Show("O código do cliente é obrigatório!", "VALIDAÇÃO CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (modelo_cliente.Cli_nome.Trim().Length == 0)
            {
                MessageBox.Show("O nome do cliente é obrigatório!", "VALIDAÇÃO CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            negocio_cliente.EditarCliente(modelo_cliente);
        }

        //Metodo de validação Excluir
        public void ExcluirCliente(int codigo)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            negocio_cliente.ExcluirCliente(codigo);
        }

        //Metodo de validação Listar
        public DataTable ListarCliente(String valor)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            return negocio_cliente.ListaCliente(valor);
        }

        //Metodo de validação Carregar usuario
        public modelo_Cliente CarregarCliente(int codigo)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            return negocio_cliente.CarregarCliente(codigo);
        }

        // Metodo de negocio para realizar a verificação se ja existe um usuario gravado no banco de dados;
        // Se retornar 0 (não existe) || Se retornar 1 (existe)
        public int VerificaCliente(String valor)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            return negocio_cliente.VerificaCliente(valor);
        }
    }
}
