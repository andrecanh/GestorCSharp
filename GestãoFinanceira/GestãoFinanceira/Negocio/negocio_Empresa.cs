using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestãoFinanceira.Modelo;
using GestãoFinanceira.Utilizacao;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestãoFinanceira.Negocio
{
    public class negocio_Empresa
    {
        //Variaveis da clase
        private Utilizacao_Conexao conexao;
        MySqlCommand comando = null;

        //Metodo Construtor da conexao
        public negocio_Empresa(Utilizacao_Conexao cx)
        {
            this.conexao = cx;
        }

        //Metodo salvar;
        public void SalvarEmpresa(modelo_Empresa modelo_empresa)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO empresa (emp_id, emp_cnpj, emp_razao, emp_dataCadastro, emp_cep, emp_endereco, emp_numero, emp_complemento," +
                    "emp_bairro, emp_cidade, emp_estado, emp_email, emp_fonefixo, emp_fonecelular, emp_observacao) VALUES (@emp_id, @emp_cnpj, @emp_razao, @emp_dataCadastro," +
                    "@emp_cep, @emp_endereco, @emp_numero, @emp_complemento, @emp_bairro, @emp_cidade, @emp_estado, @emp_email, @emp_fonefixo, @emp_fonecelular, @emp_observacao); SELECT @@IDENTITY";

                cmd.Parameters.AddWithValue("@emp_id", modelo_empresa.Emp_id);
                cmd.Parameters.AddWithValue("@emp_cnpj", modelo_empresa.Emp_cnpj);
                cmd.Parameters.AddWithValue("@emp_razao", modelo_empresa.Emp_razao);
                cmd.Parameters.AddWithValue("@emp_dataCadastro", modelo_empresa.Emp_dataCadastro);
                cmd.Parameters.AddWithValue("@emp_cep", modelo_empresa.Emp_cep);
                cmd.Parameters.AddWithValue("@emp_endereco", modelo_empresa.Emp_endereco);
                cmd.Parameters.AddWithValue("@emp_numero", modelo_empresa.Emp_numero);
                cmd.Parameters.AddWithValue("@emp_complemento", modelo_empresa.Emp_complemento);
                cmd.Parameters.AddWithValue("@emp_bairro", modelo_empresa.Emp_bairro);
                cmd.Parameters.AddWithValue("@emp_cidade", modelo_empresa.Emp_cidade);
                cmd.Parameters.AddWithValue("@emp_estado", modelo_empresa.Emp_estado);
                cmd.Parameters.AddWithValue("@emp_email", modelo_empresa.Emp_email);
                cmd.Parameters.AddWithValue("@emp_fonefixo", modelo_empresa.Emp_fonefixo);
                cmd.Parameters.AddWithValue("@emp_fonecelular", modelo_empresa.Emp_fonecelular);
                cmd.Parameters.AddWithValue("@emp_observacao", modelo_empresa.Emp_observacao);
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
        public void EditarEmpresa(modelo_Empresa modelo_empresa)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE empresa SET emp_cnpj = @emp_cnpj, emp_razao = @emp_razao, emp_dataCadastro = @emp_dataCadastro, emp_cep = @emp_cep, emp_endereco = @emp_endereco," +
                    "emp_numero = @emp_numero, emp_complemento = @emp_complemento, emp_bairro = @emp_bairro, emp_cidade = @emp_cidade, emp_estado = @emp_estado, emp_email = @emp_email," +
                    "emp_fonefixo = @emp_fonefixo, emp_fonecelular = @emp_fonecelular, emp_observacao = @emp_observacao WHERE emp_id = @emp_id";

                cmd.Parameters.AddWithValue("@emp_cnpj", modelo_empresa.Emp_cnpj);
                cmd.Parameters.AddWithValue("@emp_razao", modelo_empresa.Emp_razao);
                cmd.Parameters.AddWithValue("@emp_dataCadastro", modelo_empresa.Emp_dataCadastro);
                cmd.Parameters.AddWithValue("@emp_cep", modelo_empresa.Emp_cep);
                cmd.Parameters.AddWithValue("@emp_endereco", modelo_empresa.Emp_endereco);
                cmd.Parameters.AddWithValue("@emp_numero", modelo_empresa.Emp_numero);
                cmd.Parameters.AddWithValue("@emp_complemento", modelo_empresa.Emp_complemento);
                cmd.Parameters.AddWithValue("@emp_bairro", modelo_empresa.Emp_bairro);
                cmd.Parameters.AddWithValue("@emp_cidade", modelo_empresa.Emp_cidade);
                cmd.Parameters.AddWithValue("@emp_estado", modelo_empresa.Emp_estado);
                cmd.Parameters.AddWithValue("@emp_email", modelo_empresa.Emp_email);
                cmd.Parameters.AddWithValue("@emp_fonefixo", modelo_empresa.Emp_fonefixo);
                cmd.Parameters.AddWithValue("@emp_fonecelular", modelo_empresa.Emp_fonecelular);
                cmd.Parameters.AddWithValue("@emp_observacao", modelo_empresa.Emp_observacao);
                cmd.Parameters.AddWithValue("@emp_id", modelo_empresa.Emp_id);
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
        public void ExcluirEmpresa(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM empresa WHERE emp_id = @emp_id";
                cmd.Parameters.AddWithValue("@emp_id", codigo);
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
        public DataTable ListaEmpresa(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM empresa WHERE emp_razao like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Metodo para preencher DataGridView
        public modelo_Empresa CarregarEmpresa(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Empresa modelo_empresa = new modelo_Empresa();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM empresa WHERE emp_id = @emp_id;";
                cmd.Parameters.AddWithValue("@emp_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo_empresa.Emp_id = Convert.ToInt32(registro["emp_id"]);
                    modelo_empresa.Emp_cnpj = Convert.ToString(registro["emp_cnpj"]);
                    modelo_empresa.Emp_razao = Convert.ToString(registro["emp_razao"]);
                    modelo_empresa.Emp_dataCadastro = Convert.ToDateTime(registro["emp_dataCadastro"]);
                    modelo_empresa.Emp_cep = Convert.ToString(registro["emp_cep"]);
                    modelo_empresa.Emp_endereco = Convert.ToString(registro["emp_endereco"]);
                    modelo_empresa.Emp_numero = Convert.ToInt32(registro["emp_numero"]);
                    modelo_empresa.Emp_complemento = Convert.ToString(registro["emp_complemento"]);
                    modelo_empresa.Emp_bairro = Convert.ToString(registro["emp_bairro"]);
                    modelo_empresa.Emp_cidade = Convert.ToString(registro["emp_cidade"]);
                    modelo_empresa.Emp_estado = Convert.ToString(registro["emp_estado"]);
                    modelo_empresa.Emp_email = Convert.ToString(registro["emp_email"]);
                    modelo_empresa.Emp_fonefixo = Convert.ToString(registro["emp_fonefixo"]);
                    modelo_empresa.Emp_fonecelular = Convert.ToString(registro["emp_fonecelular"]);
                    modelo_empresa.Emp_observacao = Convert.ToString(registro["emp_observacao"]);
                }
                return modelo_empresa;
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
        public int VerificaEmpresa(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM empresa WHERE emp_cnpj = @emp_cnpj;";
                cmd.Parameters.AddWithValue("@emp_cnpj", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["emp_id"]);
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
