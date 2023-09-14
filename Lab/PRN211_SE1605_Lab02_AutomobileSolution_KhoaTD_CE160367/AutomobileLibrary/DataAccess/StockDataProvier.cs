using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class StockDataProvier {
                public StockDataProvier() { }
        private String ConnectionString { get; set; }
        public StockDataProvier(String connectionString) => ConnectionString = connectionString;
        public void CloseConnection(SqlConnection connection) { }

        public SqlParameter CreateParameter(string name, int size, object value, DbType dbType,
            ParameterDirection direction = ParameterDirection.Input)
        {
            return new SqlParameter
            {
                DbType = dbType,
                ParameterName = name,
                Size = size,
                Value = value,
                Direction = direction

            };
        }

        public IDataReader GetDataReader(string commandText, CommandType commandType,
            out SqlConnection connection, params SqlParameter[] parameters) {
            IDataReader reader = null;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return reader;
        }

        public void Delete(string commandText, CommandType commandType
            , params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Data Provider: Delete Method", e.InnerException);
            }
        }


        public void Insert(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try 
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText,connection);
                command.CommandType = commandType;
                if (parameters != null )
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(string commandText, CommandType commandType,
            params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText,connection);
                command.CommandType = commandType;
                if (parameters != null )
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(
                            parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    } 

    
    
}
