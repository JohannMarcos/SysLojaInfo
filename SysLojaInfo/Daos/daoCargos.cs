using MySql.Data.MySqlClient;
using SysLojaInfo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Daos
{
    internal class daoCargos : dao
    {
        private MySqlConnection conn;
        public daoCargos()
        {
            conn = new Conexao().GetConnection();
        }

        public override void salvar(object obj)
        {
            Cargos oCargo = (Cargos)obj;
            string oSql = @"insert into Cargos (cargo, externo, datCad, datAlt, idUser) 
                            values (@cargo, @externo, @datCad, @datUltAlt, @id_user)";
            oCargo.DatCad = DateTime.Now;
            oCargo.DatUltAlt = DateTime.Now;
            oCargo.QuemAlter = 0;

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@cargo", oCargo.cargo);
                execCmd.Parameters.AddWithValue("@externo", oCargo.externo);
                execCmd.Parameters.AddWithValue("datCad", oCargo.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", oCargo.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oCargo.QuemAlter);


                execCmd.ExecuteNonQuery();
                MessageBox.Show("Cargo Cadastrado com Sucesso");
                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao cadastrar o Cargo:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public override void editar(object obj)
        {
            Cargos oCargo = (Cargos)obj;
            string oSql = @"update Cargos set cargo = @cargo, externo = @externo, datAlt =  @datAlt, 
                            idUser = @idUsu where idCargo =  @Cod";
            oCargo.DatUltAlt = DateTime.Now;
            oCargo.QuemAlter = 0;

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@cargo", oCargo.cargo);
                execCmd.Parameters.AddWithValue("@externo", oCargo.externo);
                execCmd.Parameters.AddWithValue("@datalt", oCargo.DatUltAlt);
                execCmd.Parameters.AddWithValue("@idUsu", oCargo.QuemAlter);
                execCmd.Parameters.AddWithValue("@Cod", oCargo.Codigo);

                execCmd.ExecuteNonQuery();
                MessageBox.Show("Cargo Alterado com Sucesso");

                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao Alterar o Cargo:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public override void deletar(object obj)
        {
            Cargos oCargo = (Cargos)obj;
            string oSql = @"delete from Cargos where idCargo =  @Cod";

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);

                execCmd.Parameters.AddWithValue("@Cod", oCargo.Codigo);

                execCmd.ExecuteNonQuery();
                MessageBox.Show("Cargo Excluido com Sucesso");

                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao Excluir o Cargo" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Cargos> SelecionaDS()
        {
            string sql = "SELECT * FROM Cargos";
            List<Cargos> ListaCargos = new List<Cargos>();

            conn.Open();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Cargos item = new Cargos()
                    {
                        Codigo = Convert.ToInt32(reader["idCargo"]),
                        cargo = Convert.ToString(reader["cargo"]),
                        externo = Convert.ToString(reader["externo"]),
                        DatCad = Convert.ToDateTime(reader["datCad"]),
                        DatUltAlt = Convert.ToDateTime(reader["datAlt"]),
                        QuemAlter = Convert.ToInt32(reader["idUser"])
                    };
                    ListaCargos.Add(item);
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
            if (ListaCargos.Count > 0)
            {
                return ListaCargos;
            }
            else
            {
                return ListaCargos;
            }
        }

        public Cargos buscar(string str)
        {
            Cargos item = new Cargos();

            string oSql = "SELECT * FROM Cargos WHERE cargo = @Cargo";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@Cargo", str);
            conn.Open();

            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idCargo"]);
                    item.cargo = Convert.ToString(reader["cargo"]);
                    item.externo = Convert.ToString(reader["externo"]);
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

        public Cargos buscar(int cod)
        {
            Cargos item = new Cargos();

            string oSql = "SELECT * FROM Cargos WHERE idCargo = @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", cod);

            conn.Open();
            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idCargo"]);
                    item.cargo = Convert.ToString(reader["cargo"]);
                    item.externo = Convert.ToString(reader["externo"]);
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
