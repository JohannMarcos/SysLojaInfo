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
    internal class daoProdutos : dao
    {
        private MySqlConnection conn;
        public daoProdutos()
        {
            conn = new Conexao().GetConnection();
        }

        public override void salvar(object obj)
        {
            Produtos oProduto = (Produtos)obj;
            string oSql = @"insert into Produtos (prod, custo, custoMedio, precoVenda, estoque, fk_uMedida, datCad, datAlt, idUser) 
                            values (@produto, @custo, @custoMedio, @pv, @estoque, @fkmedida, @datCad, @datUltAlt, @id_user)";
            oProduto.DatCad = DateTime.Now;
            oProduto.DatUltAlt = DateTime.Now;
            oProduto.QuemAlter = 0;
            oProduto.custo = 0;
            oProduto.custoMedio = 0;
            oProduto.precoVenda = 0;
            oProduto.estoque = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@produto", oProduto.produto);
                execCmd.Parameters.AddWithValue("@custo", oProduto.custo);
                execCmd.Parameters.AddWithValue("@custoMedio", oProduto.custoMedio);
                execCmd.Parameters.AddWithValue("@pv", oProduto.precoVenda);
                execCmd.Parameters.AddWithValue("@estoque", oProduto.estoque);
                execCmd.Parameters.AddWithValue("@fkMedida", oProduto.aMedida.uMedida);
                execCmd.Parameters.AddWithValue("datCad", oProduto.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", oProduto.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oProduto.QuemAlter);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Produto:" + ex.Message);
            }
        }
        public override void editar(object obj)
        {
            Produtos oProduto = (Produtos)obj;
            string oSql = @"update Produtos set prod = @prod, precovenda = @pv, fk_uMedida = @fkmedida, datAlt =  @datAlt, 
                            idUser = @idUsu where idProduto =  @Cod";
            oProduto.DatUltAlt = DateTime.Now;
            oProduto.QuemAlter = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@prod", oProduto.produto);
                execCmd.Parameters.AddWithValue("@pv", oProduto.precoVenda);
                execCmd.Parameters.AddWithValue("@fkmedida", oProduto.aMedida.uMedida);
                execCmd.Parameters.AddWithValue("@datAlt", oProduto.DatUltAlt);
                execCmd.Parameters.AddWithValue("@idUsu", oProduto.QuemAlter);
                execCmd.Parameters.AddWithValue("@Cod", oProduto.Codigo);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Produto Alterado com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar o Produto:" + ex.Message);


            }

        }

        public override void deletar(object obj)
        {
            Produtos oProduto = (Produtos)obj;
            string oSql = @"delete from Produtos where idproduto =  @Cod";

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);

                execCmd.Parameters.AddWithValue("@Cod", oProduto.Codigo);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Produto Excluido com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir o Produto:" + ex.Message);
            }
        }

        public List<Produtos> SelecionaDS()
        {
            string sql = "SELECT * FROM Produtos";
            List<Produtos> ListaProdutos = new List<Produtos>();

            ctrlMedidas CtrlMedida = new ctrlMedidas();

            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Produtos item = new Produtos()
                    {
                        Codigo = Convert.ToInt32(reader["idproduto"]),
                        produto = Convert.ToString(reader["prod"]),
                        custo = Convert.ToDouble(reader["custo"]),
                        custoMedio = Convert.ToDouble(reader["custoMedio"]),
                        precoVenda = Convert.ToDouble(reader["precoVenda"]),
                        estoque = Convert.ToInt32(reader["estoque"]),
                        aMedida = CtrlMedida.buscarAbr(Convert.ToString(reader["fk_uMedida"])),
                        DatCad = Convert.ToDateTime(reader["datCad"]),
                        DatUltAlt = Convert.ToDateTime(reader["datAlt"]),
                        QuemAlter = Convert.ToInt32(reader["idUser"])
                    };
                    ListaProdutos.Add(item);
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
            if (ListaProdutos.Count > 0)
            {
                return ListaProdutos;
            }
            else
            {
                return ListaProdutos;
            }
        }

        public Produtos buscar(string str)
        {
            Produtos item = new Produtos();

            ctrlMedidas CtrlMedida = new ctrlMedidas();

            string oSql = "SELECT * FROM produtos WHERE prod = @prod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@prod", str);

            try
            {
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idproduto"]);
                    item.produto = Convert.ToString(reader["prod"]);
                    item.custo = Convert.ToDouble(reader["custo"]);
                    item.custoMedio = Convert.ToDouble(reader["custoMedio"]);
                    item.precoVenda = Convert.ToDouble(reader["precoVenda"]);
                    item.estoque = Convert.ToInt32(reader["estoque"]);
                    item.aMedida = CtrlMedida.buscarAbr(Convert.ToString(reader["fk_uMedida"]));
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

        public Produtos buscar(int cod)
        {
            Produtos item = new Produtos();

            ctrlMedidas CtrlMedida = new ctrlMedidas();

            string oSql = "SELECT * FROM produtos WHERE idproduto= @cod";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@cod", cod);

            try
            {
                conn.Open();
                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    item.Codigo = Convert.ToInt32(reader["idproduto"]);
                    item.produto = Convert.ToString(reader["prod"]);
                    item.custo = Convert.ToDouble(reader["custo"]);
                    item.custoMedio = Convert.ToDouble(reader["custoMedio"]);
                    item.precoVenda = Convert.ToDouble(reader["precoVenda"]);
                    item.estoque = Convert.ToInt32(reader["estoque"]);
                    item.aMedida = CtrlMedida.buscarAbr(Convert.ToString(reader["fk_uMedida"]));
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
