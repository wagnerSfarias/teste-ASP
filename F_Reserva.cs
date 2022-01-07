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
    public partial class F_Reserva : Form
    {
        public F_Reserva()
        {
            InitializeComponent();
            tb_CPFbusca.Select();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

            // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EDUVD76\SQLEXPRESS;Initial Catalog=HT;Integrated Security=True");
            // conn.Open();
            SqlCommand conn = new SqlCommand();
            conn.Connection = Banco.AbrirConexao();
            string cpfSemMascara = System.Text.RegularExpressions.Regex.Replace(tb_CPFbusca.Text, "[^0-9]+", "");

            string cpfSemMascara1 = System.Text.RegularExpressions.Regex.Replace(tb_CPF.Text, "[^0-9]+", "");

            SqlCommand cm = new SqlCommand("select* from Reservas where CPF = @cpf", conn.Connection);
            cm.Parameters.AddWithValue("@cpf", cpfSemMascara);

            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("HOSPEDE INFORMADO JÁ POSSUI RESERVA");
                tb_Nome.Clear();
                tb_CPFbusca.Clear();
                tb_CPF.Clear();
                tb_Celular.Clear();
                tb_CPFbusca.Focus();
                conn.Connection.Close();
                return;
            }
            else
            {
                reader.Close();
                conn.Connection.Close();
                try
                {
                    conn.Connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into Reservas (Nome,CPF,Celular,Tipo_Quarto,Data_Check_IN,Data_Check_OUT)" +
                        "values(@nome,@cpf,@celular,@tipoQuarto,@datacheckin,@datacheckout)", conn.Connection);

                    string celSemMascara = System.Text.RegularExpressions.Regex.Replace(tb_Celular.Text, "[^0-9]+", "");

                    VerificarTxt teste = new VerificarTxt();

                    if (teste.txtVazio(tb_Nome, "Nome"))
                        return;
                    else
                    {
                        cmd.Parameters.AddWithValue("@nome", tb_Nome.Text);
                    }

                    if (cpfSemMascara1 != String.Empty)
                    {

                        cmd.Parameters.AddWithValue("@cpf", cpfSemMascara1);
                    }
                    else
                    {
                        MessageBox.Show("O campo CPF é obrigatório!");
                        tb_CPF.Focus();
                        return;
                    }

                    if (celSemMascara != String.Empty)
                    {
                        cmd.Parameters.AddWithValue("@celular", celSemMascara);
                    }
                    else
                    {
                        MessageBox.Show("O campo Celular é obrigatório!");
                        tb_Celular.Focus();
                        return;
                    }

                    if (teste.txtVazio(cb_TipoQuarto, "TIPO DE QUARTO"))

                        return;
                    else
                    {
                        cmd.Parameters.AddWithValue("@tipoQuarto", cb_TipoQuarto.Text);
                    }

                    if (dt_Checkin.Value >= DateTime.Today)
                    {
                        cmd.Parameters.AddWithValue("@datacheckin", dt_Checkin.Value);
                    }
                    else
                    {
                        MessageBox.Show("DATA DE CHECK-IN INVÁLIDA");
                        //   "Não é permitido utilizar uma data inferior do que a data atual");
                        dt_Checkin.Focus();
                        return;
                    }

                    if (dt_Checkout.Value >= DateTime.Today)
                    {
                        cmd.Parameters.AddWithValue("@datacheckout", dt_Checkout.Value);
                    }
                    else
                    {
                        MessageBox.Show("DATA DE CHECK-OUT INVÁLIDA");
                        dt_Checkout.Focus();
                        return;
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("ENTRADA REGISTADA COM SUCESSO");
                    tb_Nome.Clear();
                    tb_CPF.Clear();
                    tb_Celular.Clear();
                    cb_TipoQuarto.SelectedIndex = -1;
                    dt_Checkin.Value = DateTime.Now;
                    dt_Checkout.Value = DateTime.Now;
                    tb_CPFbusca.Clear();
                    tb_CPFbusca.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    throw;
                }
                finally
                {
                    conn.Connection.Close();
                }
            }      
            }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EDUVD76\SQLEXPRESS;Initial Catalog=HT;Integrated Security=True");
            SqlCommand conn = new SqlCommand();
            conn.Connection = Banco.AbrirConexao();
            string cpfSemMascara = System.Text.RegularExpressions.Regex.Replace(tb_CPFbusca.Text, "[^0-9]+", "");

           // string cm = "select *from  Hospedes where CPF= '" + cpfSemMascara+ "'";
            SqlDataAdapter dp = new SqlDataAdapter("select *from  Hospedes where CPF= '" + cpfSemMascara + "'", conn.Connection);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("CPF INFORMADO NÃO POSSUI REGISTRO NO HOTEL");
                tb_Nome.Clear();
                tb_CPF.Clear();
                tb_Celular.Clear();
                cb_TipoQuarto.SelectedIndex = -1;
                dt_Checkin.Value = DateTime.Now;
                dt_Checkout.Value = DateTime.Now;
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
                    SqlCommand cmd = new SqlCommand("select *from Hospedes where CPF=@cpf", conn.Connection);
                    cmd.Parameters.AddWithValue("@cpf", cpfSemMascara);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    tb_Nome.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    tb_CPF.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    tb_Celular.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();           
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
}

