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
    internal class daoFuncionarios : dao
    {

        private MySqlConnection conn;
        public daoFuncionarios()
        {
            conn = new Conexao().GetConnection();
        }

        public override void salvar(object obj)
        {
            Funcionarios oFuncionario = (Funcionarios)obj;
            string oSql = @"insert into Funcionarios (nome, cpfCnpj, rg, cnh, logr, num, natPes, bairro, fk_cargos, fk_cidade,
                            telres, telcel, email, datCad, datAlt, idUser) values (@nome, @cpfCnpj, @rg, @CNH, @logr, 
                            @num, @nat, @bairro, @fkcargo, @fkCidade, @telRes, @telcel, @em, @datCad, @datUltAlt, @id_user)";
            oFuncionario.DatCad = DateTime.Now;
            oFuncionario.DatUltAlt = DateTime.Now;
            oFuncionario.QuemAlter = 0;

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@nome", oFuncionario.nome);
                execCmd.Parameters.AddWithValue("@cpfCnpj", oFuncionario.cpfCnpj);
                execCmd.Parameters.AddWithValue("@rg", oFuncionario.rg);
                execCmd.Parameters.AddWithValue("@CNH", oFuncionario.cnh);
                execCmd.Parameters.AddWithValue("@logr", oFuncionario.logr);
                execCmd.Parameters.AddWithValue("@num", oFuncionario.numero);
                execCmd.Parameters.AddWithValue("@nat", oFuncionario.natPess);
                execCmd.Parameters.AddWithValue("@bairro", oFuncionario.bairro);
                execCmd.Parameters.AddWithValue("@fkcargo", oFuncionario.oCargo.Codigo);
                execCmd.Parameters.AddWithValue("@fkCidade", oFuncionario.aCidade.Codigo);
                execCmd.Parameters.AddWithValue("@telRes", oFuncionario.telRes);
                execCmd.Parameters.AddWithValue("@telCel", oFuncionario.telCel);
                execCmd.Parameters.AddWithValue("@em", oFuncionario.email);
                execCmd.Parameters.AddWithValue("datCad", oFuncionario.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", oFuncionario.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oFuncionario.QuemAlter);

                execCmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario Cadastrado com Sucesso");
                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao cadastrar o Funcionario" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public override void editar(object obj)
        {
            Funcionarios oFuncionario = (Funcionarios)obj;
            string oSql = @"update Funcionarios SET nome = @nome, cpfCnpj = @cpfCnpj, rg = @rg, cnh = @CNH, logr = @logr, num = @num,
                            natPes = @nat, bairro = @bairro, fk_cargos = @fkcargo, fk_cidade = @fkCidade, telres = @telRes,
                            telcel = @telcel, email = @em, datAlt = @datUltAlt, idUser = @id_user where idFunc =  @Cod";
            oFuncionario.DatUltAlt = DateTime.Now;
            oFuncionario.QuemAlter = 0;

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@nome", oFuncionario.nome);
                execCmd.Parameters.AddWithValue("@cpfCnpj", oFuncionario.cpfCnpj);
                execCmd.Parameters.AddWithValue("@rg", oFuncionario.rg);
                execCmd.Parameters.AddWithValue("@CNH", oFuncionario.cnh);
                execCmd.Parameters.AddWithValue("@logr", oFuncionario.logr);
                execCmd.Parameters.AddWithValue("@num", oFuncionario.numero);
                execCmd.Parameters.AddWithValue("@nat", oFuncionario.natPess);
                execCmd.Parameters.AddWithValue("@bairro", oFuncionario.bairro);
                execCmd.Parameters.AddWithValue("@fkcargo", oFuncionario.oCargo.Codigo);
                execCmd.Parameters.AddWithValue("@fkCidade", oFuncionario.aCidade.Codigo);
                execCmd.Parameters.AddWithValue("@telRes", oFuncionario.telRes);
                execCmd.Parameters.AddWithValue("@telCel", oFuncionario.telCel);
                execCmd.Parameters.AddWithValue("@em", oFuncionario.email);
                execCmd.Parameters.AddWithValue("@datUltAlt", oFuncionario.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oFuncionario.QuemAlter);

                execCmd.Parameters.AddWithValue("@cod", oFuncionario.Codigo);

                execCmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario Alterado com Sucesso");

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao Alterar o Funcionario:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public override void deletar(object obj)
        {
            Funcionarios oFuncionario = (Funcionarios)obj;
            string oSql = @"delete from Funcionarios where idFunc =  @Cod";

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);

                execCmd.Parameters.AddWithValue("@Cod", oFuncionario.Codigo);

                execCmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario Excluido com Sucesso");

                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao Excluir o Funcionario:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Funcionarios> SelecionaDS()
        {
            string sql = "SELECT * FROM Funcionarios";
            List<Funcionarios> ListaFuncionarios = new List<Funcionarios>();

            ctrlCidades CtrlCidade = new ctrlCidades();

            ctrlCargos ctrlCargos = new ctrlCargos();

            conn.Open();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Funcionarios item = new Funcionarios()
                    {
                        Codigo = Convert.ToInt32(reader["idFunc"]),
                        nome = Convert.ToString(reader["nome"]),
                        cpfCnpj = Convert.ToString(reader["cpfCnpj"]),
                        rg = Convert.ToString(reader["rg"]),
                        cnh = Convert.ToString(reader["cnh"]),
                        logr = Convert.ToString(reader["logr"]),
                        numero = Convert.ToInt32(reader["num"]),
                        natPess = Convert.ToString(reader["natPes"]),
                        bairro = Convert.ToString(reader["bairro"]),
                        oCargo = ctrlCargos.buscar(Convert.ToInt32(reader["fk_cargos"])),
                        aCidade = CtrlCidade.buscar(Convert.ToInt32(reader["fk_cidade"])),
                        telRes = Convert.ToString(reader["telRes"]),
                        telCel = Convert.ToString(reader["telCel"]),
                        email = Convert.ToString(reader["email"]),
                        DatCad = Convert.ToDateTime(reader["datCad"]),
                        DatUltAlt = Convert.ToDateTime(reader["datAlt"]),
                        QuemAlter = Convert.ToInt32(reader["idUser"]),
                    };
                    ListaFuncionarios.Add(item);
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
            if (ListaFuncionarios.Count > 0)
            {
                return ListaFuncionarios;
            }
            else
            {
                return ListaFuncionarios;
            }
        }

        public Funcionarios buscar(string str)
        {
            Funcionarios item = new Funcionarios();

            ctrlCidades CtrlCidade = new ctrlCidades();

            ctrlCargos ctrlCargos = new ctrlCargos();

            string oSql = "SELECT * FROM Funcionarios WHERE nome = @nome";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@nome", str);
            conn.Open();

            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idFunc"]);
                    item.nome = Convert.ToString(reader["nome"]);
                    item.cpfCnpj = Convert.ToString(reader["cpfCnpj"]);
                    item.rg = Convert.ToString(reader["rg"]);
                    item.cnh = Convert.ToString(reader["cnh"]);
                    item.logr = Convert.ToString(reader["logr"]);
                    item.numero = Convert.ToInt32(reader["num"]);
                    item.natPess = Convert.ToString(reader["natPes"]);
                    item.bairro = Convert.ToString(reader["bairro"]);
                    item.oCargo = ctrlCargos.buscar(Convert.ToInt32(reader["fk_cargos"]));
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

        public Funcionarios buscar(int cod)
        {
            Funcionarios item = new Funcionarios();

            ctrlCidades CtrlCidade = new ctrlCidades();

            ctrlCargos ctrlCargos = new ctrlCargos();

            string oSql = "SELECT * FROM Funcionarios WHERE idFunc = @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", cod);
            conn.Open();

            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idFunc"]);
                    item.nome = Convert.ToString(reader["nome"]);
                    item.cpfCnpj = Convert.ToString(reader["cpfCnpj"]);
                    item.rg = Convert.ToString(reader["rg"]);
                    item.cnh = Convert.ToString(reader["cnh"]);
                    item.logr = Convert.ToString(reader["logr"]);
                    item.numero = Convert.ToInt32(reader["num"]);
                    item.natPess = Convert.ToString(reader["natPes"]);
                    item.bairro = Convert.ToString(reader["bairro"]);
                    item.oCargo = ctrlCargos.buscar(Convert.ToInt32(reader["fk_cargos"]));
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
