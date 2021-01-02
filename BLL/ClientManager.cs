using System.Collections.Generic;
using DAL;
using Model;
namespace BLL
{
    public class ClientManager
    {
        public /*List<Menu>*/ void selectandinsert(string name)
        {
            // return new ClientService().selectandinsert(name);
        }

        public List<Client> getitem(string name)
        {
            return new ClientService().getitem(name);
        }

        public void insertclientmenu(string name)
        {
            // return new ClientService().insertitem(name);
        }
        public List<Client> getclientmenulist(string deskno)
        {
            return new ClientService().getclientmenulist(deskno);
        }

        public int InsertClient(Client client,string deskno)
        {
            return new ClientService().InsertClient(client,deskno);

        }





        public int deletemenu(Client client,string deskno)
        {
            
            return new ClientService().deletemenu(client,deskno);
        }

        public  int deletemenu( string deskno)
        {

            return new ClientService().deletemenu(deskno);
        }
    }
}