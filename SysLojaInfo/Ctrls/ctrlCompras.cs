using SysLojaInfo.Classes;
using SysLojaInfo.Daos;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Ctrls
{
    internal class ctrlCompras : ctrl
    {
        private daoCompras aDao;

        public ctrlCompras()
        {
            aDao = new daoCompras();
        }

        public override void salvar(object obj)
        {
            aDao.salvar(obj);
        }

        public bool ValidaChaveNota(object obj)
        {
            return aDao.ValidaChaveNota(obj);
        }

        public List<Compra> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }
    }
}
