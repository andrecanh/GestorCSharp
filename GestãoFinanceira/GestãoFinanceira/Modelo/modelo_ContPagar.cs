using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoFinanceira.Modelo
{
    public class modelo_ContPagar
    {
        //variaveis
        private int pag_id;
        private int pag_numDoc;
        private DateTime pag_dataDoc;
        private string pag_descDoc;
        private string pag_formaPag;
        private decimal pag_valorPrincipal;
        private decimal pag_valorJuros;
        private decimal pag_valorMulta;
        private decimal pag_valorTotal;

        //Metodo construtor
        public modelo_ContPagar()
        {
            this.Pag_id = 0;
            this.Pag_numDoc = 0;
            this.Pag_dataDoc = DateTime.Now;
            this.Pag_descDoc = "";
            this.Pag_formaPag = "";
            this.pag_valorPrincipal = 0;
            this.pag_valorJuros = 0;
            this.pag_valorMulta = 0;
            this.pag_valorTotal = 0;
        }

        //propriedades
        public int Pag_id { get => pag_id; set => pag_id = value; }
        public int Pag_numDoc { get => pag_numDoc; set => pag_numDoc = value; }
        public DateTime Pag_dataDoc { get => pag_dataDoc; set => pag_dataDoc = value; }
        public string Pag_descDoc { get => pag_descDoc; set => pag_descDoc = value; }
        public string Pag_formaPag { get => pag_formaPag; set => pag_formaPag = value; }
        public decimal Pag_valorPrincipal { get => pag_valorPrincipal; set => pag_valorPrincipal = value; }
        public decimal Pag_valorJuros { get => pag_valorJuros; set => pag_valorJuros = value; }
        public decimal Pag_valorMulta { get => pag_valorMulta; set => pag_valorMulta = value; }
        public decimal Pag_valorTotal { get => pag_valorTotal; set => pag_valorTotal = value; }
    }
}
