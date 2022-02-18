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
    public class validacao_Usuario
    {
        //Objeto de conexao com o banco de dados
        private Utilizacao_Conexao conexao;

        public validacao_Usuario(Utilizacao_Conexao cx)
        {
            this.conexao = cx;
        }

        //Metodo de validação de Salvar usuário
        public void SalvarUsuario(modelo_Usuario mod_usuario)
        {
            if (mod_usuario.User_usuario.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório!", "Validação usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mod_usuario.User_password.Trim().Length == 0)
            {
                MessageBox.Show("O password do usuário é obrigatório!", "Validação usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
            negocio_usuario.SalvarUsuario(mod_usuario);
        }

        //Metodo de validação Editar usuario
        public void EditarUsuario(modelo_Usuario mod_usuario)
        {
            if (mod_usuario.User_id <= 0)
            {
                MessageBox.Show("O código do usuário é obrigatório!", "Validação usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mod_usuario.User_usuario.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório!", "Validação usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mod_usuario.User_password.Trim().Length == 0)
            {
                MessageBox.Show("O password do usuário é obrigatório!", "Validação usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
            negocio_usuario.EditarUsuario(mod_usuario);
        }

        //Metodo de validação Excluir usuario
        public void ExcluirUsuario(int codigo)
        {
            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
            negocio_usuario.ExcluirUsuario(codigo);
        }

        //Metodo de validação Listar usuario
        public DataTable ListarUsuario(String valor)
        {
            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
            return negocio_usuario.ListaUsuario(valor);
        }

        //Metodo de validação Carregar usuario
        public modelo_Usuario CarregarUsuario(int codigo)
        {
            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
            return negocio_usuario.CarregarUsuario(codigo);
        }

        // Metodo de negocio para realizar a verificação se ja existe um usuario gravado no banco de dados;
        // Se retornar 0 (não existe) || Se retornar 1 (existe)
        public int VerificaUsuario(String valor)
        {
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            return negocio_Usuario.VerificaUsuario(valor);
        }
    }
}
