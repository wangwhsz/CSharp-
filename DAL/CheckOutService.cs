using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Model;
namespace DAL
{
    public class CheckOutService
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
                // client.id = (int) reader["id"];
                client.name = (string) reader["name"];
                client.price = (decimal) reader["price"];
                // client.deskno = (string) reader["deskno"];
                clientmenulist.Add(client);
            }

            return clientmenulist;


        }
    }
}