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
    public partial class frmMainEnter : Form
    {
        public frmMainEnter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void btnMainEnter_Click(object sender, EventArgs e)
        {
            string username;
            username = txtBoxUserName.Text.ToString();
            
            switch (username)
            {
                case "shop":
                    {
                        frmShop f = new frmShop();
                        f.ShowDialog();
                        break;
                    }
                case "workshop":
                    {
                        frmWorkshop f = new frmWorkshop();
                        f.ShowDialog();
                        break;
                    }
             }
           
                
        }
    }
}
