using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysLojaInfo.Classes;
using SysLojaInfo.Daos;

namespace SysLojaInfo.Ctrls
{
    internal class ctrlCidades : ctrl
    {
        private daoCidades aDao;

        public ctrlCidades()
        {
            aDao = new daoCidades();
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

        public List<Cidades> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }

        public Cidades buscar(string str)
        {
            return aDao.buscar(str);
        }

        public Cidades buscar(int cod)
        {
            return aDao.buscar(cod);
        }
    }
}
