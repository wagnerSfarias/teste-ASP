using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas_Pim
{
    public class Banco
    {
       
        public static SqlConnection AbrirConexao()
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.103,1433; Network Library=DBMSSOCN; Initial Catalog=HT; User ID = sa; Password =brow102030 ;");
            //Banco VM
            //string conectar=@"Data Source=192.168.0.102,1433; Network Library=DBMSSOCN; Initial Catalog=RRSolucoesHotel; User ID = sa; Password =sa102030;";

            //Banco Online
           // string conectar =@"Data Source=BDRRSolucoesHotel.mssql.somee.com,1433; Network Library=DBMSSOCN; Initial Catalog=BDRRSolucoesHotel; User ID = RRSolucoes_SQLLogin_1; Password =2hjq1wkela;";
            
            //Banco Local
            string conectar = @"Data Source=DESKTOP-EDUVD76\SQLEXPRESS;Initial Catalog=HOTEL01;Integrated Security=True";
            // string conectar = @"Data Source=DESKTOP-EDUVD76\SQLEXPRESS; Network Library=DBMSSOCN; Initial Catalog=HT; User ID = sa; Password =brow102030 ;";
            SqlConnection conn = new SqlConnection(conectar);
            conn.Open();
            return conn;
        }
        public void FecharConexao()
        {
            //conn.Close();
        }
    }
}
