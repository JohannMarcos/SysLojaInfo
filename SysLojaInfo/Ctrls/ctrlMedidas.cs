using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysLojaInfo.Classes;
using SysLojaInfo.Daos;

namespace SysLojaInfo.Ctrls
{
    internal class ctrlMedidas : ctrl
    {
        private daoMedidas aDao;

        public ctrlMedidas()
        {
            aDao = new daoMedidas();
        }

        public override void editar(object obj)
        {
            aDao.editar(obj);
        }

        public List<Medidas> buscar(string str)
        {
            return aDao.buscar(str);
        }

        public Medidas buscarAbr(string str)
        {
            return aDao.buscarAbr(str);
        }

        public List<Medidas> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }

        public List<Medidas> BuscaAtivos()
        {
            return aDao.buscaAtivos();
        }
    }
}
