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
    public partial class DeskList : Form
    {
        public DeskList()
        {
            InitializeComponent();
        }

        private void DeskList_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cateringManagerDataSet.Desk”中。您可以根据需要移动或删除它。
            // this.deskTableAdapter.Fill(this.cateringManagerDataSet.Desk);
            List<Model.Desk> desklist = new DeskManager().getdesklist();
            dataGridView1.DataSource = desklist;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // dataGridView1.Columns["id"].HeaderText = "编号";
            dataGridView1.Columns["no"].HeaderText = "号";
            dataGridView1.Columns["status"].HeaderText = "状态";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
