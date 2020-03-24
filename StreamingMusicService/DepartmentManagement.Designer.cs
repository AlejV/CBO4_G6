namespace StreamingMusicService
{
    partial class DepartmentManagement
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Paint",
            "12",
            "8.95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Paintbrush",
            "20",
            "3.50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Peter Parker",
            "Employee",
            ""}, -1);
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView5 = new System.Windows.Forms.ListView();
            this.chProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Current Departments:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "Paints",
            "Tools",
            "Gardening",
            "Electronics",
            ""});
            this.listBox2.Location = new System.Drawing.Point(12, 56);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(205, 304);
            this.listBox2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Products in selected department:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            listViewItem1,
            listViewItem2});
            this.listView5.Location = new System.Drawing.Point(235, 38);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(313, 149);
            this.listView5.TabIndex = 33;
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
            this.chQuantity.Width = 71;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Employees in selected department:";
            // 
            // listView4
            // 
            this.listView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView4.BackColor = System.Drawing.Color.LightGreen;
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.HideSelection = false;
            this.listView4.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView4.Location = new System.Drawing.Point(238, 238);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(310, 178);
            this.listView4.TabIndex = 36;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ID";
            this.columnHeader13.Width = 59;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Employee";
            this.columnHeader14.Width = 125;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Position";
            this.columnHeader15.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(556, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 158);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Department:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox4.Location = new System.Drawing.Point(82, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(205, 28);
            this.textBox4.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 52);
            this.button1.TabIndex = 38;
            this.button1.Text = "Remove selected department";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DepartmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Name = "DepartmentManagement";
            this.Text = "DepartmentManagement";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader chProductID;
        private System.Windows.Forms.ColumnHeader chProductName;
        private System.Windows.Forms.ColumnHeader chQuantity;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}