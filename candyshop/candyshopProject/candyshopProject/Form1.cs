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
    public partial class frmMainEnter : Form
    {
        public frmMainEnter()
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
            

        }

        public Guid GetHashString(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return new Guid(hash);
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

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            string pas1 = "abcd";
            string pas2 = "Abcd";
            label5.Text = GetHashString(pas1).ToString();
            label6.Text = GetHashString(pas2).ToString();
            if (label5.Text == label6.Text)
            {

                label7.Text = "TRUE!!!!!!!!!";

            }
            else
            {
                label7.Text = "false!!!((";
            }

        }
    }
}
