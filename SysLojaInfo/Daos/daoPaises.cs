using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using SysLojaInfo.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Daos
{
    internal class daoPaises : dao
    {

        private MySqlConnection conn;
        public daoPaises()
        {
            conn = new Conexao().GetConnection();
        }

        public override void salvar(object obj)
        {
            base.salvar(obj);
            Paises oPais = (Paises)obj;
            string oSql = @"insert into Paises (nome, sigla, ddi, datCad, datAlt, idUser) 
                            values (@nome, @sigla, @ddi, @datCad, @datUltAlt, @id_user)";
            oPais.DatCad = DateTime.Now;
            oPais.DatUltAlt = DateTime.Now;
            oPais.QuemAlter = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@nome", oPais.Pais);
                execCmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                execCmd.Parameters.AddWithValue("@ddi", oPais.DDI);
                execCmd.Parameters.AddWithValue("datCad", oPais.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", oPais.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oPais.QuemAlter);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Pais Cadastrado com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Pais:" + ex.Message);
            }
        }
        public override void editar(object obj)
        {
            Paises oPais = (Paises)obj;
            string oSql = @"update Paises set nome = @nome, sigla = @sigla, ddi = @ddi, datAlt =  @datAlt, 
                            idUser = @idUsu where idPais =  @Cod";
            oPais.DatUltAlt = DateTime.Now;
            oPais.QuemAlter = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@nome", oPais.Pais);
                execCmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                execCmd.Parameters.AddWithValue("@ddi", oPais.DDI);
                execCmd.Parameters.AddWithValue("@datAlt", oPais.DatUltAlt);
                execCmd.Parameters.AddWithValue("@idUsu", oPais.QuemAlter);
                execCmd.Parameters.AddWithValue("@Cod", oPais.Codigo);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Pais Alterado com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar o Pais:" + ex.Message);


            }

        }

        public override void deletar(object obj)
        {
            Paises oPais = (Paises)obj;
            string oSql = @"delete from Paises where idPais =  @Cod";

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);

                execCmd.Parameters.AddWithValue("@Cod", oPais.Codigo);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Pais Excluido com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir o Pais:" + ex.Message);
            }
        }

        public List<Paises> SelecionaDS()
        {
            string sql = "SELECT * FROM Paises";
            List<Paises> ListaPaises = new List<Paises>();


            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Paises item = new Paises()
                    {
                        Codigo = Convert.ToInt32(reader["idPais"]),
                        Pais = Convert.ToString(reader["nome"]),
                        Sigla = Convert.ToString(reader["sigla"]),
                        DDI = Convert.ToString(reader["ddi"]),
                        DatCad = Convert.ToDateTime(reader["datCad"]),
                        DatUltAlt = Convert.ToDateTime(reader["datAlt"]),
                        QuemAlter = Convert.ToInt32(reader["idUser"])
                    };
                    ListaPaises.Add(item);
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
            if (ListaPaises.Count > 0)
            {
                return ListaPaises;
            }
            else
            {
                return ListaPaises;
            }
        }

        public Paises buscar(string str)
        {
            Paises item = new Paises();

            string oSql = "SELECT * FROM PAISES WHERE nome = @pais";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@pais", str);

            try
            {
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idPais"]);
                    item.Pais = Convert.ToString(reader["nome"]);
                    item.Sigla = Convert.ToString(reader["sigla"]);
                    item.DDI = Convert.ToString(reader["ddi"]);
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

        public Paises buscar(int cod)
        {
            Paises item = new Paises();

            string oSql = "SELECT * FROM PAISES WHERE idPais = @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", cod);

            try
            {
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idPais"]);
                    item.Pais = Convert.ToString(reader["nome"]);
                    item.Sigla = Convert.ToString(reader["sigla"]);
                    item.DDI = Convert.ToString(reader["ddi"]);
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
