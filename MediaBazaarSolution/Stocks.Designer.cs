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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvAllProducts = new System.Windows.Forms.ListView();
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcStocks = new System.Windows.Forms.TabControl();
            this.tpManageStocks = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCurrQuantity = new System.Windows.Forms.TextBox();
            this.tbCurrPrice = new System.Windows.Forms.TextBox();
            this.tbCurrName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbAddProduct = new System.Windows.Forms.GroupBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbProdPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cbProdDepartment = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnRemoveProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCurrDep = new System.Windows.Forms.ComboBox();
            this.tcStocks.SuspendLayout();
            this.tpManageStocks.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Paints",
            "Tools",
            "Gardening",
            "Electronics",
            ""});
            this.listBox1.Location = new System.Drawing.Point(11, 35);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-78, -45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select Department:";
            // 
            // lvAllProducts
            // 
            this.lvAllProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAllProducts.BackColor = System.Drawing.Color.LightGreen;
            this.lvAllProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProductName,
            this.chQuantity,
            this.chPrice});
            this.lvAllProducts.FullRowSelect = true;
            this.lvAllProducts.GridLines = true;
            this.lvAllProducts.HideSelection = false;
            this.lvAllProducts.Location = new System.Drawing.Point(153, 36);
            this.lvAllProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lvAllProducts.Name = "lvAllProducts";
            this.lvAllProducts.Size = new System.Drawing.Size(254, 211);
            this.lvAllProducts.TabIndex = 17;
            this.lvAllProducts.UseCompatibleStateImageBehavior = false;
            this.lvAllProducts.View = System.Windows.Forms.View.Details;
            this.lvAllProducts.SelectedIndexChanged += new System.EventHandler(this.LvAllProducts_SelectedIndexChanged);
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
            this.tcStocks.Location = new System.Drawing.Point(8, 18);
            this.tcStocks.Margin = new System.Windows.Forms.Padding(2);
            this.tcStocks.Name = "tcStocks";
            this.tcStocks.SelectedIndex = 0;
            this.tcStocks.Size = new System.Drawing.Size(773, 464);
            this.tcStocks.TabIndex = 18;
            // 
            // tpManageStocks
            // 
            this.tpManageStocks.Controls.Add(this.groupBox3);
            this.tpManageStocks.Controls.Add(this.btnUpdate);
            this.tpManageStocks.Controls.Add(this.gbAddProduct);
            this.tpManageStocks.Controls.Add(this.btnRemoveProd);
            this.tpManageStocks.Controls.Add(this.label1);
            this.tpManageStocks.Controls.Add(this.label10);
            this.tpManageStocks.Controls.Add(this.lvAllProducts);
            this.tpManageStocks.Controls.Add(this.listBox1);
            this.tpManageStocks.Controls.Add(this.label6);
            this.tpManageStocks.Location = new System.Drawing.Point(4, 22);
            this.tpManageStocks.Margin = new System.Windows.Forms.Padding(2);
            this.tpManageStocks.Name = "tpManageStocks";
            this.tpManageStocks.Padding = new System.Windows.Forms.Padding(2);
            this.tpManageStocks.Size = new System.Drawing.Size(765, 438);
            this.tpManageStocks.TabIndex = 0;
            this.tpManageStocks.Text = "Manage Stocks";
            this.tpManageStocks.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.cbCurrDep);
            this.groupBox3.Controls.Add(this.tbCurrQuantity);
            this.groupBox3.Controls.Add(this.tbCurrPrice);
            this.groupBox3.Controls.Add(this.tbCurrName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(153, 257);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(266, 140);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Information";
            // 
            // tbCurrQuantity
            // 
            this.tbCurrQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCurrQuantity.Location = new System.Drawing.Point(85, 100);
            this.tbCurrQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.tbCurrQuantity.Name = "tbCurrQuantity";
            this.tbCurrQuantity.Size = new System.Drawing.Size(99, 21);
            this.tbCurrQuantity.TabIndex = 32;
            // 
            // tbCurrPrice
            // 
            this.tbCurrPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCurrPrice.Location = new System.Drawing.Point(85, 75);
            this.tbCurrPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbCurrPrice.Name = "tbCurrPrice";
            this.tbCurrPrice.Size = new System.Drawing.Size(99, 21);
            this.tbCurrPrice.TabIndex = 29;
            // 
            // tbCurrName
            // 
            this.tbCurrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCurrName.Location = new System.Drawing.Point(85, 51);
            this.tbCurrName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCurrName.Name = "tbCurrName";
            this.tbCurrName.Size = new System.Drawing.Size(120, 21);
            this.tbCurrName.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Department:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(226, 401);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 31);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbAddProduct
            // 
            this.gbAddProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.gbAddProduct.Controls.Add(this.btnAddProd);
            this.gbAddProduct.Controls.Add(this.label13);
            this.gbAddProduct.Controls.Add(this.tbProdPrice);
            this.gbAddProduct.Controls.Add(this.label2);
            this.gbAddProduct.Controls.Add(this.tbProdName);
            this.gbAddProduct.Controls.Add(this.label27);
            this.gbAddProduct.Controls.Add(this.cbProdDepartment);
            this.gbAddProduct.Controls.Add(this.label26);
            this.gbAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddProduct.Location = new System.Drawing.Point(452, 17);
            this.gbAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.gbAddProduct.Name = "gbAddProduct";
            this.gbAddProduct.Padding = new System.Windows.Forms.Padding(2);
            this.gbAddProduct.Size = new System.Drawing.Size(195, 103);
            this.gbAddProduct.TabIndex = 20;
            this.gbAddProduct.TabStop = false;
            this.gbAddProduct.Text = "Add Product:";
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddProd.Location = new System.Drawing.Point(116, 0);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 25);
            this.btnAddProd.TabIndex = 28;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.BtnAddProd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(175, 77);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "€";
            // 
            // tbProdPrice
            // 
            this.tbProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbProdPrice.Location = new System.Drawing.Point(73, 75);
            this.tbProdPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbProdPrice.Name = "tbProdPrice";
            this.tbProdPrice.Size = new System.Drawing.Size(99, 21);
            this.tbProdPrice.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Price:";
            // 
            // tbProdName
            // 
            this.tbProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbProdName.Location = new System.Drawing.Point(73, 53);
            this.tbProdName.Margin = new System.Windows.Forms.Padding(2);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(120, 21);
            this.tbProdName.TabIndex = 24;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label27.Location = new System.Drawing.Point(27, 53);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 15);
            this.label27.TabIndex = 23;
            this.label27.Text = "Name:";
            // 
            // cbProdDepartment
            // 
            this.cbProdDepartment.FormattingEnabled = true;
            this.cbProdDepartment.Location = new System.Drawing.Point(73, 27);
            this.cbProdDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cbProdDepartment.Name = "cbProdDepartment";
            this.cbProdDepartment.Size = new System.Drawing.Size(120, 24);
            this.cbProdDepartment.TabIndex = 22;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label26.Location = new System.Drawing.Point(2, 31);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 15);
            this.label26.TabIndex = 21;
            this.label26.Text = "Department:";
            // 
            // btnRemoveProd
            // 
            this.btnRemoveProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveProd.BackColor = System.Drawing.Color.Tomato;
            this.btnRemoveProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProd.ForeColor = System.Drawing.Color.White;
            this.btnRemoveProd.Location = new System.Drawing.Point(423, 320);
            this.btnRemoveProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProd.Name = "btnRemoveProd";
            this.btnRemoveProd.Size = new System.Drawing.Size(232, 27);
            this.btnRemoveProd.TabIndex = 19;
            this.btnRemoveProd.Text = "Remove selected product";
            this.btnRemoveProd.UseVisualStyleBackColor = false;
            this.btnRemoveProd.Click += new System.EventHandler(this.btnRemoveProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Products in selected department:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Select Department:";
            // 
            // cbCurrDep
            // 
            this.cbCurrDep.FormattingEnabled = true;
            this.cbCurrDep.Location = new System.Drawing.Point(85, 20);
            this.cbCurrDep.Margin = new System.Windows.Forms.Padding(2);
            this.cbCurrDep.Name = "cbCurrDep";
            this.cbCurrDep.Size = new System.Drawing.Size(120, 24);
            this.cbCurrDep.TabIndex = 29;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(807, 504);
            this.Controls.Add(this.tcStocks);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.tcStocks.ResumeLayout(false);
            this.tpManageStocks.ResumeLayout(false);
            this.tpManageStocks.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbAddProduct.ResumeLayout(false);
            this.gbAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvAllProducts;
        private System.Windows.Forms.ColumnHeader chProductName;
        private System.Windows.Forms.ColumnHeader chQuantity;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.TabControl tcStocks;
        private System.Windows.Forms.TabPage tpManageStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbAddProduct;
        private System.Windows.Forms.Button btnRemoveProd;
        private System.Windows.Forms.ComboBox cbProdDepartment;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbProdPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCurrQuantity;
        private System.Windows.Forms.TextBox tbCurrPrice;
        private System.Windows.Forms.TextBox tbCurrName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCurrDep;
    }
}