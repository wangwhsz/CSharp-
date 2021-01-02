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
        public List<Client> getclientmenulist()
        {
            // string sql = "insert into Menu(name,price) value(@name,@price)";
            string sql = "select * from ClientMenu";
            List<Client> clientmenulist = new List<Client>();

            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sql, null);
            while (reader.Read())
            {
                Client client = new Client();
                // client.id = (int) reader["id"];
                client.name = (string) reader["name"];
                client.price = (decimal) reader["price"];
                clientmenulist.Add(client);
            }

            return clientmenulist;


        }
        
        public List<Menu> getitem(string name)
        {
            // string sql = "insert into Menu(name,price) value(@name,@price)";
            string sql = "select * from Menu where name = @name";
            List<Menu> menulist = new List<Menu>();

            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sql, null);
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
    }
}
