using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWP1
{
    public class Repository : IDisposable
    {
        public SqlConnection _connection { get; set; }

        public Repository()
        {
            try
            {
                _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GroupDB"].ConnectionString);
                _connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Dispose()
        {
            _connection.Close();
        }
    }
}
