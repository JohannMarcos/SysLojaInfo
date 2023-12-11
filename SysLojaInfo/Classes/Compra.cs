using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Classes
{
    internal class Compra : Pai
    {
        public Compra() 
        {
            itemsNota = new List<itemsCompras>();

            duplicatasNota = new List<duplicata>(); 
        }

        public List<duplicata> duplicatasNota;

        public List<itemsCompras> itemsNota;

        public int nNota { get; set; }

        public string SerieNota { get; set; }

        public string ModeloNota { get; set; }

        public DateTime dtChegada { get; set; }

        public DateTime dtEmissao { get; set; }

        public Fornecedores oFornecedor { get; set; }

        public double valorBrutoItens {  get; set; }
        public double DescTotalItens { get; set; }
        public double valorFrete { get; set; }
        public double valorSeguro {  get; set; }
        public double ValorOutros { get; set; }
        public double totalNota { get; set; }



    }
}
