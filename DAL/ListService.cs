using System.Collections.Generic;
using Model;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class ListService
    {
        public int InsertList(Model.List list)
        {
            string sql = "insert List(deskno,num,remark) values(@deskno,@num,@remark)";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@deskno", list.deskno),
                new SqlParameter("@num", list.num),
                new SqlParameter("@remark", list.remark),
                // new SqlParameter("@price", menu.price)
            };


            int ur = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return ur;
        }
    }
}