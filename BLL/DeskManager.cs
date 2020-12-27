using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public class DeskManager
    {
        public int insertDesk(Desk desk)
        {
            return new DeskService().InsertDesk(desk);
        }

        public List<Desk> getdesklist()
        {
            return new DeskService().getdesklist();
        }

        public int deletedesk(string str)
        {
            return new DeskService().deletedesk(str);
        }

    }
}