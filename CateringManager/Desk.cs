﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using CateringManager;
// using static CateringManager.MenuMain;

namespace CateringManager
{
    public partial class Desk : Form
    {
        public Desk()
        {
            InitializeComponent();
        }

        private void Desk_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cateringManagerDataSet.Desk”中。您可以根据需要移动或删除它。
            // this.deskTableAdapter.Fill(this.cateringManagerDataSet.Desk);

        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            string no = this.txtNo.Text;
            // decimal price = Convert.ToDecimal(this.txtPrice.Text);
            string status = this.cboStatus.Text;
            Model.Desk desk = new Model.Desk();
            desk.No = no;
            desk.Status = status;
            // menu.price = price;
            int us = new DeskManager().insertDesk(desk);
            if (us > 0)
            {
                MessageBox.Show("1");
                // Menu_Load(null, null);
                // MenuMain menuMain = new MenuMain();
                // MenuMain_Load
                 // MenuMain_Load(null, null);
            }


            ///
            /// 事件
            /// 
            //todo：事件委托

        }

        private void BtnListDesk_Click(object sender, EventArgs e)
        {
            DeskList desklist = new DeskList();
            desklist.Show();
        }

        public void Desk_FormClosed(object sender, FormClosedEventArgs e)
        {
            // MenuMain mn = new MenuMain();
            // mn.MenuMain_Load(null,null);
            // MenuMain_Load()
            // base.Refresh();
        }
    }
}
