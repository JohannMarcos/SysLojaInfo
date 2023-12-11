using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Classes
{
    internal class Pessoas : Pai
    {
        public Pessoas()
        {
            aCidade = new Cidades();
        }

        public string nome { get; set; }
        public string cpfCnpj { get; set; }
        public string rg { get; set; }
        public string logr { get; set; }
        public int numero { get; set; }
        public string natPess { get; set; }
        public string bairro { get; set; }
        public Cidades aCidade { get; set; }
        public string telRes { get; set; }
        public string telCel { get; set; }
        public string email { get; set; }

    }
}
