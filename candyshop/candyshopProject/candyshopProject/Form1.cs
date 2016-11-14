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
            label6.Text = "";
            string pas1 = "abcd";
            string pas2 = "ab";
            MemoryStream stream1;
            stream1 = getStreamFromString(pas1);
            MemoryStream stream2;
           stream2 = getStreamFromString(pas2);
            SHA1 sha = new SHA1CryptoServiceProvider();
            
            // This is one implementation of the abstract class SHA1.
            string res1;
            string res2;

            sha.ComputeHash(stream1);
            res1 = Convert.ToBase64String(sha.Hash);
            sha.ComputeHash(stream2);
            res2 = Convert.ToBase64String(sha.Hash);


            //            res1 = Convert.ToBase64String(sha.ComputeHash(stream1));
            //          res2 = Convert.ToBase64String(sha.ComputeHash(stream2));

            // bool b1 = res1.Equals(res2);

            label5.Text = res1;
            label6.Text = res2;
            
              // label6.Text = b1.ToString();
            

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
