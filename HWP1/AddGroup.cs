using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWP1
{
    public class AddGroup:Repository
    {
        public void Add(Group group)
        {
            string query = @"INSERT INTO GroupTable VALUES(@name)";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddRange(new SqlParameter[]
                {
                    new SqlParameter("@name", System.Data.SqlDbType.NVarChar) { Value = group.GroupName}
                });

            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}
