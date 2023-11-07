using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class daoFornecedores: SysLojaInfo.dao
    {
        private MySqlConnection conn;
        public daoFornecedores()
        {
            this.conn = new Conexao().GetConnection();
        }

        public override void salvar(object obj)
        {
            Fornecedores oFornecedor = (Fornecedores)obj;
            string oSql = @"insert into Fornecedores (nome, cpfCnpj, rg, logr, num, natPes, bairro, fk_cidade,
                            telres, telcel, email, datCad, datAlt, idUser) values (@nome, @cpfCnpj, @rg, @logr, 
                            @num, @nat, @bairro, @fkCidade, @telRes, @telcel, @em, @datCad, @datUltAlt, @id_user)";
            oFornecedor.DatCad = DateTime.Now;
            oFornecedor.DatUltAlt = DateTime.Now;
            oFornecedor.QuemAlter = 0;

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@nome", oFornecedor.nome);
                execCmd.Parameters.AddWithValue("@cpfCnpj", oFornecedor.cpfCnpj);
                execCmd.Parameters.AddWithValue("@rg", oFornecedor.rg);
                execCmd.Parameters.AddWithValue("@logr", oFornecedor.logr);
                execCmd.Parameters.AddWithValue("@num", oFornecedor.numero);
                execCmd.Parameters.AddWithValue("@nat", oFornecedor.natPess);
                execCmd.Parameters.AddWithValue("@bairro", oFornecedor.bairro);
                execCmd.Parameters.AddWithValue("@fkCidade", oFornecedor.aCidade.Codigo);
                execCmd.Parameters.AddWithValue("@telRes", oFornecedor.telRes);
                execCmd.Parameters.AddWithValue("@telCel", oFornecedor.telCel);
                execCmd.Parameters.AddWithValue("@em", oFornecedor.email);
                execCmd.Parameters.AddWithValue("datCad", oFornecedor.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", oFornecedor.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oFornecedor.QuemAlter);

                execCmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Cadastrado com Sucesso");
                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao cadastrar o Fornecedor:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public override void editar(object obj)
        {
            Fornecedores oFornecedor = (Fornecedores)obj;
            string oSql = @"update Fornecedores SET nome = @nome, cpfCnpj = @cpfCnpj, rg = @rg, logr = @logr, num = @num,
                            natPes = @nat, bairro = @bairro, fk_cidade = @fkCidade, telres = @telRes,
                            telcel = @telcel, email = @em, datAlt = @datUltAlt, idUser = @id_user where idForn =  @Cod";
            oFornecedor.DatUltAlt = DateTime.Now;
            oFornecedor.QuemAlter = 0;

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@nome", oFornecedor.nome);
                execCmd.Parameters.AddWithValue("@cpfCnpj", oFornecedor.cpfCnpj);
                execCmd.Parameters.AddWithValue("@rg", oFornecedor.rg);
                execCmd.Parameters.AddWithValue("@logr", oFornecedor.logr);
                execCmd.Parameters.AddWithValue("@num", oFornecedor.numero);
                execCmd.Parameters.AddWithValue("@nat", oFornecedor.natPess);
                execCmd.Parameters.AddWithValue("@bairro", oFornecedor.bairro);
                execCmd.Parameters.AddWithValue("@fkCidade", oFornecedor.aCidade.Codigo);
                execCmd.Parameters.AddWithValue("@telRes", oFornecedor.telRes);
                execCmd.Parameters.AddWithValue("@telCel", oFornecedor.telCel);
                execCmd.Parameters.AddWithValue("@em", oFornecedor.email);
                execCmd.Parameters.AddWithValue("@datUltAlt", oFornecedor.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oFornecedor.QuemAlter);

                execCmd.Parameters.AddWithValue("@cod", oFornecedor.Codigo);

                execCmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Alterado com Sucesso");

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao Alterar o Fornecedor:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public override void deletar(object obj)
        {
            Fornecedores oFornecedor = (Fornecedores)obj;
            string oSql = @"delete from Fornecedores where idForn =  @Cod";

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);

                execCmd.Parameters.AddWithValue("@Cod", oFornecedor.Codigo);

                execCmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Excluido com Sucesso");

                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao Excluir o Fornecedor:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Fornecedores> SelecionaDS()
        {
            string sql = "SELECT * FROM Fornecedores";
            List<Fornecedores> ListaFornecedores = new List<Fornecedores>();

            ctrlCidades CtrlCidade = new ctrlCidades();

            conn.Open();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Fornecedores item = new Fornecedores()
                    {
                        Codigo = Convert.ToInt32(reader["idForn"]),
                        nome = Convert.ToString(reader["nome"]),
                        cpfCnpj = Convert.ToString(reader["cpfCnpj"]),
                        rg = Convert.ToString(reader["rg"]),
                        logr = Convert.ToString(reader["logr"]),
                        numero = Convert.ToInt32(reader["num"]),
                        natPess = Convert.ToString(reader["natPes"]),
                        bairro = Convert.ToString(reader["bairro"]),
                        aCidade = CtrlCidade.buscar(Convert.ToInt32(reader["fk_cidade"])),
                        telRes = Convert.ToString(reader["telRes"]),
                        telCel = Convert.ToString(reader["telCel"]),
                        email = Convert.ToString(reader["email"]),
                        DatCad = Convert.ToDateTime(reader["datCad"]),
                        DatUltAlt = Convert.ToDateTime(reader["datAlt"]),
                        QuemAlter = Convert.ToInt32(reader["idUser"]),
                    };
                    ListaFornecedores.Add(item);
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
            if (ListaFornecedores.Count > 0)
            {
                return ListaFornecedores;
            }
            else
            {
                return ListaFornecedores;
            }
        }

        public Fornecedores buscar(string str)
        {
            Fornecedores item = new Fornecedores();

            ctrlCidades CtrlCidade = new ctrlCidades();

            string oSql = "SELECT * FROM Fornecedores WHERE nome = @nome";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@nome", str);
            conn.Open();

            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idForn"]);
                    item.nome = Convert.ToString(reader["nome"]);
                    item.cpfCnpj = Convert.ToString(reader["cpfCnpj"]);
                    item.rg = Convert.ToString(reader["rg"]);
                    item.logr = Convert.ToString(reader["logr"]);
                    item.numero = Convert.ToInt32(reader["num"]);
                    item.natPess = Convert.ToString(reader["natPes"]);
                    item.bairro = Convert.ToString(reader["bairro"]);
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

        public Fornecedores buscar(int cod)
        {
            Fornecedores item = new Fornecedores();

            ctrlCidades CtrlCidade = new ctrlCidades(); ;

            string oSql = "SELECT * FROM Fornecedores WHERE idForn= @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", cod);
            conn.Open();

            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idForn"]);
                    item.nome = Convert.ToString(reader["nome"]);
                    item.cpfCnpj = Convert.ToString(reader["cpfCnpj"]);
                    item.rg = Convert.ToString(reader["rg"]);
                    item.logr = Convert.ToString(reader["logr"]);
                    item.numero = Convert.ToInt32(reader["num"]);
                    item.natPess = Convert.ToString(reader["natPes"]);
                    item.bairro = Convert.ToString(reader["bairro"]);
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
