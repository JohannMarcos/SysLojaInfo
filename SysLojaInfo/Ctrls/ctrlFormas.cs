using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysLojaInfo.Classes;
using SysLojaInfo.Daos;

namespace SysLojaInfo.Ctrls
{
    internal class ctrlFormas : dao
    {
        private daoFormas aDao;

        public ctrlFormas()
        {
            aDao = new daoFormas();
        }
        public override void salvar(object obj)
        {
            base.salvar(obj);
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

        public List<FormasPag> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }

        public FormasPag buscar(string str)
        {
            return aDao.buscar(str);
        }
        public FormasPag buscar(int cod)
        {
            return aDao.buscar(cod);
        }
    }
}
