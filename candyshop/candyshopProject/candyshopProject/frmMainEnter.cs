using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace candyshopProject
{
    public partial class FrmMainEnter : Form
    {
        protected string subsystem;
        protected authenticationComponent authComp;
        protected candyshopFacade facade;

        public FrmMainEnter()
        {
            InitializeComponent();
        }

        private MemoryStream getStreamFromString(string str)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(str);
            stream.Position = 0;
            return stream;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TO DO LIST
            // Задачи
            //"Цех"
            //1.Построение графиков - будем ли делать?
            //2.Добавление в БД: через текстбоксы. вызываем процедуру insertquery(нужно написать по аналогии с mysqlquery)
            //3.Удаление по номеру записи: вызываем процедуру deletequery(нужно написать по аналогии с mysqlquery)
            //"Магазин"
            //4.Добавление индвидуальных заказов(аналогично п.2)
            //5.Касса(аналогично п.2 + п.3) - как именно это будет выглядеть, нужно обсудить
            //"Общее"
            //6.сохранить пароли пользователей в БД в виде хэшей, воспользовавшись функцией получения хэша, которая используется в authentificationComponent
            // END OF TO DO LIST
         facade = new candyshopFacade();
            authComp = new authenticationComponent(facade.PropDbProvider);

        }

        private void btnMainEnter_Click(object sender, EventArgs e)
        {
            string username;
            string userpas;
            username = txtBoxUserName.Text;
            userpas = txtBoxPassword.Text;
            
            if (radioButton1.Checked == true)
            {
                subsystem = "users_stock";
            }
            if (radioButton2.Checked == true)
            {
                subsystem = "users_shop";
            }
            bool tr = true; // служебная переменная для работы заглушки
            // if (authComp.CheckUser(username, userpas, subsystem) == true)
            if (tr == true) // заглушка
            {
                switch (subsystem)
                {
                    case "users_stock":
                        {
                            facade.PropStockSubsystem.ShowFrm();
                            break;
                        }
                    case "users_shop":
                        {
                            facade.PropShopSubsystem.ShowFrm();
                            break;
                        }
                }
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

       

       
    }
}
