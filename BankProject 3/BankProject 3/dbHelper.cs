using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BankProject_3
{
   public class dbHelper //jeva ya class cha object tayae hoil teva dbHelper call zala pahije
    {
       // con and cmd he don object create kele
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();


        public dbHelper() // default Constructor Create kela //when we create object of class that tome constructor get called
        {
            con.ConnectionString = "Data Source=Localhost;Initial Catalog=Bank20_bak;Integrated Security=True";
            con.Open();
            cmd.Connection = con; // ha constructor call zalyavr yeka line madhe database ch connection houn jail.
        }

        /// <summary>
        /// use only for DML Opearation
        /// </summary>
        /// <param name="sql">pass insert or update or delete sql statement</param>
        /// <returns></returns>
        public int DoUpdate(string sql) //string sql use kel karan karan cmd.CommandText he fuction update,insert,delete as kontyahi operation sathi use krnar tymule jokoni he fuction call krnar tya fuction la baherun statement/sql query pass karav lagnar 
        {
            try
            {
                cmd.CommandText = sql; //frmCustomer madhe ji insert query lihili ahe ti pass keli CommandText la
                return cmd.ExecuteNonQuery(); //return lihil karn executenonquery kahitari pathimage pathvt
            }
            catch (Exception )
            {
                
                return -1; 
            }
            
        }
        // <summary>
        /// Use this fuc to hold select query result in DataSet
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string SQL) //DataSet la query pass keli
        {
            cmd.CommandText = SQL;
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            dt.Fill(ds);

            return ds;
        }

        /// <summary>
        /// Use to get data reader
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public SqlDataReader GetDataReader(string SQL) 
        {
            cmd.CommandText = SQL;
            
            return cmd.ExecuteReader(); //je kahi bhetel te ExecuteReader chya help ne ghenar aani return karnar
        }
        public void CloseConnection() //Connection close krnyasathi use kel
        {
            con.Close();
        }
    }
}
