using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SysLojaInfo
{
    internal class daoClientes: SysLojaInfo.dao
    {
        private MySqlConnection conn;
        public daoClientes()
        {
            this.conn = new Conexao().GetConnection();
        }

        public override void salvar(object obj)
        {
            Clientes oCliente = (Clientes)obj;
            string oSql = @"insert into Clientes (nome, cpfCnpj, rg, logr, num, natPes, bairro, limCred, fk_cidade,
                            telres, telcel, email, datCad, datAlt, idUser) values (@cliente, @cpfCnpj, @rg, @logr, 
                            @num, @nat, @bairro, @limCred, @fkCidade, @telRes, @telcel, @em, @datCad, @datUltAlt, @id_user)";
            oCliente.DatCad = DateTime.Now;
            oCliente.DatUltAlt = DateTime.Now;
            oCliente.QuemAlter = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@cliente", oCliente.nome);
                execCmd.Parameters.AddWithValue("@cpfCnpj", oCliente.cpfCnpj);
                execCmd.Parameters.AddWithValue("@rg", oCliente.rg);
                execCmd.Parameters.AddWithValue("@logr", oCliente.logr);
                execCmd.Parameters.AddWithValue("@num", oCliente.numero);
                execCmd.Parameters.AddWithValue("@nat", oCliente.natPess);
                execCmd.Parameters.AddWithValue("@bairro", oCliente.bairro);
                execCmd.Parameters.AddWithValue("@limCred", oCliente.limCred);
                execCmd.Parameters.AddWithValue("@fkCidade", oCliente.aCidade.Codigo);
                execCmd.Parameters.AddWithValue("@telRes", oCliente.telRes);
                execCmd.Parameters.AddWithValue("@telCel", oCliente.telCel);
                execCmd.Parameters.AddWithValue("@em", oCliente.email);
                execCmd.Parameters.AddWithValue("datCad", oCliente.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", oCliente.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oCliente.QuemAlter);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Cadastrado com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Cliente:" + ex.Message);
            }
        }
        public override void editar(object obj)
        {
            Clientes oCliente = (Clientes)obj;
            string oSql = @"update Clientes SET nome = @cliente, cpfCnpj = @cpfCnpj, rg = @rg, logr = @logr, num = @num,
                            natPes = @nat, bairro = @bairro, limCred = @limCred, fk_cidade = @fkCidade, telres = @telRes,
                            telcel = @telcel, email = @em, datAlt = @datUltAlt, idUser = @id_user where idCliente =  @Cod";
            oCliente.DatUltAlt = DateTime.Now;
            oCliente.QuemAlter = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@cliente", oCliente.nome);
                execCmd.Parameters.AddWithValue("@cpfCnpj", oCliente.cpfCnpj);
                execCmd.Parameters.AddWithValue("@rg", oCliente.rg);
                execCmd.Parameters.AddWithValue("@logr", oCliente.logr);
                execCmd.Parameters.AddWithValue("@num", oCliente.numero);
                execCmd.Parameters.AddWithValue("@nat", oCliente.natPess);
                execCmd.Parameters.AddWithValue("@bairro", oCliente.bairro);
                execCmd.Parameters.AddWithValue("@limCred", oCliente.limCred);
                execCmd.Parameters.AddWithValue("@fkCidade", oCliente.aCidade.Codigo);
                execCmd.Parameters.AddWithValue("@telRes", oCliente.telRes);
                execCmd.Parameters.AddWithValue("@telCel", oCliente.telCel);
                execCmd.Parameters.AddWithValue("@em", oCliente.email);
                execCmd.Parameters.AddWithValue("@datUltAlt", oCliente.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oCliente.QuemAlter);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Alterado com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar o Cliente:" + ex.Message);


            }

        }

        public override void deletar(object obj)
        {
            Clientes oCliente = (Clientes)obj;
            string oSql = @"delete from Clientes where idCliente =  @Cod";

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);

                execCmd.Parameters.AddWithValue("@Cod", oCliente.Codigo);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Excluido com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir o Cliente:" + ex.Message);
            }
        }

        public List<Clientes> SelecionaDS()
        {
            string sql = "SELECT * FROM Clientes";
            List<Clientes> ListaClientes = new List<Clientes>();

            ctrlCidades CtrlCidade = new ctrlCidades();

            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Clientes item = new Clientes()
                    {
                        Codigo = Convert.ToInt32(reader["idCliente"]),
                        nome = Convert.ToString(reader["nome"]),
                        cpfCnpj = Convert.ToString(reader["cpfCnpj"]),
                        rg = Convert.ToString(reader["rg"]),
                        logr = Convert.ToString(reader["logr"]),
                        numero  = Convert.ToInt32(reader["num"]),
                        natPess = Convert.ToString(reader["natPes"]),
                        bairro = Convert.ToString(reader["bairro"]),
                        limCred = Convert.ToDouble(reader["limCred"]),
                        aCidade = CtrlCidade.buscar(Convert.ToInt32(reader["fk_cidade"])),
                        telRes = Convert.ToString(reader["telRes"]),
                        telCel = Convert.ToString(reader["telCel"]),
                        email = Convert.ToString(reader["email"]),
                        DatCad = Convert.ToDateTime(reader["datCad"]),
                        DatUltAlt = Convert.ToDateTime(reader["datAlt"]),
                        QuemAlter = Convert.ToInt32(reader["idUser"]),
                    };
                    ListaClientes.Add(item);
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
            if (ListaClientes.Count > 0)
            {
                return ListaClientes;
            }
            else
            {
                return ListaClientes;
            }
        }

        public Clientes buscar(string str)
        {
            Clientes item = new Clientes();

            ctrlCidades CtrlCidade = new ctrlCidades();

            string oSql = "SELECT * FROM Clientes WHERE nome = @cliente";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cliente", str);

            try
            {
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idCliente"]);
                    item.nome = Convert.ToString(reader["nome"]);
                    item.cpfCnpj = Convert.ToString(reader["cpfCnpj"]);
                    item.rg = Convert.ToString(reader["rg"]);
                    item.logr = Convert.ToString(reader["logr"]);
                    item.numero = Convert.ToInt32(reader["num"]);
                    item.natPess = Convert.ToString(reader["natPes"]);
                    item.bairro = Convert.ToString(reader["bairro"]);
                    item.limCred = Convert.ToDouble(reader["limCred"]);
                    item.aCidade = CtrlCidade.buscar(Convert.ToInt32(reader["fk_cidade"]));
                    item.telRes = Convert.ToString(reader["telRes"]);
                    item.telCel = Convert.ToString(reader["telCel"]);
                    item.email = Convert.ToString(reader["email"]);
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

        public Clientes buscar(int cod)
        {
            Clientes item = new Clientes();

            ctrlCidades CtrlCidade = new ctrlCidades(); ;

            string oSql = "SELECT * FROM Clientes WHERE idCliente= @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", cod);

            try
            {
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idCliente"]);
                    item.nome = Convert.ToString(reader["nome"]);
                    item.cpfCnpj = Convert.ToString(reader["cpfCnpj"]);
                    item.rg = Convert.ToString(reader["rg"]);
                    item.logr = Convert.ToString(reader["logr"]);
                    item.numero = Convert.ToInt32(reader["num"]);
                    item.natPess = Convert.ToString(reader["natPes"]);
                    item.bairro = Convert.ToString(reader["bairro"]);
                    item.limCred = Convert.ToDouble(reader["limCred"]);
                    item.aCidade = CtrlCidade.buscar(Convert.ToInt32(reader["fk_cidade"]));
                    item.telRes = Convert.ToString(reader["telRes"]);
                    item.telCel = Convert.ToString(reader["telCel"]);
                    item.email = Convert.ToString(reader["email"]);
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
