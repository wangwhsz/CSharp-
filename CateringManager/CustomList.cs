﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace CateringManager
{
    // public delegate void ClickDelegateHandler(ListView.SelectedListViewItemCollection collection);

    public partial class CustomList : Form
    {
        public ListView lsView;

        // public event ClickDelegateHandler ClickEvent;
        public CustomList(ListView lsListView)
        {
            InitializeComponent();
            lsView = lsListView;
        }



        private void CustomList_Load(object sender, EventArgs e)
        {
           // txtDeskNo.Text = lsView.SelectedItems[0].Text;
           int count = 0;
           while (  count<lsView.Items.Count)
           {
               cboDeskno.Items.Add(lsView.Items[count].Text);
               count++;
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                string deskno = this.txtDeskNo.Text;
                int num = Convert.ToInt32(this.txtNum.Text);
                string remark = txtRemark.Text;
                // decimal price = Convert.ToDecimal(this.txtPrice.Text);
                // string status = this.cboStatus.Text;
                Model.List list = new Model.List();
                list.deskno = deskno;
                list.num = num;
                list.remark = remark;
                // menu.price = price;
                int us = new ListManager().insertList(list);
                if (us > 0)
                {
                    MessageBox.Show("1");
                    // Menu_Load(null, null);
                    // MenuMain menuMain = new MenuMain();
                    // MenuMain_Load
                    // MenuMain_Load(null, null);
                }
        }
    }
}
