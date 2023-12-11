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
    internal class daoEstados : dao
    {

        private MySqlConnection conn;
        public daoEstados()
        {
            conn = new Conexao().GetConnection();
        }

        public override void salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string oSql = @"insert into Estados (estado, uf, fk_pais, datCad, datAlt, idUser) 
                            values (@estado, @uf, @fkpais, @datCad, @datUltAlt, @id_user)";
            oEstado.DatCad = DateTime.Now;
            oEstado.DatUltAlt = DateTime.Now;
            oEstado.QuemAlter = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@estado", oEstado.estado);
                execCmd.Parameters.AddWithValue("@uf", oEstado.uf);
                execCmd.Parameters.AddWithValue("@fkpais", oEstado.oPais.Codigo);
                execCmd.Parameters.AddWithValue("datCad", oEstado.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", oEstado.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oEstado.QuemAlter);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Estado Cadastrado com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Estado:" + ex.Message);
            }
        }
        public override void editar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string oSql = @"update Estados set estado = @estado, uf = @uf, fk_pais = @fkPais, datAlt =  @datAlt, 
                            idUser = @idUsu where idEstado =  @Cod";
            oEstado.DatUltAlt = DateTime.Now;
            oEstado.QuemAlter = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@estado", oEstado.estado);
                execCmd.Parameters.AddWithValue("@uf", oEstado.uf);
                execCmd.Parameters.AddWithValue("@fkpais", oEstado.oPais.Codigo);
                execCmd.Parameters.AddWithValue("@datAlt", oEstado.DatUltAlt);
                execCmd.Parameters.AddWithValue("@idUsu", oEstado.QuemAlter);
                execCmd.Parameters.AddWithValue("@Cod", oEstado.Codigo);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Estado Alterado com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar o Estado:" + ex.Message);


            }

        }

        public override void deletar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string oSql = @"delete from Estados where idEstado =  @Cod";

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);

                execCmd.Parameters.AddWithValue("@Cod", oEstado.Codigo);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Estado Excluido com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir o Estado:" + ex.Message);
            }
        }

        public List<Estados> SelecionaDS()
        {
            string sql = "SELECT * FROM Estados";
            List<Estados> ListaEstados = new List<Estados>();

            ctrlPaises CtrlPais = new ctrlPaises();

            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Estados item = new Estados()
                    {
                        Codigo = Convert.ToInt32(reader["idEstado"]),
                        estado = Convert.ToString(reader["estado"]),
                        uf = Convert.ToString(reader["uf"]),
                        oPais = CtrlPais.buscar(Convert.ToInt32(reader["fk_pais"])),
                        DatCad = Convert.ToDateTime(reader["datCad"]),
                        DatUltAlt = Convert.ToDateTime(reader["datAlt"]),
                        QuemAlter = Convert.ToInt32(reader["idUser"])
                    };
                    ListaEstados.Add(item);
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
            if (ListaEstados.Count > 0)
            {
                return ListaEstados;
            }
            else
            {
                return ListaEstados;
            }
        }

        public Estados buscar(string str)
        {
            Estados item = new Estados();

            ctrlPaises CtrlPais = new ctrlPaises();

            string oSql = "SELECT * FROM ESTADOS WHERE Estado = @estado";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@estado", str);

            try
            {
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idEstado"]);
                    item.estado = Convert.ToString(reader["estado"]);
                    item.uf = Convert.ToString(reader["uf"]);
                    item.oPais = CtrlPais.buscar(Convert.ToInt32(reader["fk_pais"]));
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

        public Estados buscar(int cod)
        {
            Estados item = new Estados();

            ctrlPaises CtrlPais = new ctrlPaises();

            string oSql = "SELECT * FROM ESTADOS WHERE idEstado = @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", cod);

            try
            {
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idEstado"]);
                    item.estado = Convert.ToString(reader["estado"]);
                    item.uf = Convert.ToString(reader["uf"]);
                    item.oPais = CtrlPais.buscar(Convert.ToInt32(reader["fk_pais"]));
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
