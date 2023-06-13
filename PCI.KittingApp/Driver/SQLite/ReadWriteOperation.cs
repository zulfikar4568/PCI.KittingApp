using Dapper;
using PCI.KittingApp.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Driver.SQLite
{
    public class ReadWriteOperation<T>
    {
        public List<T> ReadAll(string query)
        {
            using (IDbConnection cnn = new SQLiteConnection(AppSettings.LoadConnectionString()))
            {
                var output = cnn.Query<T>(query, new DynamicParameters());
                return output.ToList();
            }
        }
        public T Read(string query)
        {
            using (IDbConnection cnn = new SQLiteConnection(AppSettings.LoadConnectionString()))
            {
                var output = cnn.QuerySingle<T>(query, new DynamicParameters());
                return output;
            }
        }

        public void Write(T data, string query)
        {
            using (IDbConnection cnn = new SQLiteConnection(AppSettings.LoadConnectionString()))
            {
                cnn.Execute(query, data);
            }
        }

        public void Write(string query)
        {
            using (IDbConnection cnn = new SQLiteConnection(AppSettings.LoadConnectionString()))
            {
                cnn.Execute(query);
            }
        }
    }
}
