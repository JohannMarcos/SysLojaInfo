﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class Servicos: SysLojaInfo.Pai
    {
        public Servicos() { }

        public string servico {  get; set; }
        public float valor { get; set; }
         
    }
}
