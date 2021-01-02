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

        public List<Menu> getitem(string name)
        {
            return new ClientService().getitem(name);
        }

        public void insertclientmenu(string name)
        {
            // return new ClientService().insertitem(name);
        }
        public List<Client> getclientmenulist()
        {
            return new ClientService().getclientmenulist();
        }
    }
}