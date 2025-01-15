using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Econtact
{
    class DBAccess
    {
        private static SqlConnection con = new SqlConnection();
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataReader reader;
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        public SqlTransaction trans;

        private static String strcon = "Data Source=Zufar-Desktop\\ZUFARSQLSERVER;Initial Catalog=Econtact;Integrated Security=True;Trust Server Certificate=True";

        public void createCon()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.ConnectionString = strcon;
                    con.Open();
                }
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public void closedCon()
        {
            con.Close();
        }

        public int executeDataAdapter(DataTable table, String strSelectSql)
        {
            try
            {
                if(con.State == 0)
                {
                    createCon();
                }

                adapter.SelectCommand.CommandText = strSelectSql;
                adapter.SelectCommand.CommandType = System.Data.CommandType.Text;
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                String insert = commandBuilder.GetInsertCommand().CommandText.ToString();
                String update = commandBuilder.GetUpdateCommand().CommandText.ToString();
                String delet = commandBuilder.GetDeleteCommand().CommandText.ToString();

                return adapter.Update(table);
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public void readDataThroughAdapter(String query, DataTable table)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    createCon();
                }

                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex) { throw ex; }
        }

        public SqlDataReader readDataThroughReader(String query)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    createCon();
                }

                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex) { throw ex; }
        }

        public int executeQuery(SqlCommand dbcommand)
        {
            try
            {
                if (con.State == 0)
                {
                    createCon();
                }

                dbcommand.Connection = con;
                dbcommand.CommandType = CommandType.Text;

                return dbcommand.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
