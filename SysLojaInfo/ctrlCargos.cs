using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class ctrlCargos: SysLojaInfo.ctrl
    {
        private daoCargos aDao;

        public ctrlCargos()
        {
            aDao = new daoCargos();
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

        public List<Cargos> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }

        public Cargos buscar(string str)
        {
            return aDao.buscar(str);
        }
        public Cargos buscar(int cod)
        {
            return aDao.buscar(cod);
        }
    }
}
