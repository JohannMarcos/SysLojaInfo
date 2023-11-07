﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class ctrlFuncionarios: SysLojaInfo.ctrl
    {
        private daoFuncionarios aDao;

        public ctrlFuncionarios()
        {
            aDao = new daoFuncionarios();
        }

        public override void salvar(object obj)
        {
            aDao.salvar(obj);
        }

        public override void editar(object obj)
        {
            aDao.editar(obj);
        }

        public override void deletar(object obj)
        {
            aDao.deletar(obj);
        }

        public List<Funcionarios> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }

        public Funcionarios buscar(string str)
        {
            return aDao.buscar(str);
        }

        public Funcionarios buscar(int cod)
        {
            return aDao.buscar(cod);
        }
    }
}