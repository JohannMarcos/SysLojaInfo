﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class Funcionarios: SysLojaInfo.Pessoas
    {
        public Funcionarios() 
        {
            aCidade = new Cidades();
            
            oCargo = new Cargos();
        }

        public Cargos oCargo { get; set; }
        public string cnh { get; set; }


    }
}
