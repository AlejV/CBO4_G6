namespace MediaBazaarSolution
{
    partial class Stocks
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Paint",
            "12",
            "8.95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Paintbrush",
            "20",
            "3.50"}, -1);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView5 = new System.Windows.Forms.ListView();
            this.chProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcStocks = new System.Windows.Forms.TabControl();
            this.tpManageStocks = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDecreaseQty = new System.Windows.Forms.Button();
            this.btnIncreaseQty = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbAddProduct = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tpStatsStocks = new System.Windows.Forms.TabPage();
            this.tcStocks.SuspendLayout();
            this.tpManageStocks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Paints",
            "Tools",
            "Gardening",
            "Electronics",
            ""});
            this.listBox1.Location = new System.Drawing.Point(17, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 324);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-117, -69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select Department:";
            // 
            // listView5
            // 
            this.listView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView5.BackColor = System.Drawing.Color.LightGreen;
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProductID,
            this.chProductName,
            this.chQuantity,
            this.chPrice});
            this.listView5.FullRowSelect = true;
            this.listView5.GridLines = true;
            this.listView5.HideSelection = false;
            this.listView5.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listView5.Location = new System.Drawing.Point(243, 55);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(323, 275);
            this.listView5.TabIndex = 17;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // chProductID
            // 
            this.chProductID.Text = "ID";
            this.chProductID.Width = 45;
            // 
            // chProductName
            // 
            this.chProductName.Text = "Name";
            this.chProductName.Width = 102;
            // 
            // chQuantity
            // 
            this.chQuantity.Text = "Quantity";
            this.chQuantity.Width = 69;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 72;
            // 
            // tcStocks
            // 
            this.tcStocks.Controls.Add(this.tpManageStocks);
            this.tcStocks.Controls.Add(this.tpStatsStocks);
            this.tcStocks.Location = new System.Drawing.Point(12, 27);
            this.tcStocks.Name = "tcStocks";
            this.tcStocks.SelectedIndex = 0;
            this.tcStocks.Size = new System.Drawing.Size(897, 424);
            this.tcStocks.TabIndex = 18;
            // 
            // tpManageStocks
            // 
            this.tpManageStocks.Controls.Add(this.groupBox1);
            this.tpManageStocks.Controls.Add(this.gbAddProduct);
            this.tpManageStocks.Controls.Add(this.button1);
            this.tpManageStocks.Controls.Add(this.label1);
            this.tpManageStocks.Controls.Add(this.label10);
            this.tpManageStocks.Controls.Add(this.listView5);
            this.tpManageStocks.Controls.Add(this.listBox1);
            this.tpManageStocks.Controls.Add(this.label6);
            this.tpManageStocks.Location = new System.Drawing.Point(4, 29);
            this.tpManageStocks.Name = "tpManageStocks";
            this.tpManageStocks.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageStocks.Size = new System.Drawing.Size(889, 391);
            this.tpManageStocks.TabIndex = 0;
            this.tpManageStocks.Text = "Manage Stocks";
            this.tpManageStocks.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnDecreaseQty);
            this.groupBox1.Controls.Add(this.btnIncreaseQty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(583, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 187);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Quantity:";
            // 
            // btnDecreaseQty
            // 
            this.btnDecreaseQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecreaseQty.BackColor = System.Drawing.Color.Tomato;
            this.btnDecreaseQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseQty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecreaseQty.Location = new System.Drawing.Point(11, 126);
            this.btnDecreaseQty.Name = "btnDecreaseQty";
            this.btnDecreaseQty.Size = new System.Drawing.Size(276, 47);
            this.btnDecreaseQty.TabIndex = 30;
            this.btnDecreaseQty.Text = "Decrease quantity";
            this.btnDecreaseQty.UseVisualStyleBackColor = false;
            // 
            // btnIncreaseQty
            // 
            this.btnIncreaseQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncreaseQty.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIncreaseQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseQty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncreaseQty.Location = new System.Drawing.Point(11, 73);
            this.btnIncreaseQty.Name = "btnIncreaseQty";
            this.btnIncreaseQty.Size = new System.Drawing.Size(276, 47);
            this.btnIncreaseQty.TabIndex = 29;
            this.btnIncreaseQty.Text = "Increase quantity";
            this.btnIncreaseQty.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Quantity:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox2.Location = new System.Drawing.Point(94, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 28);
            this.textBox2.TabIndex = 26;
            // 
            // gbAddProduct
            // 
            this.gbAddProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.gbAddProduct.Controls.Add(this.label13);
            this.gbAddProduct.Controls.Add(this.textBox1);
            this.gbAddProduct.Controls.Add(this.label2);
            this.gbAddProduct.Controls.Add(this.textBox9);
            this.gbAddProduct.Controls.Add(this.label27);
            this.gbAddProduct.Controls.Add(this.comboBox6);
            this.gbAddProduct.Controls.Add(this.label26);
            this.gbAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddProduct.Location = new System.Drawing.Point(583, 16);
            this.gbAddProduct.Name = "gbAddProduct";
            this.gbAddProduct.Size = new System.Drawing.Size(293, 158);
            this.gbAddProduct.TabIndex = 20;
            this.gbAddProduct.TabStop = false;
            this.gbAddProduct.Text = "Add Product:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(262, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 22);
            this.label13.TabIndex = 27;
            this.label13.Text = "€";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox1.Location = new System.Drawing.Point(109, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 28);
            this.textBox1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Price:";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox9.Location = new System.Drawing.Point(109, 81);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(178, 28);
            this.textBox9.TabIndex = 24;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label27.Location = new System.Drawing.Point(41, 81);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 22);
            this.label27.TabIndex = 23;
            this.label27.Text = "Name:";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(109, 42);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(178, 33);
            this.comboBox6.TabIndex = 22;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label26.Location = new System.Drawing.Point(3, 47);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 22);
            this.label26.TabIndex = 21;
            this.label26.Text = "Department:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(243, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Remove selected product";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Products in selected department:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Select Department:";
            // 
            // tpStatsStocks
            // 
            this.tpStatsStocks.Location = new System.Drawing.Point(4, 29);
            this.tpStatsStocks.Name = "tpStatsStocks";
            this.tpStatsStocks.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatsStocks.Size = new System.Drawing.Size(889, 391);
            this.tpStatsStocks.TabIndex = 1;
            this.tpStatsStocks.Text = "Stock Statistics";
            this.tpStatsStocks.UseVisualStyleBackColor = true;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(951, 474);
            this.Controls.Add(this.tcStocks);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.tcStocks.ResumeLayout(false);
            this.tpManageStocks.ResumeLayout(false);
            this.tpManageStocks.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAddProduct.ResumeLayout(false);
            this.gbAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader chProductID;
        private System.Windows.Forms.ColumnHeader chProductName;
        private System.Windows.Forms.ColumnHeader chQuantity;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.TabControl tcStocks;
        private System.Windows.Forms.TabPage tpManageStocks;
        private System.Windows.Forms.TabPage tpStatsStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbAddProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecreaseQty;
        private System.Windows.Forms.Button btnIncreaseQty;
    }
}