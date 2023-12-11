using MySql.Data.MySqlClient;
using SysLojaInfo.Classes;
using SysLojaInfo.Ctrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Daos
{
    internal class daoCidades : ctrl
    {

        private MySqlConnection conn;
        public daoCidades()
        {
            conn = new Conexao().GetConnection();
        }

        public override void salvar(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string oSql = @"insert into Cidades (cidade, ddd, fk_estado, datCad, datAlt, idUser) 
                            values (@cidade, @ddd, @fkestado, @datCad, @datUltAlt, @id_user)";
            aCidade.DatCad = DateTime.Now;
            aCidade.DatUltAlt = DateTime.Now;
            aCidade.QuemAlter = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@cidade", aCidade.cidade);
                execCmd.Parameters.AddWithValue("@ddd", aCidade.DDD);
                execCmd.Parameters.AddWithValue("@fkestado", aCidade.oEstado.Codigo);
                execCmd.Parameters.AddWithValue("datCad", aCidade.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", aCidade.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", aCidade.QuemAlter);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Cidade Cadastrada com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a Cidade:" + ex.Message);
            }
        }
        public override void editar(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string oSql = @"update Cidades set cidade = @cidade, ddd = @ddd, fk_estado = @fkestado, datAlt =  @datAlt, 
                            idUser = @idUsu where idCidade =  @Cod";
            aCidade.DatUltAlt = DateTime.Now;
            aCidade.QuemAlter = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@cidade", aCidade.cidade);
                execCmd.Parameters.AddWithValue("@ddd", aCidade.DDD);
                execCmd.Parameters.AddWithValue("@fkestado", aCidade.oEstado.Codigo);
                execCmd.Parameters.AddWithValue("@datAlt", aCidade.DatUltAlt);
                execCmd.Parameters.AddWithValue("@idUsu", aCidade.QuemAlter);
                execCmd.Parameters.AddWithValue("@Cod", aCidade.Codigo);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Cidade Alterada com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar a Cidade:" + ex.Message);


            }

        }

        public override void deletar(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string oSql = @"delete from Cidades where idCidade =  @Cod";

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);

                execCmd.Parameters.AddWithValue("@Cod", aCidade.Codigo);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Cidade Excluida com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir a Cidade:" + ex.Message);
            }
        }

        public List<Cidades> SelecionaDS()
        {
            string sql = "SELECT * FROM Cidades";
            List<Cidades> ListaCidades = new List<Cidades>();

            ctrlEstados CtrlEstado = new ctrlEstados();

            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Cidades item = new Cidades()
                    {
                        Codigo = Convert.ToInt32(reader["idcidade"]),
                        cidade = Convert.ToString(reader["cidade"]),
                        DDD = Convert.ToString(reader["ddd"]),
                        oEstado = CtrlEstado.buscar(Convert.ToInt32(reader["fk_estado"])),
                        DatCad = Convert.ToDateTime(reader["datCad"]),
                        DatUltAlt = Convert.ToDateTime(reader["datAlt"]),
                        QuemAlter = Convert.ToInt32(reader["idUser"])
                    };
                    ListaCidades.Add(item);
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
            if (ListaCidades.Count > 0)
            {
                return ListaCidades;
            }
            else
            {
                return ListaCidades;
            }
        }

        public Cidades buscar(string str)
        {
            Cidades item = new Cidades();

            ctrlEstados CtrlEstado = new ctrlEstados();

            string oSql = "SELECT * FROM Cidades WHERE cidade = @cidade";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cidade", str);

            try
            {
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idCidade"]);
                    item.cidade = Convert.ToString(reader["cidade"]);
                    item.DDD = Convert.ToString(reader["ddd"]);
                    item.oEstado = CtrlEstado.buscar(Convert.ToInt32(reader["fk_estado"]));
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

        public Cidades buscar(int cod)
        {
            Cidades item = new Cidades();

            ctrlEstados CtrlEstado = new ctrlEstados();

            string oSql = "SELECT * FROM Cidades WHERE idcidade= @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", cod);

            try
            {
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idCidade"]);
                    item.cidade = Convert.ToString(reader["cidade"]);
                    item.DDD = Convert.ToString(reader["ddd"]);
                    item.oEstado = CtrlEstado.buscar(Convert.ToInt32(reader["fk_estado"]));
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
