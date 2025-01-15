using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Database_Project
{
    class DBAccess
    {
        private static SqlConnection conn = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataReader reader;
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        public SqlTransaction trans;

        private static String strcon = "Data Source=Zufar-Desktop\\ZUFARSQLSERVER;Initial Catalog=DatabaseProject;Integrated Security=True;Trust Server Certificate=True";

        public void createCon()
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.ConnectionString = strcon;
                    conn.Open();
                }
            } catch(Exception e)
            {
                throw e;
            }
        }

        public void closeCon()
        {
            conn.Close();
        }

        public int executeDataAdapter(DataTable table, String strSelectSql)
        {
            try{
                if(conn.State == 0)
                {
                    createCon();
                }

                adapter.SelectCommand.CommandText = strSelectSql;
                adapter.SelectCommand.CommandType = CommandType.Text;
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                String insert = commandBuilder.GetInsertCommand().CommandText.ToString();
                String update = commandBuilder.GetUpdateCommand().CommandText.ToString();
                String delete = commandBuilder.GetDeleteCommand().CommandText.ToString();

                return adapter.Update(table);
            } catch(Exception e) { throw e; }
        }
        
        public void readDataThroughAdapter(String query, DataTable table)
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    createCon();
                }

                command.Connection = conn;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            } catch (Exception e) { throw e; }
        }

        public SqlDataReader readDataThroughReader(String query)
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    createCon();
                }

                command.Connection = conn;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                return reader;
            } catch (Exception e) { throw e; }
        }

        public int executeQuery(SqlCommand dbcommand)
        {
            try
            {
                if(conn.State == 0)
                {
                    createCon();
                }

                dbcommand.Connection = conn;
                dbcommand.CommandType = CommandType.Text;

                return dbcommand.ExecuteNonQuery();
            } catch (Exception e)
            {
                throw e;
            }
        }
    }
}
