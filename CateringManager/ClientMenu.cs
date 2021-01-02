using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
// using DAL;
using Model;
using System.Windows.Forms;

namespace CateringManager
{
    public partial class ClientMenu : Form
    {
        public ClientMenu(ListView listView1, string deskno)
        {
            InitializeComponent();
        }

        private void ClientMenu_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cateringManagerDataSet1.ClientMenu”中。您可以根据需要移动或删除它。
            this.clientMenuTableAdapter.Fill(this.cateringManagerDataSet1.ClientMenu);
            List<Model.Menu> menulist = new MenuManager().getmenulist();
            dgv1.DataSource = menulist;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // dataGridView1.Columns["id"].HeaderText = "编号";
            dgv1.Columns["name"].HeaderText = "菜品";
            dgv1.Columns["price"].HeaderText = "价格";



            List<Model.Client> menulistright = new ClientManager().getclientmenulist();
            dgv2.DataSource = menulistright;
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // dataGridView2.Columns["id"].HeaderText = "编号";
            dgv2.Columns["name"].HeaderText = "菜品";
            dgv2.Columns["price"].HeaderText = "价格";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count<=0)
            {
                MessageBox.Show("未选择菜品");
                return;
            }
            else
            {
                // new MenuManager().
                // new ClientManager().getitem(dgv1.Rows.)



                
                // int count = 0;
                // while (count<dgv1.SelectedCells.Count)
                // {
                //     MessageBox.Show((dgv1.Rows[count].Cells["name"].Value).ToString());
                //     count++;
                // }
                dgv2.Rows.Add()
                



            }
            // dgv2.Rows.Add(dgv1.SelectedRows.Insert(0,));
            // dgv2.SelectedRows.Insert(0,dgv1.SelectedRows[0]);
        }

    }
}
