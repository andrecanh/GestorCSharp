using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoFinanceira.Utilizacao
{
    public class utilidade_ValidaCep
    {
        static public String cep = "";
        static public String cidade = "";
        static public String estado = "";
        static public String endereco = "";
        static public String bairro = "";
        static public String complemento = "";

        public Boolean verificaCEP(String CEP)
        {
            bool flag = false;
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
                ds.ReadXml(xml);
                endereco = ds.Tables[0].Rows[0]["logradouro"].ToString();
                bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                estado = ds.Tables[0].Rows[0]["uf"].ToString();
                complemento = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString();
                cep = CEP;
                flag = true;
            }
            catch (Exception)
            {
                endereco = "";
                bairro = "";
                cidade = "";
                estado = "";
                cep = "";
                complemento = "";
            }
            return flag;
        }
    }
}
