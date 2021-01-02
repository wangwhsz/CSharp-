using System.Collections.Generic;
using Model;

namespace BLL
{
    public class CheckOutManager
    {
        public List<Client> getclientmenulist(string deskno)
        {
            return new ClientManager().getitem(deskno);
        }
    }
}