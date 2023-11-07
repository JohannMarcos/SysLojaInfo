using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class Clientes: SysLojaInfo.Pessoas
    {
        public Clientes() 
        {
            aCidade = new Cidades();
        }

        public double limCred {  get; set; }


    }
}
