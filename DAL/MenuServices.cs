using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class MenuServices
    {
        public int InsertMenu(Menu menu)
        {
            //先写sql
            string sql = "insert Menu(name,price) values(@name,@price)";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@id", menu.id),
                new SqlParameter("@name", menu.name),
                new SqlParameter("@price", menu.price)
            };


            int ur = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return ur;
        }

        public List<Menu> getmenulist()
        {
            // string sql = "insert into Menu(name,price) value(@name,@price)";
            string sql = "select * from Menu";
            List<Menu> menulist = new List<Menu>();

            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sql,null);
            while (reader.Read())
            {
                Menu menu = new Menu();
                menu.id = (int) reader["id"];
                menu.name = (string) reader["name"];
                menu.price = (decimal) reader["price"];
                menulist.Add(menu);
            }

            return menulist;


        }

        

        
        

        public int updatemenu(Menu menu)
        {
            string sql = "update Menu set price=@price where name=@name";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@price", menu.price),
                new SqlParameter("@name", menu.name),
            };
            // int result = SqlHelper.
            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return result;
        }
        //删除菜单
        public int deletemenu(int id)
        {
            string sql = "delete from Menu where id=@id";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return result;
        }
    }
}
