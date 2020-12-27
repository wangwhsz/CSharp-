using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

// using
namespace DAL
{
    public class UserServices
    {
        public User login(string admin)
        {
            string sql = "select * from [User] where Admin=@admin";
            User user = new User();
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@admin", admin)
            };
            
            SqlDataReader read =  SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            while (read.Read())
            {
                user.Admin = (string) read["Admin"];
                user.Password = (string) read["Password"];
            }

            return user;
        }
    }
}
