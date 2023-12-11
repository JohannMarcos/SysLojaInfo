using MySql.Data.MySqlClient;
using SysLojaInfo.Classes;
using SysLojaInfo.Ctrls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Daos
{
    internal class daoCompras:dao
    {
        private MySqlConnection conn;
        public daoCompras()
        {
            conn = new Conexao().GetConnection();
        }
        public override void salvar(object obj)
        {
            Compra aCompra = (Compra)obj;
            string oSql = @"insert into NotaEntrada (nNota, serieNota, modeloNota, cod_emit, dtEmissao, dtChegada, vItensBruto, vDescItens, vFrete, vSeguro, vOutros, vTotalNota, 
                            datCad, datAlt, idUser) values (@nNota, @serieNota, @modeloNota, @cod_emit, @dtEmissao, @dtChegada, @vItens, @vDesc, @vFrete, @vSeguro, @vOutros, @vTotal,
                            @datCad, @datUltAlt, @id_user)";
            aCompra.DatCad = DateTime.Now;
            aCompra.DatUltAlt = DateTime.Now;
            aCompra.QuemAlter = 0;

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@nNota", aCompra.nNota);
                execCmd.Parameters.AddWithValue("@serieNota", aCompra.SerieNota);
                execCmd.Parameters.AddWithValue("@modeloNota", aCompra.ModeloNota);
                execCmd.Parameters.AddWithValue("@cod_emit", aCompra.oFornecedor.Codigo);
                execCmd.Parameters.AddWithValue("@dtEmissao", aCompra.dtEmissao);
                execCmd.Parameters.AddWithValue("@dtChegada", aCompra.dtChegada);
                execCmd.Parameters.AddWithValue("@vItens", aCompra.valorBrutoItens);
                execCmd.Parameters.AddWithValue("@vDesc", aCompra.DescTotalItens);
                execCmd.Parameters.AddWithValue("@vFrete", aCompra.valorFrete);
                execCmd.Parameters.AddWithValue("@vSeguro", aCompra.valorSeguro);
                execCmd.Parameters.AddWithValue("@vOutros", aCompra.ValorOutros);
                execCmd.Parameters.AddWithValue("@vTotal", aCompra.totalNota);
                execCmd.Parameters.AddWithValue("datCad", aCompra.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", aCompra.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", aCompra.QuemAlter);

                execCmd.ExecuteNonQuery();


                foreach (itemsCompras item in aCompra.itemsNota)
                {
                    double mRat = ((item.precoUnit - item.descUnit)*item.qtd)* (100/(aCompra.valorBrutoItens - aCompra.DescTotalItens));



                    oSql = @"insert into ItensNotaEntrada (nNota, serieNota, modeloNota, cod_Emit, cod_produto, precoUnit, descUnit, descPercent, qtd, totalProd) values (@nNota, @serieNota, 
                         @modeloNota, @cod_emit, @codProd, @preco, @vDesc, @DescP, @qtd, @total)";

                    execCmd = new MySqlCommand(oSql, conn);

                    execCmd.Parameters.AddWithValue("@nNota", aCompra.nNota);
                    execCmd.Parameters.AddWithValue("@serieNota", aCompra.SerieNota);
                    execCmd.Parameters.AddWithValue("@modeloNota", aCompra.ModeloNota);
                    execCmd.Parameters.AddWithValue("@cod_emit", aCompra.oFornecedor.Codigo);
                    execCmd.Parameters.AddWithValue("@codProd", item.oProduto.Codigo);
                    execCmd.Parameters.AddWithValue("@preco", item.precoUnit); 
                    execCmd.Parameters.AddWithValue("@vDesc", item.descUnit);
                    execCmd.Parameters.AddWithValue("@DescP", item.descPercent);
                    execCmd.Parameters.AddWithValue("@qtd", item.qtd);
                    execCmd.Parameters.AddWithValue("@total", item.totalProd);

                    execCmd.ExecuteNonQuery();

                    ctrlProdutos aCtrlProd = new ctrlProdutos();

                    Produtos mProd = aCtrlProd.buscar(item.oProduto.Codigo);

                    double mCustoToProd = (item.precoUnit - item.descUnit) + (((mRat / 100) * (aCompra.valorFrete + aCompra.ValorOutros + aCompra.valorSeguro))/item.qtd);

                    double mCustoProd = mCustoToProd;

                    if (mProd.estoque != 0)
                    {
                        mCustoProd = ((mProd.estoque * mProd.custo) + (item.qtd * mCustoToProd)) / (mProd.estoque + item.qtd);
                    }

                    oSql = @"Update produtos set estoque = @qtd, custo = @pCusto, custoMedio = @custoM where idProduto = @idProd";

                    execCmd = new MySqlCommand(oSql, conn);

                    execCmd.Parameters.AddWithValue("@qtd", item.qtd + mProd.estoque);
                    execCmd.Parameters.AddWithValue("@pCusto", mCustoToProd);
                    execCmd.Parameters.AddWithValue("@custoM", mCustoProd);
                    execCmd.Parameters.AddWithValue("@idProd", mProd.Codigo);

                    execCmd.ExecuteNonQuery();

                }
                MessageBox.Show("Lançamento de nota realizado com Sucesso");
                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao realizar o lançamento:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public bool ValidaChaveNota(object obj)
        {
            bool condicao = false;

            Compra aCompra = (Compra)obj;   

            string oSql = @"SELECT nNota, serieNota, modeloNota, cod_Emit  from NotaEntrada WHERE  nNota = @nota and serieNota = @serie 
                            and modeloNota = @modelo and cod_Emit = @Emit";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.Parameters.AddWithValue("@nota", aCompra.nNota);
            execCmd.Parameters.AddWithValue("@serie", aCompra.SerieNota);
            execCmd.Parameters.AddWithValue("@modelo", aCompra.ModeloNota);
            execCmd.Parameters.AddWithValue("@emit", aCompra.oFornecedor.Codigo);
            conn.Open();

            try
            {

                MySqlDataReader reader = execCmd.ExecuteReader();
                if (reader.Read())
                {
                    condicao = true;
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

            return condicao;
        }

        public List<Compra> SelecionaDS()
        {
            string sql = "SELECT * FROM NotaEntrada";
            List<Compra> ListaCompra = new List<Compra>();

            ctrlFornecedores aCtrlFornecedor = new ctrlFornecedores();

            conn.Open();
            try
            {
                MySqlCommand execCmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = execCmd.ExecuteReader();
                while (reader.Read())
                {
                    Compra item = new Compra()
                    {
                        nNota = Convert.ToInt32(reader["nNota"]),
                        SerieNota = Convert.ToString(reader["SerieNota"]),
                        ModeloNota = Convert.ToString(reader["modeloNota"]),
                        oFornecedor = aCtrlFornecedor.buscar(Convert.ToInt32(reader["cod_Emit"])),
                        dtEmissao = Convert.ToDateTime(reader["dtEmissao"]),
                        dtChegada = Convert.ToDateTime(reader["dtChegada"]),
                        totalNota = Convert.ToDouble(reader["vTotalNota"]),
                    };
                    ListaCompra.Add(item);
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
            if (ListaCompra.Count > 0)
            {
                return ListaCompra;
            }
            else
            {
                return ListaCompra;
            }
        }
    }
}
