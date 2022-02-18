using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoFinanceira.Utilizacao
{
    public class Utilizacao_DadosConexao
    {
        //Variavel global de conexão;
        public static String servidor = "localhost";
        public static String banco = "gestaofinanceira";
        public static String usuario = "root";
        public static String senha = "";

        //Metodo StringConexao que realiza a conexão com o banco de dados;
        public static String StringConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
            }
        }
    }
}
