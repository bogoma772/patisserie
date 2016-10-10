using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace candyshopProject
{
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();
        }

        private void menu1RangeShop_Click(object sender, EventArgs e)
        {
            menu1RangeShop.BackColor = Color.Brown;
            menu2Cashbox.BackColor = Color.LightCoral;
            menu3PersonalOrder.BackColor = Color.LightCoral;
            tabControl1.SelectedTab = tabRange;
        }

        private void menu2Cashbox_Click(object sender, EventArgs e)
        {
            menu2Cashbox.BackColor = Color.Brown;
            menu1RangeShop.BackColor = Color.LightCoral;
            menu3PersonalOrder.BackColor = Color.LightCoral;
            tabControl1.SelectedTab = tabCashbox;
        }

        private void menu3PersonalOrder_Click(object sender, EventArgs e)
        {
            menu3PersonalOrder.BackColor = Color.Brown;
            menu2Cashbox.BackColor = Color.LightCoral;
            menu1RangeShop.BackColor = Color.LightCoral;
            tabControl1.SelectedTab = tabPersonalOrder;
          
                
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
