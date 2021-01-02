using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace CateringManager
{
    //委托
    public partial class MenuMain : Form
    {
        //事件
        public MenuMain()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            //todo showdialog
        }

        public void toolStripButton5_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();

            desk.Show();
            MenuMain_Load(null,null);
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // listView1.Clear();
            // List<Model.Desk> desklist = new DeskManager().getdesklist();
            // foreach (Model.Desk row in desklist)
            // {
            //     listView1.Tag = row;
            //     listView1.Items.Add(row.No, row.Status == "空闲" ? 1 : 0);
            //
            // }
        }

        public void MenuMain_Load(object sender, EventArgs e)
        {
            listView1.Clear();
            List<Model.Desk> desklist = new DeskManager().getdesklist();
            foreach (Model.Desk row in desklist)
            {
                listView1.Tag = row;
                listView1.Items.Add(row.No, row.Status == "空闲" ? 1 : 0);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            MenuMain_Load(null,null);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("failed");

            }
            else
            {
                string no = listView1.SelectedItems[0].Text;
                int us = new DeskManager().deletedesk(no);
                if (us > 0)
                {
                    MessageBox.Show("1");
                    MenuMain_Load(null, null);
                }
            }


            
            // else
            {
                
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // if (listView1.SelectedItems.Count == 0)
            // {
            //     MessageBox.Show("请选择餐桌");
            //     return;
            // }

            // txtDeskNo.Text = lsView.SelectedItems[0].Text;
            
            if (listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("请选择餐桌");
            }
            else
            {
                if (listView1.SelectedItems[0].ImageIndex == 0)
                {
                    MessageBox.Show("此餐桌已经开单，不要重复开单");
                    return;
                }
                string deskno = listView1.SelectedItems[0].Text;

                CustomList list = new CustomList(listView1,deskno);
                //todo:全局变量传过去
                list.Show();
                MenuMain_Load(null,null);
            }

            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择餐桌");
            }
            else
            {
                if (listView1.SelectedItems[0].ImageIndex == 1)
                {
                    MessageBox.Show("此餐桌还未开单，无法取消开单");
                    return;
                }

                string deskno = listView1.SelectedItems[0].Text;

                // CustomList list = new CustomList(listView1, deskno);
                //todo:全局变量传过去
                // list.Show();
                // CustomList list = new CustomList(listView1, deskno);
                // list.
                int result = new ListManager().deletelist(deskno);
                int result1 = new ListManager().updatedesk(deskno,1);
                if (result > 0 && result1 > 0)
                {
                    MessageBox.Show("删除开单成功");
                    MenuMain_Load(null, null);

                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择餐桌");
            }
            else
            {
                if (listView1.SelectedItems[0].ImageIndex == 1)
                {
                    MessageBox.Show("该餐桌还未开单，请先开单");
                    return;
                }

                string deskno = listView1.SelectedItems[0].Text;

                ClientMenu client = new ClientMenu(listView1, deskno);
                client.Show();
                //todo:全局变量传过去
                // list.Show();
                MenuMain_Load(null, null);
            }
        }
    }
}