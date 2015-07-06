using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class IpsoaDataAdapter
    {
        private static void SetConnection(string pathFileName, System.Data.OleDb.OleDbConnection connection)
        {
            try
            {
                if (connection != null)
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                        connection.Close();

                    var connectionString = connection.ConnectionString;
                    var builder = new System.Data.OleDb.OleDbConnectionStringBuilder(connectionString);
                    builder.DataSource = pathFileName;
                    connection.ConnectionString = builder.ConnectionString;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        public static DataSetIpsoaTableAdapters.NominativiTableAdapter GetDataAdapterNominativi(string pathFileName)
        {
            try
            {
                var adapter = new DataSetIpsoaTableAdapters.NominativiTableAdapter();
                var connection = adapter.Connection;
                SetConnection(pathFileName, connection);
                return adapter;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static DataSetIpsoaTableAdapters.NClientiTableAdapter GetDataAdapterClienti(string pathFileName)
        {
            try
            {
                var adapter = new DataSetIpsoaTableAdapters.NClientiTableAdapter();
                var connection = adapter.Connection;
                SetConnection(pathFileName, connection);
                return adapter;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        

        
    }
}
