namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Addbttn = new System.Windows.Forms.Button();
            this.MASBttn = new System.Windows.Forms.Button();
            this.Totaltxt = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.dscnttxt = new System.Windows.Forms.TextBox();
            this.CLRBttn = new System.Windows.Forms.Button();
            this.RMVALLBttn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnametxt = new System.Windows.Forms.TextBox();
            this.pcodetxt = new System.Windows.Forms.TextBox();
            this.Exitbttn = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove,
            this.pcode,
            this.product,
            this.quantity,
            this.price,
            this.Endtotal});
            this.dataGridView1.Location = new System.Drawing.Point(31, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 140);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Addbttn
            // 
            this.Addbttn.Location = new System.Drawing.Point(31, 206);
            this.Addbttn.Name = "Addbttn";
            this.Addbttn.Size = new System.Drawing.Size(99, 32);
            this.Addbttn.TabIndex = 3;
            this.Addbttn.Text = "ADD";
            this.Addbttn.UseVisualStyleBackColor = true;
            this.Addbttn.Click += new System.EventHandler(this.Addbttn_Click);
            // 
            // MASBttn
            // 
            this.MASBttn.Location = new System.Drawing.Point(31, 422);
            this.MASBttn.Name = "MASBttn";
            this.MASBttn.Size = new System.Drawing.Size(99, 31);
            this.MASBttn.TabIndex = 5;
            this.MASBttn.Text = "FINISH";
            this.MASBttn.UseVisualStyleBackColor = true;
            this.MASBttn.Click += new System.EventHandler(this.MASBttn_Click);
            // 
            // Totaltxt
            // 
            this.Totaltxt.Location = new System.Drawing.Point(246, 427);
            this.Totaltxt.Name = "Totaltxt";
            this.Totaltxt.Size = new System.Drawing.Size(110, 20);
            this.Totaltxt.TabIndex = 7;
            this.Totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Totaltxt.TextChanged += new System.EventHandler(this.Totaltxt_TextChanged);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(178, 430);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(47, 13);
            this.Total.TabIndex = 8;
            this.Total.Text = "Total Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantity";
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(617, 168);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(100, 20);
            this.quantitytxt.TabIndex = 11;
            this.quantitytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantitytxt.TextChanged += new System.EventHandler(this.quantitytxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product code";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(723, 173);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(49, 13);
            this.Discount.TabIndex = 14;
            this.Discount.Text = "Discount";
            // 
            // dscnttxt
            // 
            this.dscnttxt.Location = new System.Drawing.Point(778, 169);
            this.dscnttxt.Name = "dscnttxt";
            this.dscnttxt.Size = new System.Drawing.Size(94, 20);
            this.dscnttxt.TabIndex = 15;
            this.dscnttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dscnttxt.TextChanged += new System.EventHandler(this.dscnttxt_TextChanged);
            // 
            // CLRBttn
            // 
            this.CLRBttn.Location = new System.Drawing.Point(181, 206);
            this.CLRBttn.Name = "CLRBttn";
            this.CLRBttn.Size = new System.Drawing.Size(99, 33);
            this.CLRBttn.TabIndex = 16;
            this.CLRBttn.Text = "CLEAR";
            this.CLRBttn.UseVisualStyleBackColor = true;
            this.CLRBttn.Click += new System.EventHandler(this.CLRBttn_Click);
            // 
            // RMVALLBttn
            // 
            this.RMVALLBttn.Location = new System.Drawing.Point(804, 258);
            this.RMVALLBttn.Name = "RMVALLBttn";
            this.RMVALLBttn.Size = new System.Drawing.Size(68, 38);
            this.RMVALLBttn.TabIndex = 17;
            this.RMVALLBttn.Text = "REMOVE ALL";
            this.RMVALLBttn.UseVisualStyleBackColor = true;
            this.RMVALLBttn.Click += new System.EventHandler(this.RMVALLBttn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(841, 149);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // pnametxt
            // 
            this.pnametxt.Location = new System.Drawing.Point(109, 168);
            this.pnametxt.Name = "pnametxt";
            this.pnametxt.Size = new System.Drawing.Size(100, 20);
            this.pnametxt.TabIndex = 19;
            this.pnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pnametxt.TextChanged += new System.EventHandler(this.pnametxt_TextChanged);
            this.pnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pnametxt_KeyPress);
            // 
            // pcodetxt
            // 
            this.pcodetxt.Location = new System.Drawing.Point(292, 169);
            this.pcodetxt.Name = "pcodetxt";
            this.pcodetxt.Size = new System.Drawing.Size(104, 20);
            this.pcodetxt.TabIndex = 20;
            this.pcodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pcodetxt.TextChanged += new System.EventHandler(this.pcodetxt_TextChanged);
            this.pcodetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pcodetxt_KeyPress);
            // 
            // Exitbttn
            // 
            this.Exitbttn.Location = new System.Drawing.Point(804, 428);
            this.Exitbttn.Name = "Exitbttn";
            this.Exitbttn.Size = new System.Drawing.Size(68, 25);
            this.Exitbttn.TabIndex = 21;
            this.Exitbttn.Text = "Exit";
            this.Exitbttn.UseVisualStyleBackColor = true;
            this.Exitbttn.Click += new System.EventHandler(this.Exitbttn_Click);
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // pcode
            // 
            this.pcode.HeaderText = "prodcut_code";
            this.pcode.Name = "pcode";
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // Endtotal
            // 
            this.Endtotal.HeaderText = "Total";
            this.Endtotal.Name = "Endtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Price";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(439, 169);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(105, 20);
            this.pricetxt.TabIndex = 23;
            this.pricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 461);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exitbttn);
            this.Controls.Add(this.pcodetxt);
            this.Controls.Add(this.pnametxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.RMVALLBttn);
            this.Controls.Add(this.CLRBttn);
            this.Controls.Add(this.dscnttxt);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Totaltxt);
            this.Controls.Add(this.MASBttn);
            this.Controls.Add(this.Addbttn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "           Make A Sale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addbttn;
        private System.Windows.Forms.Button MASBttn;
        private System.Windows.Forms.TextBox Totaltxt;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.TextBox dscnttxt;
        private System.Windows.Forms.Button CLRBttn;
        private System.Windows.Forms.Button RMVALLBttn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox pnametxt;
        private System.Windows.Forms.TextBox pcodetxt;
        private System.Windows.Forms.Button Exitbttn;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetxt;
    }
}

