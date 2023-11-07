using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class daoFormas: SysLojaInfo.dao
    {
        private MySqlConnection conn;
        public daoFormas()
        {
            this.conn = new Conexao().GetConnection();
        }

        public override void salvar(object obj)
        {
            FormasPag aForma = (FormasPag)obj;
            string oSql = @"insert into FormaPag (forma, datCad, datAlt, idUser) 
                            values (@forma, @datCad, @datUltAlt, @id_user)";
            aForma.DatCad = DateTime.Now;
            aForma.DatUltAlt = DateTime.Now;
            aForma.QuemAlter = 0;

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@forma", aForma.forma);
                execCmd.Parameters.AddWithValue("datCad", aForma.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", aForma.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", aForma.QuemAlter);


                execCmd.ExecuteNonQuery();
                MessageBox.Show("Forma de pagamento Cadastrada com Sucesso");
                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao cadastrar a Forma de Pagamento:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public override void editar(object obj)
        {
            FormasPag aForma = (FormasPag)obj;
            string oSql = @"update FormaPag set forma = @forma, datAlt =  @datAlt, 
                            idUser = @idUsu where idForma =  @Cod";
            aForma.DatUltAlt = DateTime.Now;
            aForma.QuemAlter = 0;

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@forma", aForma.forma);
                execCmd.Parameters.AddWithValue("@datalt", aForma.DatUltAlt);
                execCmd.Parameters.AddWithValue("@idUsu", aForma.QuemAlter);
                execCmd.Parameters.AddWithValue("@Cod", aForma.Codigo);

                execCmd.ExecuteNonQuery();
                MessageBox.Show("Forma de Pagamento Alterada com Sucesso");

                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao Alterar a Forma de Pagamento:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public override void deletar(object obj)
        {
            FormasPag aForma = (FormasPag)obj;
            string oSql = @"delete from FormaPag where idForma =  @Cod";

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);

                execCmd.Parameters.AddWithValue("@Cod", aForma.Codigo);

                execCmd.ExecuteNonQuery();
                MessageBox.Show("Forma de Pagamento excluida com Sucesso");

                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao Excluir a Forma de Pagamento" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<FormasPag> SelecionaDS()
        {
            string sql = "SELECT * FROM FormaPag";
            List<FormasPag> ListaFormas = new List<FormasPag>();

            conn.Open();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    FormasPag item = new FormasPag()
                    {
                        Codigo = Convert.ToInt32(reader["idForma"]),
                        forma = Convert.ToString(reader["forma"]),
                        DatCad = Convert.ToDateTime(reader["datCad"]),
                        DatUltAlt = Convert.ToDateTime(reader["datAlt"]),
                        QuemAlter = Convert.ToInt32(reader["idUser"])
                    };
                    ListaFormas.Add(item);
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
            if (ListaFormas.Count > 0)
            {
                return ListaFormas;
            }
            else
            {
                return ListaFormas;
            }
        }

        public FormasPag buscar(string str)
        {
            FormasPag item = new FormasPag();

            string oSql = "SELECT * FROM FormaPag WHERE forma = @forma";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@forma", str);
            conn.Open();

            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idForma"]);
                    item.forma = Convert.ToString(reader["forma"]);
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

        public FormasPag buscar(int cod)
        {
            FormasPag item = new FormasPag();

            string oSql = "SELECT * FROM FormasPag WHERE idForma = @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", cod);

            conn.Open();
            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idForma"]);
                    item.forma = Convert.ToString(reader["forma"]);
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
