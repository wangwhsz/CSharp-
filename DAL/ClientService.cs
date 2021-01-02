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
    public class ClientService
    {
        public List<Client> getclientmenulist(string deskno)
        {
            // string sql = "insert into Menu(name,price) value(@name,@price)";
            string sql = "select * from ClientMenu where deskno=@deskno";
            List<Client> clientmenulist = new List<Client>();
            // SqlParameter
            SqlParameter[] par =
            {
                // new SqlParameter("@status", status),
                new SqlParameter("@deskno", deskno),
            };
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            while (reader.Read())
            {
                Client client = new Client();
                client.id = (int) reader["id"];
                client.name = (string) reader["name"];
                client.price = (decimal) reader["price"];
                client.deskno = (string) reader["deskno"];
                clientmenulist.Add(client);
            }
            return clientmenulist;


        }
        
        public List<Client> getitem(string name)
        {
            // string sql = "insert into Menu(name,price) value(@name,@price)";
            string sql = "select * from Menu where name = @name";
            List<Client> menulist = new List<Client>();
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@name", name),
            };
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            while (reader.Read())
            {
                Client menu = new Client();
                // menu.id = (int) reader["id"];
                menu.name = (string) reader["name"];
                menu.price = (decimal) reader["price"];
                menulist.Add(menu);
            }

            return menulist;


        }

        public int InsertClient(Client client,string deskno)
        {
            //先写sql
            string sql = "insert ClientMenu(name,price,deskno) values(@name,@price,@deskno)";
            SqlParameter[] par = new SqlParameter[]
            {
                // new SqlParameter("@id", client.id),
                new SqlParameter("@name", client.name),
                new SqlParameter("@price", client.price),
                new SqlParameter("@deskno", deskno)
                
            };


            int ur = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return ur;
        }





        public int deletemenu(Client client,string deskno)
        {
            string sql = "delete from ClientMenu where deskno=@deskno and id=@id";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@deskno", deskno),
                new SqlParameter("@id", client.id)
            };
            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return result;
        }

        public int deletemenu(string deskno)
        {
            string sql = "delete from ClientMenu where deskno=@deskno";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@deskno", deskno),
                // new SqlParameter("@id", client.id)
            };
            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, par);
            return result;
        }
    }
}
