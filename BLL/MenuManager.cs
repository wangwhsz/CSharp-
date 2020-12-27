using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class MenuManager
    {
        // public 
        public int insertMenu(Menu menu)
        {
            return new MenuServices().InsertMenu(menu);
        }

        public List<Menu> getmenulist()
        {
            return new MenuServices().getmenulist();
        }

        public int updatemenu(Menu menu)
        {
            return new MenuServices().updatemenu(menu);

        }

        public int deletemenu(int id)
        {
            return new MenuServices().deletemenu(id);

        }
    }
}
