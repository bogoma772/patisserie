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
    public partial class frmWorkshop : Form
    {
        public frmWorkshop()
        {
            InitializeComponent();
        }

     

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

      

        private void panel1_Click(object sender, EventArgs e)
        {
            menu1Range.BackColor = Color.Blue;
            menu2PersonalOrder.BackColor = Color.FromArgb(128, 128, 255);
            menu3Stats.BackColor = Color.FromArgb(128, 128, 255);
            tabControl1.SelectedTab = tabRange;
        }

        private void menu2PersonalOrder_Click(object sender, EventArgs e)
        {
            menu2PersonalOrder.BackColor = Color.Blue;
            menu1Range.BackColor = Color.FromArgb(128, 128, 255);
            menu3Stats.BackColor = Color.FromArgb(128, 128, 255);
            tabControl1.SelectedTab = tabPersOrder;

        }

        private void menu3Stats_Click(object sender, EventArgs e)
        {
            menu3Stats.BackColor = Color.Blue;
            menu2PersonalOrder.BackColor = Color.FromArgb(128, 128, 255);
            menu1Range.BackColor = Color.FromArgb(128, 128, 255);
            tabControl1.SelectedTab = tabStats;
        }
    }
}
