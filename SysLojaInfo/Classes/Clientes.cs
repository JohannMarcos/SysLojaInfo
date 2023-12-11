using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Classes
{
    internal class Clientes : Pessoas
    {
        public Clientes()
        {
            aCidade = new Cidades();
            aCond = new CondicoesPag();
        }

        public double limCred { get; set; }

        public CondicoesPag aCond { get; set; }


    }
}
