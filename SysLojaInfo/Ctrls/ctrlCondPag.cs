using MySql.Data.MySqlClient;
using SysLojaInfo.Classes;
using SysLojaInfo.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Ctrls
{
    internal class ctrlCondPag : ctrl
    {
        private daoCondPag aDao;

        public ctrlCondPag()
        {
            aDao = new daoCondPag();
        }

        public override void salvar(object obj)
        {
            aDao.salvar(obj);
        }
        public void DeleteParc(int cod)
        {
            aDao.DeleteParc(cod);
        }
        public override void editar(object obj)
        {
            aDao.editar(obj);
        }
        public List<CondicoesPag> SelecionaDS()
        {
            return aDao.SelecionaDS();
        }

        public List<Parcelas> BuscaParc(int cod)
        {
            return aDao.BuscaParc(cod);
        }
        public void excluir(object obj)
        {
            aDao.excluir(obj);
        }

        public CondicoesPag buscar(string str)
        {
            return aDao.buscar(str);
        }
        public CondicoesPag buscar(int cod)
        {
            return aDao.buscar(cod);
        }
    }
}
