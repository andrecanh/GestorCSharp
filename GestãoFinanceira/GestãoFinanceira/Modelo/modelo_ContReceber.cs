using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoFinanceira.Modelo
{
    public class modelo_ContReceber
    {
        //Variaveis
        private int rec_id;
        private int rec_numDoc;
        private DateTime rec_dataDoc;
        private string rec_descricaoDoc;
        private string rec_formaPagto;
        private decimal rec_valorPrincipal;
        private decimal rec_valorJuros;
        private decimal rec_valorMulta;
        private decimal rec_valorTotal;

        //Metodo construtor
        public modelo_ContReceber()
        {
            this.Rec_id = 0;
            this.Rec_numDoc = 0;
            this.Rec_dataDoc = DateTime.Now;
            this.Rec_descricaoDoc = "";
            this.Rec_formaPagto = "";
            this.Rec_valorPrincipal = 1.11m;
            this.Rec_valorJuros = 1.11m;
            this.Rec_valorMulta = 1.11m;
            this.Rec_valorTotal = 1.11m;
        }

        //Propriedades
        public int Rec_id { get => rec_id; set => rec_id = value; }
        public int Rec_numDoc { get => rec_numDoc; set => rec_numDoc = value; }
        public DateTime Rec_dataDoc { get => rec_dataDoc; set => rec_dataDoc = value; }
        public string Rec_descricaoDoc { get => rec_descricaoDoc; set => rec_descricaoDoc = value; }
        public string Rec_formaPagto { get => rec_formaPagto; set => rec_formaPagto = value; }
        public decimal Rec_valorPrincipal { get => rec_valorPrincipal; set => rec_valorPrincipal = value; }
        public decimal Rec_valorJuros { get => rec_valorJuros; set => rec_valorJuros = value; }
        public decimal Rec_valorMulta { get => rec_valorMulta; set => rec_valorMulta = value; }
        public decimal Rec_valorTotal { get => rec_valorTotal; set => rec_valorTotal = value; }
    }
}
