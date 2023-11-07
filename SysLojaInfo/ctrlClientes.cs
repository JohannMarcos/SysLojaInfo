using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class ctrlClientes:SysLojaInfo.ctrl
    {
        private daoClientes aDao;

        public ctrlClientes()
        {
            aDao = new daoClientes();
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

        public List<Clientes> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }

        public Clientes buscar(string str)
        {
            return aDao.buscar(str);
        }

        public Clientes buscar(int cod)
        {
            return aDao.buscar(cod);
        }
    }
}
