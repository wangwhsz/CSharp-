using System.Collections.Generic;
using Model;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DeskService
    {
        public int InsertDesk(Desk desk)
        {
            string sql = "insert Desk(no,status) values(@No,@Status)";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@no", desk.No),
                new SqlParameter("@status", desk.Status),
                // new SqlParameter("@name", menu.name),
                // new SqlParameter("@price", menu.price)
            };


            int ur = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return ur;
        }

        public List<Desk> getdesklist()
        {
            // string sql = "insert into Menu(name,price) value(@name,@price)";
            string sql = "select * from Desk";
            List<Desk> desklist = new List<Desk>();

            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sql, null);
            while (reader.Read())
            {
                Desk desk = new Desk();
                desk.No = (string) reader["no"];
                // desk.name = (string) reader["name"];
                desk.Status = (string) reader["status"];
                desklist.Add(desk);
            }

            return desklist;


        }


        //删除
        public int deletedesk(string no)
        {
            string sql = "delete from Desk where no=@no";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@no",no)
            };
            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return result;
        }
    }
}