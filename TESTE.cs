using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Telas_Pim
{
    public partial class TESTE : Form
    {
        public TESTE()
        {
            InitializeComponent();
           
        }
        
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EDUVD76\SQLEXPRESS;Initial Catalog=HT;Integrated Security=True");
            // conn.Open();
            SqlCommand conn = new SqlCommand();
            conn.Connection = Banco.AbrirConexao();

            SqlCommand cmd1 = new SqlCommand("insert into RL_Receita(CPF_Cliente,Descricao,Valor,Data_Recebida)values(@cpf,@descricao,@valor,@data)", conn.Connection) ;
            try
            {
                string cpfSemMascara = System.Text.RegularExpressions.Regex.Replace(tb_CPF.Text, "[^0-9]+", "");

                SqlCommand cmd = new SqlCommand("insert into consumos (Nome,CPF,Descricao,Valor_Produto,Valor_Total,Quantidade,Data_Consumo)values(@nome,@cpf,@descricao,@valorProduto,@valor,@qtd,@data)", conn.Connection);
                cmd.Parameters.AddWithValue("nome", tb_Nome.Text);                 
                cmd.Parameters.AddWithValue("cpf", cpfSemMascara);
                cmd.Parameters.AddWithValue("descricao", cb_Discricao.Text);
                cmd.Parameters.AddWithValue("data", DateTime.Now);
                if (tb_Quantidade.Value == 0)
                {
                    MessageBox.Show("Atenção!! Informar a quantidade do produto");
                    return;
                }
                else
                {
                    var qtd = tb_Quantidade.Value;
                    var valor = int.Parse(tb_Valor.Text);
                    var total = valor * qtd;
                    cmd.Parameters.AddWithValue("valorProduto", tb_Valor.Text);
                    cmd.Parameters.AddWithValue("valor", total);
                    cmd.Parameters.AddWithValue("qtd", tb_Quantidade.Text);

                }
                cmd.ExecuteNonQuery();
                
               
                 

                //if (cb_Discricao.Text == "Serviço de Quarto"|| cb_Discricao.Text == "Serviço de Lavanderia" || cb_Discricao.Text == "Toalhas")
                //{
                //    MessageBox.Show("Serviços");
                //}
               //else {
                    SqlCommand cmd2 = new SqlCommand("insert into RL_Consumos (Nome, CPF, Descricao, Valor_Produto, Valor_Total, Quantidade,Data_Consumo)values(@nome, @cpf, @descricao, @valorProduto, @valor, @qtd,@data)", conn.Connection);
                    cmd2.Parameters.AddWithValue("nome", tb_Nome.Text);
                    cmd2.Parameters.AddWithValue("data", DateTime.Now);
                    cmd2.Parameters.AddWithValue("cpf", cpfSemMascara);
                    cmd2.Parameters.AddWithValue("descricao", cb_Discricao.Text);
                    if (tb_Quantidade.Value == 0)
                    {
                        MessageBox.Show("Atenção!! Informar a quantidade do produto");
                        return;
                    }
                    else
                    {
                        var qtd = tb_Quantidade.Value;
                        var valor = int.Parse(tb_Valor.Text);
                        var total = valor * qtd;
                        cmd2.Parameters.AddWithValue("valorProduto", tb_Valor.Text);
                        cmd2.Parameters.AddWithValue("valor", total);
                        cmd2.Parameters.AddWithValue("qtd", tb_Quantidade.Text);
                        cmd1.Parameters.AddWithValue("@valor", total);
                    }                
                    
                //}
               
               // string discricao1 = "Diarias";
                cmd1.Parameters.AddWithValue("@cpf", cpfSemMascara);
                cmd1.Parameters.AddWithValue("@descricao", cb_Discricao.Text);
                //cmd1.Parameters.AddWithValue("@valor", tb_Valor.Text);
                cmd1.Parameters.AddWithValue("@data", DateTime.Now);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                MessageBox.Show("CONSUMOS INSERIDOS COM SUCESSO!!");
                tb_Nome.Clear();
                tb_CPF.Clear();
                cb_Discricao.SelectedIndex=-1;
                tb_Valor.Clear();     
                tb_CPFbusca.Clear();
                tb_Quantidade.Value = 0;
                tb_CPFbusca.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);

            }
            finally
            {
                conn.Connection.Close();
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EDUVD76\SQLEXPRESS;Initial Catalog=HT;Integrated Security=True");
            SqlCommand conn = new SqlCommand();
            conn.Connection = Banco.AbrirConexao();
            string cpfSemMascara = System.Text.RegularExpressions.Regex.Replace(tb_CPFbusca.Text, "[^0-9]+", "");

           // string cm = "select *from  Entradas where CPF= '" + tb_CPFbusca.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter("select *from  Entradas where CPF= '" + cpfSemMascara + "'", conn.Connection);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("CPF INFORMADO NÃO POSSUI REGISTRO DE ENTRADAS NO HOTEL");
                tb_Nome.Clear();
                tb_CPF.Clear();
                cb_Discricao.SelectedIndex=-1;
                tb_Valor.Clear();
              
                tb_CPFbusca.Clear();
                tb_CPFbusca.Focus();
                conn.Connection.Close();
                return;
            }

            else
            {
                conn.Connection.Close();
                try
                {
                    conn.Connection.Open();
                    SqlCommand cmd = new SqlCommand("select *from Entradas where CPF=@cpf", conn.Connection);
                    cmd.Parameters.AddWithValue("@cpf", cpfSemMascara);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    tb_Nome.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    tb_CPF.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();


                }


                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);

                }
                finally
                {
                    conn.Connection.Close();
                }
            }
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            ///SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EDUVD76\SQLEXPRESS;Initial Catalog=HT;Integrated Security=True");
            //conn.Open();
            SqlCommand conn = new SqlCommand();
            conn.Connection = Banco.AbrirConexao();

            SqlCommand cmd = new SqlCommand("insert into RL_Compras (Descricao, Valor_Custo, Valor_Venda, Quantidade,Data_Compra)values(@descricao, @valorCusto, @valorVenda, @qtd,@data)", conn.Connection);
            try
            {
                cmd.Parameters.AddWithValue("descricao", cb_DiscricaoCompras.Text);
                cmd.Parameters.AddWithValue("data", DateTime.Now);
                            
                if (tb_QtdCompras.Value == 0)
                {
                    MessageBox.Show("Atenção!! Informar a quantidade do produto");
                    return;
                }
                else
                {  //var mult=0.10;
                    var qtd = tb_Quantidade.Value;
                    var valor = double.Parse(tb_ValorCusto.Text);
                    var total = valor * 0.30;
                      double final = total + valor;
                    cmd.Parameters.AddWithValue("valorCusto", tb_ValorCusto.Text);                  
                    cmd.Parameters.AddWithValue("valorVenda", final);
                    cmd.Parameters.AddWithValue("qtd", tb_QtdCompras.Text);
                }
                cmd.ExecuteNonQuery();
                          
                MessageBox.Show("CONSUMOS INSERIDOS COM SUCESSO!!");
                tb_QtdCompras.Value = 0;
                tb_ValorCusto.Clear();
                cb_DiscricaoCompras.SelectedIndex = -1;           
                cb_DiscricaoCompras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);

            }
            finally
            {
                conn.Connection.Close();
            }
        }
    }
}
