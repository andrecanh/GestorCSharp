using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GestãoFinanceira.Modelo;
using GestãoFinanceira.Utilizacao;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GestãoFinanceira.Negocio
{
    public class negocio_ContPagar
    {
        //Variaveis da clase
        private Utilizacao_Conexao conexao;
        MySqlCommand comando = null;

        //Metodo Construtor da conexao
        public negocio_ContPagar(Utilizacao_Conexao cx)
        {
            this.conexao = cx;
        }

        //Metodo salvar;
        public void SalvarContPagar(modelo_ContPagar modelo_ContPagar)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO contapagar (pag_id, pag_numDoc, pag_dataDoc, pag_descDoc, pag_formaPag, pag_valorPrincipal," +
                    "pag_valorJuros, pag_valorMulta, pag_valorTotal) VALUES (@pag_id, @pag_numDoc, @pag_dataDoc, @pag_descDoc, @pag_formaPag, @pag_valorPrincipal," +
                    "@pag_valorJuros, @pag_valorMulta, @pag_valorTotal); SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("@pag_id", modelo_ContPagar.Pag_id);
                cmd.Parameters.AddWithValue("@pag_numDoc", modelo_ContPagar.Pag_numDoc);
                cmd.Parameters.AddWithValue("@pag_dataDoc", modelo_ContPagar.Pag_dataDoc);
                cmd.Parameters.AddWithValue("@pag_descDoc", modelo_ContPagar.Pag_descDoc);
                cmd.Parameters.AddWithValue("@pag_formaPag", modelo_ContPagar.Pag_formaPag);
                cmd.Parameters.AddWithValue("@pag_valorPrincipal", modelo_ContPagar.Pag_valorPrincipal);
                cmd.Parameters.AddWithValue("@pag_valorJuros", modelo_ContPagar.Pag_valorJuros);
                cmd.Parameters.AddWithValue("@pag_valorMulta", modelo_ContPagar.Pag_valorMulta);
                cmd.Parameters.AddWithValue("@pag_valorTotal", modelo_ContPagar.Pag_valorTotal);
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
        public void EditarContPagar(modelo_ContPagar modelo_ContPagar)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE contapagar SET pag_numDoc=@pag_numDoc, pag_dataDoc=@pag_dataDoc, pag_descDoc=@pag_descDoc, pag_formaPag=@pag_formaPag," +
                    "pag_valorPrincipal=@pag_valorPrincipal, pag_valorJuros=@pag_valorJuros, pag_valorMulta=@pag_valorMulta, pag_valorTotal=@pag_valorTotal WHERE pag_id=@pag_id;";
                cmd.Parameters.AddWithValue("@pag_numDoc", modelo_ContPagar.Pag_numDoc);
                cmd.Parameters.AddWithValue("@pag_dataDoc", modelo_ContPagar.Pag_dataDoc);
                cmd.Parameters.AddWithValue("@pag_descDoc", modelo_ContPagar.Pag_descDoc);
                cmd.Parameters.AddWithValue("@pag_formaPag", modelo_ContPagar.Pag_formaPag);
                cmd.Parameters.AddWithValue("@pag_valorPrincipal", modelo_ContPagar.Pag_valorPrincipal);
                cmd.Parameters.AddWithValue("@pag_valorJuros", modelo_ContPagar.Pag_valorJuros);
                cmd.Parameters.AddWithValue("@pag_valorMulta", modelo_ContPagar.Pag_valorMulta);
                cmd.Parameters.AddWithValue("@pag_valorTotal", modelo_ContPagar.Pag_valorTotal);
                cmd.Parameters.AddWithValue("@pag_id", modelo_ContPagar.Pag_id);
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
        public void ExcluirContPagar(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM contapagar WHERE pag_id = @pag_id";
                cmd.Parameters.AddWithValue("@pag_id", codigo);
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
        public DataTable ListaContPagar(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM contapagar WHERE pag_numDoc like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Metodo para preencher DataGridView
        public modelo_ContPagar CarregarContPagar(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_ContPagar modelo_ContPagar = new modelo_ContPagar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM contapagar WHERE pag_id = @pag_id;";
                cmd.Parameters.AddWithValue("@pag_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo_ContPagar.Pag_id = Convert.ToInt32(registro["pag_id"]);
                    modelo_ContPagar.Pag_numDoc = Convert.ToInt32(registro["pag_numDoc"]);
                    modelo_ContPagar.Pag_dataDoc = Convert.ToDateTime(registro["pag_dataDoc"]);
                    modelo_ContPagar.Pag_descDoc = Convert.ToString(registro["pag_descDoc"]);
                    modelo_ContPagar.Pag_formaPag = Convert.ToString(registro["pag_formaPag"]);
                    modelo_ContPagar.Pag_valorPrincipal = Convert.ToDecimal(registro["pag_valorPrincipal"]);
                    modelo_ContPagar.Pag_valorJuros = Convert.ToDecimal(registro["pag_valorJuros"]);
                    modelo_ContPagar.Pag_valorMulta = Convert.ToDecimal(registro["pag_valorMulta"]);
                    modelo_ContPagar.Pag_valorTotal = Convert.ToDecimal(registro["pag_valorTotal"]);
                }
                return modelo_ContPagar;
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
        public int VerificaContPagar(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM contapagar WHERE pag_numDoc = @pag_numDoc;";
                cmd.Parameters.AddWithValue("@pag_numDoc", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["pag_id"]);
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
