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
    public partial class frmStock : Form
    {

        protected dbProvider formDBProvider;
        public frmStock()
        {
            InitializeComponent();
        }

     

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
                 

        private void menu2PersonalOrder_Click(object sender, EventArgs e)
        {
            menu2PersonalOrder.BackColor = Color.Blue;
            menu1Range.BackColor = Color.FromArgb(128, 128, 255);
            menu3Stats.BackColor = Color.FromArgb(128, 128, 255);
            tabControl1.SelectedTab = tabPersOrder;
            string sql;
            sql = "SELECT i.id_order,sh.address,p.name_product,i.weight,i.amount,i.date_order,i.date_ready,i.comment_order FROM indiv_order i join shop sh on i.code_shop = sh.id_shop join products p on i.code_product = p.id_product;";
            formDBProvider.mysqlQuery(dgvIndOrder, sql);
            dgvIndOrder.Refresh();
            dgvIndOrder.Columns[0].HeaderText = "№";
            dgvIndOrder.Columns[1].HeaderText = "магазин";
            dgvIndOrder.Columns[2].HeaderText = "товар";
            dgvIndOrder.Columns[3].HeaderText = "вес,гр";
            dgvIndOrder.Columns[4].HeaderText = "количество,шт";
            dgvIndOrder.Columns[5].HeaderText = "дата создания заказа";
            dgvIndOrder.Columns[6].HeaderText = "дата готовности";
            dgvIndOrder.Columns[7].HeaderText = "доп.комментарий";
        }

        private void menu3Stats_Click(object sender, EventArgs e)
        {
            menu3Stats.BackColor = Color.Blue;
            menu2PersonalOrder.BackColor = Color.FromArgb(128, 128, 255);
            menu1Range.BackColor = Color.FromArgb(128, 128, 255);
            tabControl1.SelectedTab = tabStats;
        }

        private void menu1Range_Click(object sender, EventArgs e)
        {
            menu1Range.BackColor = Color.Blue;
            menu2PersonalOrder.BackColor = Color.FromArgb(128, 128, 255);
            menu3Stats.BackColor = Color.FromArgb(128, 128, 255);
            tabControl1.SelectedTab = tabRange;
            formDBProvider.loadTable(dgvRangeStock, "products");
            dgvRangeStock.Refresh();
            dgvRangeStock.Columns[0].HeaderText = "№";
            dgvRangeStock.Columns[1].HeaderText = "продукт";
            dgvRangeStock.Columns[2].HeaderText = "код категории";
            dgvRangeStock.Columns[3].HeaderText = "срок годности";
            dgvRangeStock.Columns[4].HeaderText = "себестоимость";
            dgvRangeStock.Columns[5].HeaderText = "цена";
            dgvRangeStock.Columns[6].HeaderText = "вес";

        }

        public void frmStock_Load(dbProvider myDBProvider)
        {
            formDBProvider = myDBProvider;
            formDBProvider.loadTable(dgvRangeStock, "products");
            dgvRangeStock.Refresh();
            dgvRangeStock.Columns[0].HeaderText = "№";
            dgvRangeStock.Columns[1].HeaderText = "продукт";
            dgvRangeStock.Columns[2].HeaderText = "код категории";
            dgvRangeStock.Columns[3].HeaderText = "срок годности";
            dgvRangeStock.Columns[4].HeaderText = "себестоимость";
            dgvRangeStock.Columns[5].HeaderText = "цена";
            dgvRangeStock.Columns[6].HeaderText = "вес";


        }

        private void frmStock_Load(object sender, EventArgs e)
        {

        }
    }
}
