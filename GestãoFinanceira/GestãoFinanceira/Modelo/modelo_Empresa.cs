using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoFinanceira.Modelo
{
    public class modelo_Empresa
    {
        //Variaveis
        private int emp_id;
        private string emp_cnpj;
        private string emp_razao;
        private DateTime emp_dataCadastro;
        private string emp_cep;
        private string emp_endereco;
        private int emp_numero;
        private string emp_complemento;
        private string emp_bairro;
        private string emp_cidade;
        private string emp_estado;
        private string emp_email;
        private string emp_fonefixo;
        private string emp_fonecelular;
        private string emp_observacao;

        //Metodo construtor
        public modelo_Empresa()
        {
            this.Emp_id = 0;
            this.Emp_cnpj = "";
            this.Emp_razao = "";
            this.Emp_dataCadastro = DateTime.Now;
            this.Emp_cep = "";
            this.Emp_endereco = "";
            this.emp_numero = 0;
            this.Emp_complemento = "";
            this.Emp_bairro = "";
            this.Emp_cidade = "";
            this.Emp_estado = "";
            this.Emp_email = "";
            this.Emp_email = "";
            this.Emp_fonefixo = "";
            this.Emp_fonecelular = "";
            this.Emp_observacao = "";
        }

        //Propriedades
        public int Emp_id { get => emp_id; set => emp_id = value; }
        public string Emp_cnpj { get => emp_cnpj; set => emp_cnpj = value; }
        public string Emp_razao { get => emp_razao; set => emp_razao = value; }
        public DateTime Emp_dataCadastro { get => emp_dataCadastro; set => emp_dataCadastro = value; }
        public string Emp_cep { get => emp_cep; set => emp_cep = value; }
        public string Emp_endereco { get => emp_endereco; set => emp_endereco = value; }
        public int Emp_numero { get => emp_numero; set => emp_numero = value; }
        public string Emp_complemento { get => emp_complemento; set => emp_complemento = value; }
        public string Emp_bairro { get => emp_bairro; set => emp_bairro = value; }
        public string Emp_cidade { get => emp_cidade; set => emp_cidade = value; }
        public string Emp_estado { get => emp_estado; set => emp_estado = value; }
        public string Emp_email { get => emp_email; set => emp_email = value; }
        public string Emp_fonefixo { get => emp_fonefixo; set => emp_fonefixo = value; }
        public string Emp_fonecelular { get => emp_fonecelular; set => emp_fonecelular = value; }
        public string Emp_observacao { get => emp_observacao; set => emp_observacao = value; }
    }
}
