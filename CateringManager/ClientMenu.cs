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
        private string deskno;
        public ClientMenu(ListView listView1, string deskno)
        {
            InitializeComponent();
            this.deskno = deskno;
        }

        private void ClientMenu_Load(object sender, EventArgs e)
        {
            
            this.clientMenuTableAdapter.Fill(this.cateringManagerDataSet1.ClientMenu);
            List<Model.Menu> menulist = new MenuManager().getmenulist();
            dgv1.DataSource = menulist;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.Columns["id"].HeaderText = "编号";
            dgv1.Columns["name"].HeaderText = "菜品";
            dgv1.Columns["price"].HeaderText = "价格";



            List<Model.Client> menulistright = new ClientManager().getclientmenulist(deskno);
            dgv2.DataSource = menulistright;
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv2.Columns["id"].HeaderText = "编号";
            dgv2.Columns["name"].HeaderText = "菜品";
            dgv2.Columns["price"].HeaderText = "价格";
            dgv2.Columns["deskno"].HeaderText = "桌子信息";
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
                Client client = new Client();
                client.name = dgv1.SelectedRows[0].Cells["name"].Value.ToString();
                client.price = Convert.ToDecimal(dgv1.SelectedRows[0].Cells["price"].Value);

                new ClientManager().InsertClient(client,deskno);
                ClientMenu_Load(null,null);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count <= 0)
            {
                MessageBox.Show("未选择菜品");
                return;
            }
            else
            {
                Client client = new Client();
                client.id = Convert.ToInt32(dgv2.SelectedRows[0].Cells["id"].Value);
                client.name = dgv2.SelectedRows[0].Cells["name"].Value.ToString();
                client.price = Convert.ToDecimal(dgv2.SelectedRows[0].Cells["price"].Value);

                new ClientManager().deletemenu(client,deskno);
                ClientMenu_Load(null, null);




            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
