using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysLojaInfo.Classes;
using SysLojaInfo.Daos;

namespace SysLojaInfo.Ctrls
{
    internal class ctrlEstados : ctrl
    {

        private daoEstados aDao;
        public ctrlEstados()
        {
            aDao = new daoEstados();
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

        public List<Estados> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }

        public Estados buscar(string str)
        {
            return aDao.buscar(str);
        }

        public Estados buscar(int cod)
        {
            return aDao.buscar(cod);
        }


    }
}
