using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Classes
{
    internal class Produtos : Pai
    {
        public Produtos()
        {
            aMedida = new Medidas();
        }

        public string produto { get; set; }
        public double custo { get; set; }
        public double custoMedio { get; set; }
        public double precoVenda { get; set; }
        public int estoque { get; set; }
        public Medidas aMedida { get; set; }
    }
}
