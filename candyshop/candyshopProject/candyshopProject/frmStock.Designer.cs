namespace candyshopProject
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.menu1Range = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu2PersonalOrder = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menu3Stats = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRange = new System.Windows.Forms.TabPage();
            this.tabPersOrder = new System.Windows.Forms.TabPage();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menu1Range.SuspendLayout();
            this.menu2PersonalOrder.SuspendLayout();
            this.menu3Stats.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabRange.SuspendLayout();
            this.tabPersOrder.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1Range
            // 
            this.menu1Range.BackColor = System.Drawing.Color.Blue;
            this.menu1Range.Controls.Add(this.label1);
            this.menu1Range.Location = new System.Drawing.Point(0, 0);
            this.menu1Range.Name = "menu1Range";
            this.menu1Range.Size = new System.Drawing.Size(237, 40);
            this.menu1Range.TabIndex = 0;
            this.menu1Range.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ассортимент";
            this.label1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // menu2PersonalOrder
            // 
            this.menu2PersonalOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu2PersonalOrder.Controls.Add(this.label2);
            this.menu2PersonalOrder.Location = new System.Drawing.Point(240, 0);
            this.menu2PersonalOrder.Name = "menu2PersonalOrder";
            this.menu2PersonalOrder.Size = new System.Drawing.Size(235, 40);
            this.menu2PersonalOrder.TabIndex = 1;
            this.menu2PersonalOrder.Click += new System.EventHandler(this.menu2PersonalOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Индивидуальные заказы";
            this.label2.Click += new System.EventHandler(this.menu2PersonalOrder_Click);
            // 
            // menu3Stats
            // 
            this.menu3Stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu3Stats.Controls.Add(this.label3);
            this.menu3Stats.Location = new System.Drawing.Point(478, 0);
            this.menu3Stats.Name = "menu3Stats";
            this.menu3Stats.Size = new System.Drawing.Size(205, 40);
            this.menu3Stats.TabIndex = 2;
            this.menu3Stats.Click += new System.EventHandler(this.menu3Stats_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Статистика";
            this.label3.Click += new System.EventHandler(this.menu3Stats_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabRange);
            this.tabControl1.Controls.Add(this.tabPersOrder);
            this.tabControl1.Controls.Add(this.tabStats);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(89, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 337);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            this.tabControl1.TabStop = false;
            // 
            // tabRange
            // 
            this.tabRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabRange.Controls.Add(this.label6);
            this.tabRange.Location = new System.Drawing.Point(4, 5);
            this.tabRange.Name = "tabRange";
            this.tabRange.Padding = new System.Windows.Forms.Padding(3);
            this.tabRange.Size = new System.Drawing.Size(522, 328);
            this.tabRange.TabIndex = 0;
            this.tabRange.Text = "tabRangeWS";
            // 
            // tabPersOrder
            // 
            this.tabPersOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPersOrder.Controls.Add(this.label4);
            this.tabPersOrder.Location = new System.Drawing.Point(4, 5);
            this.tabPersOrder.Name = "tabPersOrder";
            this.tabPersOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersOrder.Size = new System.Drawing.Size(522, 328);
            this.tabPersOrder.TabIndex = 1;
            this.tabPersOrder.Text = "tabPage2";
            // 
            // tabStats
            // 
            this.tabStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabStats.Controls.Add(this.label5);
            this.tabStats.Location = new System.Drawing.Point(4, 5);
            this.tabStats.Name = "tabStats";
            this.tabStats.Size = new System.Drawing.Size(522, 328);
            this.tabStats.TabIndex = 2;
            this.tabStats.Text = "tabPage3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "тут будет таблица Инд.заказы из БД";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Тут можно получить статистику";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Тут будет таблица Ассортимент из БД";
            // 
            // frmWorkshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menu3Stats);
            this.Controls.Add(this.menu2PersonalOrder);
            this.Controls.Add(this.menu1Range);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWorkshop";
            this.Text = "Цех";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.menu1Range.ResumeLayout(false);
            this.menu1Range.PerformLayout();
            this.menu2PersonalOrder.ResumeLayout(false);
            this.menu2PersonalOrder.PerformLayout();
            this.menu3Stats.ResumeLayout(false);
            this.menu3Stats.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabRange.ResumeLayout(false);
            this.tabRange.PerformLayout();
            this.tabPersOrder.ResumeLayout(false);
            this.tabPersOrder.PerformLayout();
            this.tabStats.ResumeLayout(false);
            this.tabStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu1Range;
        private System.Windows.Forms.Panel menu3Stats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel menu2PersonalOrder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRange;
        private System.Windows.Forms.TabPage tabPersOrder;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}