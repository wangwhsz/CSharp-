using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public class ListManager
    {
        public int insertList(Model.List list)
        {
            return new ListService().InsertList(list);
        }
        public int updatedesk (string deskno)
        {
            return new ListService().updatedesk(deskno);
        }

        public int updatedesk(string deskno,int num)
        {
            return new ListService().updatedesk(deskno,1);
        }

        public int deletelist(string deskno)
        {
            return new ListService().deletelist(deskno);
        }
        
    }
}