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
            //开单
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
        //gengxin
        public int updatedesk(string deskno)
        {
            // string sql = "update";
            // string deskno = list.deskno;
            string status = "有人";
            string sql = "update Desk set status=@status where no=@deskno";
            SqlParameter[] par =
            {
                new SqlParameter("@status", status),
                new SqlParameter("@deskno",deskno),
            };
            // int result = SqlHelper.
            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return result;
        }

        public int updatedesk(string deskno,int num)
        {
            // string sql = "update";
            // string deskno = list.deskno;
            string status = "空闲";
            string sql = "update Desk set status=@status where no=@deskno";
            SqlParameter[] par =
            {
                new SqlParameter("@status", status),
                new SqlParameter("@deskno", deskno),
            };
            // int result = SqlHelper.
            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return result;
        }
        //shanchu
        public int deletelist(string deskno)
        {
            string sql = "delete from List where deskno=@deskno";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@deskno", deskno)
            };
            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return result;
        }
    }
}