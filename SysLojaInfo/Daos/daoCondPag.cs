using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.CryptoPro;
using SysLojaInfo.Classes;
using SysLojaInfo.Ctrls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Daos
{
    internal class daoCondPag : dao
    {
        private MySqlConnection conn;
        public daoCondPag()
        {
            conn = new Conexao().GetConnection();
        }
        public override void salvar(object obj)
        {
            CondicoesPag mCond = (CondicoesPag)obj;
            List<Parcelas> lista = mCond.ListaParc;

            ctrlFormas aCtrlForma = new ctrlFormas();

            mCond.DatCad = DateTime.Now;
            mCond.DatUltAlt = DateTime.Now;
            mCond.QuemAlter = 0;

            string insertCond = @"insert into condPag (condicao, taxa, multa, desconto, datCad, datAlt, idUser) 
                                Values (@cond, @taxa, @multa, @desconto, @datcad, @datAlt, @idUser)";

            string selectMaxCond = @"select max(idCond) as cod from condPag";

            string insertParcelas = @"insert into parcelas (nParc, codCond, dias, percen, codForma)
                                        values (@nParc, @codCond, @dias, @percent, @forma)";

            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();

            try
            {
                MySqlCommand execInsertCond = new MySqlCommand(insertCond, conn);
                execInsertCond.Parameters.AddWithValue("@cond", mCond.condicao);
                execInsertCond.Parameters.AddWithValue("@taxa", mCond.taxa);
                execInsertCond.Parameters.AddWithValue("@multa", mCond.multa);
                execInsertCond.Parameters.AddWithValue("@desconto", mCond.desconto);
                execInsertCond.Parameters.AddWithValue("@datcad", mCond.DatCad);
                execInsertCond.Parameters.AddWithValue("@datalt", mCond.DatUltAlt);
                execInsertCond.Parameters.AddWithValue("@idUser", mCond.QuemAlter);
                execInsertCond.ExecuteNonQuery();

                MySqlCommand execSelectCond = new MySqlCommand(selectMaxCond, conn);
                MySqlDataReader readerCond = execSelectCond.ExecuteReader();
                if (readerCond.Read())
                {
                    mCond.Codigo = Convert.ToInt32(readerCond["cod"]);
                }
                readerCond.Close();



                foreach (Parcelas item in lista)
                {
                    MySqlCommand execInsertParcelas = new MySqlCommand(insertParcelas, conn);
                    item.aForma = aCtrlForma.buscar(item.aForma.forma);
                    execInsertParcelas.Parameters.AddWithValue("@nParc", item.nParcela);
                    execInsertParcelas.Parameters.AddWithValue("@codCond", mCond.Codigo);
                    execInsertParcelas.Parameters.AddWithValue("@dias", item.dias);
                    execInsertParcelas.Parameters.AddWithValue("@percent", item.percent);
                    execInsertParcelas.Parameters.AddWithValue("@forma", item.aForma.Codigo);

                    execInsertParcelas.ExecuteNonQuery();

                }
                MessageBox.Show("Condição de pagamentos cadastrada com sucesso");

                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a condição de pagamento:" + ex);
                trans.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteParc(int cod)
        {

            string deleteParcelas = @"delete from Parcelas where codCond = @cod";

            try
            {
                MySqlCommand execDeleteParc = new MySqlCommand(deleteParcelas, conn);
                execDeleteParc.Parameters.AddWithValue("@cod", cod);
                execDeleteParc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
        public void excluir(object obj)
        {
            CondicoesPag aCond = (CondicoesPag)obj;
            string deleteCond = @"delete from CondPag where idCond = @cod";

            conn.Open();

            MySqlTransaction trans = conn.BeginTransaction();
            try
            {

                DeleteParc(aCond.Codigo);
                MySqlCommand execDeleteCond = new MySqlCommand(deleteCond, conn);
                execDeleteCond.Parameters.AddWithValue("@cod", aCond.Codigo);
                execDeleteCond.ExecuteNonQuery();

                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }
        public override void editar(object obj)
        {
            CondicoesPag mCond = (CondicoesPag)obj;
            List<Parcelas> lista = mCond.ListaParc;


            ctrlFormas aCtrlForma = new ctrlFormas();

            mCond.DatUltAlt = DateTime.Now;
            mCond.QuemAlter = 0;

            string updateCond = @"update condPag set condicao = @cond, taxa = @taxa, multa = @multa, 
                                desconto = @desconto, datAlt = @datAlt, idUser = @idUser where idCond = @cod";


            string insertParcelas = @"insert into parcelas (nParc, codCond, dias, percen, codForma)
                                        values (@nParc, @codCond, @dias, @percent, @forma)";

            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();

            try
            {

                MySqlCommand execUpdateCond = new MySqlCommand(updateCond, conn);
                execUpdateCond.Parameters.AddWithValue("@cond", mCond.condicao);
                execUpdateCond.Parameters.AddWithValue("@taxa", mCond.taxa);
                execUpdateCond.Parameters.AddWithValue("@multa", mCond.multa);
                execUpdateCond.Parameters.AddWithValue("@desconto", mCond.desconto);
                execUpdateCond.Parameters.AddWithValue("@datcad", mCond.DatCad);
                execUpdateCond.Parameters.AddWithValue("@datalt", mCond.DatUltAlt);
                execUpdateCond.Parameters.AddWithValue("@idUser", mCond.QuemAlter);
                execUpdateCond.Parameters.AddWithValue("@cod", mCond.Codigo);
                execUpdateCond.ExecuteNonQuery();

                DeleteParc(mCond.Codigo);

                foreach (Parcelas item in lista)
                {
                    MySqlCommand execInsertParcelas = new MySqlCommand(insertParcelas, conn);
                    item.aForma = aCtrlForma.buscar(item.aForma.forma);
                    execInsertParcelas.Parameters.AddWithValue("@nParc", item.nParcela);
                    execInsertParcelas.Parameters.AddWithValue("@codCond", mCond.Codigo);
                    execInsertParcelas.Parameters.AddWithValue("@dias", item.dias);
                    execInsertParcelas.Parameters.AddWithValue("@percent", item.percent);
                    execInsertParcelas.Parameters.AddWithValue("@forma", item.aForma.Codigo);

                    execInsertParcelas.ExecuteNonQuery();

                }
                MessageBox.Show("Condição de pagamentos alterada com sucesso");

                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a condição de pagamento:" + ex);
                trans.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }
        public List<CondicoesPag> SelecionaDS()
        {
            string sql = "SELECT * FROM CondPag";
            List<CondicoesPag> ListaCond = new List<CondicoesPag>();

            conn.Open();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    CondicoesPag item = new CondicoesPag()
                    {
                        Codigo = Convert.ToInt32(reader["idCond"]),
                        condicao = Convert.ToString(reader["condicao"]),
                        taxa = Convert.ToDouble(reader["taxa"]),
                        multa = Convert.ToDouble(reader["multa"]),
                        desconto = Convert.ToDouble(reader["desconto"]),
                        DatCad = Convert.ToDateTime(reader["datCad"]),
                        DatUltAlt = Convert.ToDateTime(reader["datAlt"]),
                        QuemAlter = Convert.ToInt32(reader["idUser"])
                    };
                    ListaCond.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            if (ListaCond.Count > 0)
            {
                return ListaCond;
            }
            else
            {
                return ListaCond;
            }
        }

        public List<Parcelas> BuscaParc(int cod)
        {
            string sql = "SELECT * FROM Parcelas where codCond = @cond";
            ctrlFormas ctrlFormas = new ctrlFormas();
            List<Parcelas> ListaParc = new List<Parcelas>();

            conn.Open();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                execCmd.Parameters.AddWithValue("@cond", cod);
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Parcelas item = new Parcelas()
                    {
                        nParcela = Convert.ToInt32(reader["nParc"]),
                        dias = Convert.ToInt32(reader["dias"]),
                        percent = Convert.ToDouble(reader["percen"]),
                        aForma = ctrlFormas.buscar(Convert.ToInt32(reader["codForma"]))
                    };
                    ListaParc.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            if (ListaParc.Count > 0)
            {
                return ListaParc;
            }
            else
            {
                return ListaParc;
            }
        }
        public CondicoesPag buscar(string str)
        {
            CondicoesPag item = new CondicoesPag();

            string oSql = "SELECT * FROM condPag WHERE condicao = @Cond";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@Cond", str);
            conn.Open();

            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idCond"]);
                    item.condicao = Convert.ToString(reader["condicao"]);
                    item.taxa = Convert.ToDouble(reader["taxa"]);
                    item.multa = Convert.ToDouble(reader["multa"]);
                    item.desconto = Convert.ToDouble(reader["desconto"]);
                    item.DatCad = Convert.ToDateTime(reader["datCad"]);
                    item.DatUltAlt = Convert.ToDateTime(reader["datAlt"]);
                    item.QuemAlter = Convert.ToInt32(reader["idUser"]);
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return item;
        }
        public CondicoesPag buscar(int cod)
        {
            CondicoesPag item = new CondicoesPag();

            string oSql = "SELECT * FROM CondPag WHERE idCond = @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", cod);

            conn.Open();
            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idCond"]);
                    item.condicao = Convert.ToString(reader["condicao"]);
                    item.taxa = Convert.ToDouble(reader["taxa"]);
                    item.multa = Convert.ToDouble(reader["multa"]);
                    item.desconto = Convert.ToDouble(reader["desconto"]);
                    item.DatCad = Convert.ToDateTime(reader["datCad"]);
                    item.DatUltAlt = Convert.ToDateTime(reader["datAlt"]);
                    item.QuemAlter = Convert.ToInt32(reader["idUser"]);
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return item;
        }
    }
}
