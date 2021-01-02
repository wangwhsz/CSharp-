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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void BtnaddClick(object sender, EventArgs e)
        {
            string name = txtname.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            Model.Menu menu = new Model.Menu();
            menu.name = name;
            menu.price = price;
            int us = new MenuManager().insertMenu(menu);
            if (us > 0)
            {
                MessageBox.Show("1");
                Menu_Load(null, null);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            List<Model.Menu> menulist = new MenuManager().getmenulist();
            dataGridView1.DataSource = menulist;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["id"].HeaderText = "编号";
            dataGridView1.Columns["name"].HeaderText = "菜品";
            dataGridView1.Columns["price"].HeaderText = "价格";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            Model.Menu menu = new Model.Menu();
            menu.name = name;
            menu.price = price;
            int us = new MenuManager().updatemenu(menu);
            if (us > 0)
                // MessageBox.Show("1");
                Menu_Load(null, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;
            int id = Convert.ToInt32(dataGridViewRow.Cells["id"].Value.ToString());
            int rs = new MenuManager().deletemenu(id);
            if (rs > 0)
            {
                MessageBox.Show("1");
                Menu_Load(null, null);
            }
            else
            {
                MessageBox.Show("failed");
            }
        }
    }
}