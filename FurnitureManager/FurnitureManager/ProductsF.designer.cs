namespace FurnitureManager
{
    partial class ProductsF
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.texttitle = new System.Windows.Forms.TextBox();
            this.textdescription = new System.Windows.Forms.TextBox();
            this.textcolor = new System.Windows.Forms.TextBox();
            this.textsize = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.textstock = new System.Windows.Forms.TextBox();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
           // this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id product";
            this.label1.Click += new System.EventHandler(this.lbl_IdProduct);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            this.label2.Click += new System.EventHandler(this.lbl_title);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.lbl_description);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            this.label4.Click += new System.EventHandler(this.lbl_color);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Size";
            this.label5.Click += new System.EventHandler(this.lbl_size);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.lbl_price);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stock";
            this.label7.Click += new System.EventHandler(this.lbl_stock);
            // 
            // textid
            // 
            this.textid.BackColor = System.Drawing.Color.White;
            this.textid.Location = new System.Drawing.Point(108, 60);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 7;
            this.textid.Click += new System.EventHandler(this.txt_IDProduct);
            this.textid.TextChanged += new System.EventHandler(this.idProduct);
            // 
            // texttitle
            // 
            this.texttitle.Location = new System.Drawing.Point(108, 95);
            this.texttitle.Name = "texttitle";
            this.texttitle.Size = new System.Drawing.Size(100, 20);
            this.texttitle.TabIndex = 8;
            this.texttitle.TextChanged += new System.EventHandler(this.txt_title);
            // 
            // textdescription
            // 
            this.textdescription.Location = new System.Drawing.Point(108, 131);
            this.textdescription.Name = "textdescription";
            this.textdescription.Size = new System.Drawing.Size(100, 20);
            this.textdescription.TabIndex = 9;
            this.textdescription.TextChanged += new System.EventHandler(this.txt_description);
            // 
            // textcolor
            // 
            this.textcolor.Location = new System.Drawing.Point(108, 165);
            this.textcolor.Name = "textcolor";
            this.textcolor.Size = new System.Drawing.Size(100, 20);
            this.textcolor.TabIndex = 10;
            this.textcolor.TextChanged += new System.EventHandler(this.txt_color);
            // 
            // textsize
            // 
            this.textsize.Location = new System.Drawing.Point(108, 202);
            this.textsize.Name = "textsize";
            this.textsize.Size = new System.Drawing.Size(100, 20);
            this.textsize.TabIndex = 11;
            this.textsize.TextChanged += new System.EventHandler(this.txt_size);
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(108, 235);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 20);
            this.textprice.TabIndex = 12;
            this.textprice.TextChanged += new System.EventHandler(this.txt_price);
            // 
            // textstock
            // 
            this.textstock.Location = new System.Drawing.Point(108, 268);
            this.textstock.Name = "textstock";
            this.textstock.Size = new System.Drawing.Size(100, 20);
            this.textstock.TabIndex = 13;
            this.textstock.TextChanged += new System.EventHandler(this.txt_stock);
            // 
            // gridProduct
            // 
            this.gridProduct.AllowUserToAddRows = false;
            this.gridProduct.AllowUserToDeleteRows = false;
            this.gridProduct.AllowUserToResizeColumns = false;
            this.gridProduct.AllowUserToResizeRows = false;
            this.gridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProduct.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Description,
            this.Color,
            //this.Size,
            this.Price,
            this.Stock});
            this.gridProduct.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridProduct.Location = new System.Drawing.Point(214, 56);
            this.gridProduct.MultiSelect = false;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.RowHeadersVisible = false;
            this.gridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduct.Size = new System.Drawing.Size(547, 166);
            this.gridProduct.TabIndex = 14;
            this.gridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduct_CellContentClick);
            this.gridProduct.SelectionChanged += new System.EventHandler(this.gridProduct_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Size
            // 
           // this.Size.DataPropertyName = "Size";
           // this.Size.HeaderText = "Size";
           // this.Size.Name = "Size";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(306, 265);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 15;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.btn_createProduct_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_updateProduct_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(554, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(674, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_ViewProduct_Click);
            // 
            // ProductsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 339);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.textstock);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textsize);
            this.Controls.Add(this.textcolor);
            this.Controls.Add(this.textdescription);
            this.Controls.Add(this.texttitle);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductsF";
            this.Text = "ProductF";
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.Load += new System.EventHandler(this.ProductsF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox texttitle;
        private System.Windows.Forms.TextBox textdescription;
        private System.Windows.Forms.TextBox textcolor;
        private System.Windows.Forms.TextBox textsize;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox textstock;
        private System.Windows.Forms.DataGridView gridProduct;
        //  private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
       // private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        // private System.Windows.Forms.DataGridViewTextBoxColumn Size;
    }
}