using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class ctrlFornecedores: SysLojaInfo.ctrl
    {
        private daoFornecedores aDao;

        public ctrlFornecedores()
        {
            aDao = new daoFornecedores();
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

        public List<Fornecedores> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }

        public Fornecedores buscar(string str)
        {
            return aDao.buscar(str);
        }

        public Fornecedores buscar(int cod)
        {
            return aDao.buscar(cod);
        }
    }
}
