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

        // public List<Client> getclientmenulist()
        // {
        //     return new MenuServices().getclientmenulist();
        // }

        public int updatemenu(Menu menu)
        {
            return new MenuServices().updatemenu(menu);

        }

        public int deletemenu(int id)
        {
            return new MenuServices().deletemenu(id);

        }
        //消费录入中的选择项
        // public List<Menu> selectandinsert(string name)
        // {
        //     return new MenuServices().selectandinsert(name);
        // }
        //
        // public List<Menu> getitem(string name)
        // {
        //     return new MenuServices().getitem(name);
        // }
    }
}
