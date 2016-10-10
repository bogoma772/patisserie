namespace candyshopProject
{
    partial class frmShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShop));
            this.menu3PersonalOrder = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menu2Cashbox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menu1RangeShop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRange = new System.Windows.Forms.TabPage();
            this.tabCashbox = new System.Windows.Forms.TabPage();
            this.tabPersonalOrder = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPreCost = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxMassa = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxGoods = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menu3PersonalOrder.SuspendLayout();
            this.menu2Cashbox.SuspendLayout();
            this.menu1RangeShop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabRange.SuspendLayout();
            this.tabCashbox.SuspendLayout();
            this.tabPersonalOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu3PersonalOrder
            // 
            this.menu3PersonalOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menu3PersonalOrder.Controls.Add(this.label3);
            this.menu3PersonalOrder.Location = new System.Drawing.Point(417, 0);
            this.menu3PersonalOrder.Name = "menu3PersonalOrder";
            this.menu3PersonalOrder.Size = new System.Drawing.Size(266, 40);
            this.menu3PersonalOrder.TabIndex = 5;
            this.menu3PersonalOrder.Click += new System.EventHandler(this.menu3PersonalOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Индивидуальные заказы";
            this.label3.Click += new System.EventHandler(this.menu3PersonalOrder_Click);
            // 
            // menu2Cashbox
            // 
            this.menu2Cashbox.BackColor = System.Drawing.Color.LightCoral;
            this.menu2Cashbox.Controls.Add(this.label2);
            this.menu2Cashbox.Location = new System.Drawing.Point(240, 0);
            this.menu2Cashbox.Name = "menu2Cashbox";
            this.menu2Cashbox.Size = new System.Drawing.Size(174, 40);
            this.menu2Cashbox.TabIndex = 4;
            this.menu2Cashbox.Click += new System.EventHandler(this.menu2Cashbox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Касса";
            this.label2.Click += new System.EventHandler(this.menu2Cashbox_Click);
            // 
            // menu1RangeShop
            // 
            this.menu1RangeShop.BackColor = System.Drawing.Color.Brown;
            this.menu1RangeShop.Controls.Add(this.label1);
            this.menu1RangeShop.Location = new System.Drawing.Point(0, 0);
            this.menu1RangeShop.Name = "menu1RangeShop";
            this.menu1RangeShop.Size = new System.Drawing.Size(237, 40);
            this.menu1RangeShop.TabIndex = 3;
            this.menu1RangeShop.Click += new System.EventHandler(this.menu1RangeShop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ассортимент";
            this.label1.Click += new System.EventHandler(this.menu1RangeShop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabRange);
            this.tabControl1.Controls.Add(this.tabCashbox);
            this.tabControl1.Controls.Add(this.tabPersonalOrder);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(86, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 337);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            this.tabControl1.TabStop = false;
            // 
            // tabRange
            // 
            this.tabRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabRange.Controls.Add(this.label11);
            this.tabRange.Location = new System.Drawing.Point(4, 5);
            this.tabRange.Name = "tabRange";
            this.tabRange.Padding = new System.Windows.Forms.Padding(3);
            this.tabRange.Size = new System.Drawing.Size(522, 328);
            this.tabRange.TabIndex = 0;
            this.tabRange.Text = "tabRange";
            // 
            // tabCashbox
            // 
            this.tabCashbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabCashbox.Controls.Add(this.label12);
            this.tabCashbox.Location = new System.Drawing.Point(4, 5);
            this.tabCashbox.Name = "tabCashbox";
            this.tabCashbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabCashbox.Size = new System.Drawing.Size(522, 328);
            this.tabCashbox.TabIndex = 1;
            this.tabCashbox.Text = "tabPage2";
            // 
            // tabPersonalOrder
            // 
            this.tabPersonalOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPersonalOrder.Controls.Add(this.btnSubmit);
            this.tabPersonalOrder.Controls.Add(this.btnPreCost);
            this.tabPersonalOrder.Controls.Add(this.textBox1);
            this.tabPersonalOrder.Controls.Add(this.label10);
            this.tabPersonalOrder.Controls.Add(this.txtBoxDate);
            this.tabPersonalOrder.Controls.Add(this.label9);
            this.tabPersonalOrder.Controls.Add(this.txtBoxMassa);
            this.tabPersonalOrder.Controls.Add(this.txtBoxNumber);
            this.tabPersonalOrder.Controls.Add(this.label8);
            this.tabPersonalOrder.Controls.Add(this.label7);
            this.tabPersonalOrder.Controls.Add(this.txtBoxGoods);
            this.tabPersonalOrder.Controls.Add(this.label6);
            this.tabPersonalOrder.Controls.Add(this.txtBoxPhone);
            this.tabPersonalOrder.Controls.Add(this.label5);
            this.tabPersonalOrder.Controls.Add(this.txtBoxFIO);
            this.tabPersonalOrder.Controls.Add(this.label4);
            this.tabPersonalOrder.Location = new System.Drawing.Point(4, 5);
            this.tabPersonalOrder.Name = "tabPersonalOrder";
            this.tabPersonalOrder.Size = new System.Drawing.Size(522, 328);
            this.tabPersonalOrder.TabIndex = 2;
            this.tabPersonalOrder.Text = "tabPage3";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(312, 267);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 45);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Оформить";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnPreCost
            // 
            this.btnPreCost.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreCost.Location = new System.Drawing.Point(132, 267);
            this.btnPreCost.Name = "btnPreCost";
            this.btnPreCost.Size = new System.Drawing.Size(174, 45);
            this.btnPreCost.TabIndex = 14;
            this.btnPreCost.Text = "Предварительная стоимость";
            this.btnPreCost.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(127, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Особые пожелания";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(270, 196);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(145, 20);
            this.txtBoxDate.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Дата выполнения";
            // 
            // txtBoxMassa
            // 
            this.txtBoxMassa.Location = new System.Drawing.Point(164, 157);
            this.txtBoxMassa.Name = "txtBoxMassa";
            this.txtBoxMassa.Size = new System.Drawing.Size(68, 20);
            this.txtBoxMassa.TabIndex = 9;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(327, 157);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(88, 20);
            this.txtBoxNumber.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Вес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Количество";
            // 
            // txtBoxGoods
            // 
            this.txtBoxGoods.Location = new System.Drawing.Point(213, 120);
            this.txtBoxGoods.Name = "txtBoxGoods";
            this.txtBoxGoods.Size = new System.Drawing.Size(202, 20);
            this.txtBoxGoods.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Продукция";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(213, 82);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(202, 20);
            this.txtBoxPhone.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Телефон";
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.Location = new System.Drawing.Point(213, 45);
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(202, 20);
            this.txtBoxFIO.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ф.И.О.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "тут будет таблица Ассортимент из БД ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "тут будет таблица Касса";
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menu3PersonalOrder);
            this.Controls.Add(this.menu2Cashbox);
            this.Controls.Add(this.menu1RangeShop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShop";
            this.Text = "Магазин";
            this.menu3PersonalOrder.ResumeLayout(false);
            this.menu3PersonalOrder.PerformLayout();
            this.menu2Cashbox.ResumeLayout(false);
            this.menu2Cashbox.PerformLayout();
            this.menu1RangeShop.ResumeLayout(false);
            this.menu1RangeShop.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabRange.ResumeLayout(false);
            this.tabRange.PerformLayout();
            this.tabCashbox.ResumeLayout(false);
            this.tabCashbox.PerformLayout();
            this.tabPersonalOrder.ResumeLayout(false);
            this.tabPersonalOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu3PersonalOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel menu2Cashbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel menu1RangeShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRange;
        private System.Windows.Forms.TabPage tabCashbox;
        private System.Windows.Forms.TabPage tabPersonalOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPreCost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxMassa;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxGoods;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}