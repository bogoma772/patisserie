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
        protected dbProvider formDBProvider;


        private void menu1RangeShop_Click(object sender, EventArgs e)
        {
            menu1RangeShop.BackColor = Color.Brown;
            menu2Cashbox.BackColor = Color.LightCoral;
            menu3PersonalOrder.BackColor = Color.LightCoral;
            tabControl1.SelectedTab = tabRange;
               formDBProvider.loadTable(dgvRange, "products");
            dgvRange.Refresh();
            dgvRange.Columns[0].HeaderText = "№";
            dgvRange.Columns[1].HeaderText = "продукт";
            dgvRange.Columns[2].HeaderText = "код категории";
            dgvRange.Columns[3].HeaderText = "срок годности";
            dgvRange.Columns[4].HeaderText = "себестоимость";
            dgvRange.Columns[5].HeaderText = "цена";
            dgvRange.Columns[6].HeaderText = "вес";



        }

        private void menu2Cashbox_Click(object sender, EventArgs e)
        {
            menu2Cashbox.BackColor = Color.Brown;
            menu1RangeShop.BackColor = Color.LightCoral;
            menu3PersonalOrder.BackColor = Color.LightCoral;
            tabControl1.SelectedTab = tabCashbox;

            string sql;
            sql = "SELECT p.name_product, s.date_production, s.date_realization,s.status_goods FROM stock s join products p on s.code_product = p.id_product;";
            formDBProvider.mysqlQuery(dgvCashbox, sql);
            dgvCashbox.Refresh();
            dgvCashbox.Columns[0].HeaderText = "название продукта";
            dgvRange.Columns[1].HeaderText = "дата изготовления";
            dgvRange.Columns[2].HeaderText = "дата продажи";
            dgvRange.Columns[3].HeaderText = "статус";


        }

        private void menu3PersonalOrder_Click(object sender, EventArgs e)
        {
            menu3PersonalOrder.BackColor = Color.Brown;
            menu2Cashbox.BackColor = Color.LightCoral;
            menu1RangeShop.BackColor = Color.LightCoral;
            tabControl1.SelectedTab = tabPersonalOrder;
          
                
        }

      



        public void frmShop_Load(dbProvider myDBProvider)
        {
            formDBProvider = myDBProvider;
            formDBProvider.loadTable(dgvRange, "products");
            dgvRange.Refresh();
            dgvRange.Columns[0].HeaderText = "№";
            dgvRange.Columns[1].HeaderText = "продукт";
            dgvRange.Columns[2].HeaderText = "код категории";
            dgvRange.Columns[3].HeaderText = "срок годности";
            dgvRange.Columns[4].HeaderText = "себестоимость";
            dgvRange.Columns[5].HeaderText = "цена";
            dgvRange.Columns[6].HeaderText = "вес";
            

        }
                
    }
}
