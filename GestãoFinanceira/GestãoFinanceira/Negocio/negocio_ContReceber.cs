using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestãoFinanceira.Modelo;
using GestãoFinanceira.Utilizacao;
using MySql.Data.MySqlClient;

namespace GestãoFinanceira.Negocio
{
    public class negocio_ContReceber
    {
        //Variaveis da clase
        private Utilizacao_Conexao conexao;
        MySqlCommand comando = null;

        //Metodo Construtor da conexao
        public negocio_ContReceber(Utilizacao_Conexao cx)
        {
            this.conexao = cx;
        }

        //Metodo salvar;
        public void SalvarContReceber(modelo_ContReceber modelo_ContReceber)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO contareceber (rec_id, rec_numDoc, rec_dataDoc, rec_descricaoDoc, rec_formaPagto, rec_valorPrincipal," +
                    "rec_valorJuros, rec_valorMulta, rec_valorTotal) VALUES (@rec_id, @rec_numDoc, @rec_dataDoc, @rec_descricaoDoc, @rec_formaPagto, @rec_valorPrincipal," +
                    "@rec_valorJuros, @rec_valorMulta, @rec_valorTotal); SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("@rec_id", modelo_ContReceber.Rec_id);
                cmd.Parameters.AddWithValue("@rec_numDoc", modelo_ContReceber.Rec_numDoc);
                cmd.Parameters.AddWithValue("@rec_dataDoc", modelo_ContReceber.Rec_dataDoc);
                cmd.Parameters.AddWithValue("@rec_descricaoDoc", modelo_ContReceber.Rec_descricaoDoc);
                cmd.Parameters.AddWithValue("@rec_formaPagto", modelo_ContReceber.Rec_formaPagto);
                cmd.Parameters.AddWithValue("@rec_valorPrincipal", modelo_ContReceber.Rec_valorPrincipal);
                cmd.Parameters.AddWithValue("@rec_valorJuros", modelo_ContReceber.Rec_valorJuros);
                cmd.Parameters.AddWithValue("@rec_valorMulta", modelo_ContReceber.Rec_valorMulta);
                cmd.Parameters.AddWithValue("@rec_valorTotal", modelo_ContReceber.Rec_valorTotal);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Gravar" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        //Metodo para editar
        public void EditarContReceber(modelo_ContReceber modelo_ContReceber)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE contareceber SET rec_id = @rec_id, rec_numDoc = @rec_numDoc, rec_dataDoc = @rec_dataDoc, rec_descricaoDoc = @rec_descricaoDoc," +
                    "rec_formaPagto = @rec_formaPagto, rec_valorPrincipal = @rec_valorPrincipal, rec_valorJuros = @rec_valorJuros, rec_valorMulta = @rec_valorMulta, rec_valorTotal = @rec_valorTotal";
                cmd.Parameters.AddWithValue("@rec_id", modelo_ContReceber.Rec_id);
                cmd.Parameters.AddWithValue("@rec_numDoc", modelo_ContReceber.Rec_numDoc);
                cmd.Parameters.AddWithValue("@rec_dataDoc", modelo_ContReceber.Rec_dataDoc);
                cmd.Parameters.AddWithValue("@rec_descricaoDoc", modelo_ContReceber.Rec_descricaoDoc);
                cmd.Parameters.AddWithValue("@rec_formaPagto", modelo_ContReceber.Rec_formaPagto);
                cmd.Parameters.AddWithValue("@rec_valorPrincipal", modelo_ContReceber.Rec_valorPrincipal);
                cmd.Parameters.AddWithValue("@rec_valorJuros", modelo_ContReceber.Rec_valorJuros);
                cmd.Parameters.AddWithValue("@rec_valorMulta", modelo_ContReceber.Rec_valorMulta);
                cmd.Parameters.AddWithValue("@rec_valorTotal", modelo_ContReceber.Rec_valorTotal);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Editar" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        //Metodo para Excluir
        public void ExcluirContReceber(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM contareceber WHERE rec_id = @rec_id";
                cmd.Parameters.AddWithValue("@rec_id", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Excluir" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        //Metodo para Filtrar
        public DataTable ListaContReceber(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM contareceber WHERE rec_numDoc like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Metodo para preencher DataGridView
        public modelo_ContReceber CarregarContReceber(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_ContReceber modelo_ContReceber = new modelo_ContReceber();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM contareceber WHERE rec_id = @rec_id;";
                cmd.Parameters.AddWithValue("@rec_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo_ContReceber.Rec_id = Convert.ToInt32(registro["rec_id"]);
                    modelo_ContReceber.Rec_numDoc = Convert.ToInt32(registro["rec_numDoc"]);
                    modelo_ContReceber.Rec_dataDoc = Convert.ToDateTime(registro["rec_dataDoc"]);
                    modelo_ContReceber.Rec_descricaoDoc = Convert.ToString(registro["rec_descricaoDoc"]);
                    modelo_ContReceber.Rec_formaPagto = Convert.ToString(registro["rec_formaPagto"]);
                    modelo_ContReceber.Rec_valorPrincipal = Convert.ToDecimal(registro["rec_valorPrincipal"]);
                    modelo_ContReceber.Rec_valorJuros = Convert.ToDecimal(registro["rec_valorJuros"]);
                    modelo_ContReceber.Rec_valorMulta = Convert.ToDecimal(registro["rec_valorMulta"]);
                    modelo_ContReceber.Rec_valorTotal = Convert.ToDecimal(registro["rec_valorTotal"]);
                }
                return modelo_ContReceber;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        // Metodo de negocio para realizar a verificação se ja existe;
        // Se retornar 0 (não existe) || Se retornar 1 (existe)
        public int VerificaContReceber(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM contareceber WHERE rec_numDoc = @rec_numDoc;";
                cmd.Parameters.AddWithValue("@rec_numDoc", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["rec_id"]);
                }
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
    }
}
