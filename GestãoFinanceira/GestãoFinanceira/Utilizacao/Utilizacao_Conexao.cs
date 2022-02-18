using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoFinanceira.Utilizacao
{
    public class Utilizacao_Conexao
    {
        //Variavel privado da classe de conexao;
        private String _stringConexao;
        private MySqlConnection _conexao;

        //Metodo construtor da classe conexao
        public Utilizacao_Conexao(String dadosConexao)
        {
            this._conexao = new MySqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        //Propriedade da classe StringConexao
        public String StringConexao
        {
            get => this._stringConexao;
            set => this._stringConexao = value;
        }

        //Propriedade da classe Conexao
        public MySqlConnection Conexao
        {
            get => this._conexao;
            set => this._conexao = value;
        }

        //Metodo Abrir a conexao com o banco de dados;
        public void AbrirConexao()
        {
            this._conexao.Open();
        }

        //Metodo fechar a conexao com o banco de dados;
        public void FecharConexao()
        {
            this._conexao.Close();
        }
    }
}
