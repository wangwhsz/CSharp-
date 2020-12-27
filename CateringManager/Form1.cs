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
using Model;

namespace CateringManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string admin = this.txtAdmin.Text;
            string pwd = this.txtPwd.Text;
            User ur = new UserManager().login(admin);
            if (ur.Password == pwd)
            {
                // MessageBox.Show("OK");
                // this.Hide();
                
                MenuMain menuMain = new MenuMain();
                menuMain.Show();

            }
            else
            {
                MessageBox.Show("failed");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
