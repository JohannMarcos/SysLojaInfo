using MySql.Data.MySqlClient;
using SysLojaInfo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Daos
{
    internal class daoMedidas : dao
    {
        private MySqlConnection conn;
        public daoMedidas()
        {
            conn = new Conexao().GetConnection();
        }
        public override void editar(object obj)
        {
            Medidas aMedida = (Medidas)obj;
            string oSql = @"update Medidas set ativo = @ativo, datalt = @datalt, idUser = @iduser where uMedida =  @med";

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@ativo", aMedida.ativo);
                execCmd.Parameters.AddWithValue("@datalt", aMedida.DatUltAlt);
                execCmd.Parameters.AddWithValue("@iduser", aMedida.QuemAlter);
                execCmd.Parameters.AddWithValue("@med", aMedida.uMedida);


                execCmd.ExecuteNonQuery();
                MessageBox.Show("Alterado com Sucesso");

                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao Alterar:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }


        public List<Medidas> SelecionaDS()
        {
            string sql = "SELECT * FROM Medidas";
            List<Medidas> ListaMedidas = new List<Medidas>();

            conn.Open();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Medidas item = new Medidas()
                    {
                        uMedida = Convert.ToString(reader["uMedida"]),
                        descricao = Convert.ToString(reader["descricao"]),
                        ativo = Convert.ToString(reader["ativo"]),
                        DatUltAlt = Convert.ToDateTime(reader["datalt"]),
                        QuemAlter = Convert.ToInt32(reader["iduser"]),
                    };
                    ListaMedidas.Add(item);
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
            if (ListaMedidas.Count > 0)
            {
                return ListaMedidas;
            }
            else
            {
                return ListaMedidas;
            }
        }
        public List<Medidas> buscaAtivos()
        {
            string sql = "SELECT * FROM Medidas where ativo = 'S'";
            List<Medidas> ListaMedidas = new List<Medidas>();

            conn.Open();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Medidas item = new Medidas()
                    {
                        uMedida = Convert.ToString(reader["uMedida"]),
                        descricao = Convert.ToString(reader["descricao"]),
                        ativo = Convert.ToString(reader["ativo"]),
                        DatUltAlt = Convert.ToDateTime(reader["datalt"]),
                        QuemAlter = Convert.ToInt32(reader["iduser"]),
                    };
                    ListaMedidas.Add(item);
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
            if (ListaMedidas.Count > 0)
            {
                return ListaMedidas;
            }
            else
            {
                return ListaMedidas;
            }
        }


        public List<Medidas> buscar(string str)
        {
            List<Medidas> ListaMedidas = new List<Medidas>();

            string oSql = "SELECT * FROM Medidas WHERE descricao like '@medida";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@Medida", str + "%'");
            conn.Open();

            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Medidas item = new Medidas()
                    {
                        uMedida = Convert.ToString(reader["uMedida"]),
                        descricao = Convert.ToString(reader["descricao"]),
                        ativo = Convert.ToString(reader["ativo"]),
                        DatUltAlt = Convert.ToDateTime(reader["datalt"]),
                        QuemAlter = Convert.ToInt32(reader["iduser"]),
                    };
                    ListaMedidas.Add(item);
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
            return ListaMedidas;
        }

        public Medidas buscarAbr(string str)
        {
            Medidas item = new Medidas();

            string oSql = "SELECT * FROM medidas WHERE uMedida = @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", str);

            conn.Open();
            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.uMedida = Convert.ToString(reader["uMedida"]);
                    item.descricao = Convert.ToString(reader["descricao"]);
                    item.ativo = Convert.ToString(reader["ativo"]);
                    item.DatUltAlt = Convert.ToDateTime(reader["datalt"]);
                    item.QuemAlter = Convert.ToInt32(reader["iduser"]);
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
