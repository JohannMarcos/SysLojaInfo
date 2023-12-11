using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysLojaInfo.Classes;
using SysLojaInfo.Daos;

namespace SysLojaInfo.Ctrls
{
    internal class ctrlProdutos : ctrl
    {
        private daoProdutos aDao;

        public ctrlProdutos()
        {
            aDao = new daoProdutos();
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

        public List<Produtos> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }

        public Produtos buscar(string str)
        {
            return aDao.buscar(str);
        }

        public Produtos buscar(int cod)
        {
            return aDao.buscar(cod);
        }
    }
}
