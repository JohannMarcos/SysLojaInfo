using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Classes
{
    internal class itemsCompras : Pai
    {
        public itemsCompras()
        {
            oProduto = new Produtos();
        }

        public Produtos oProduto { get; set; }

        public double precoUnit { get; set; }
        public double descUnit { get; set; }
        public double descPercent { get; set; }

        public int qtd { get; set; }
        public double totalProd { get; set; }


    }
}
