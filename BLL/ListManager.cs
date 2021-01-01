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
    }
}