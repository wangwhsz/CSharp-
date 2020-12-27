using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           txtDeskNo.Text = lsView.SelectedItems[0].Text;
        }
    }
}
