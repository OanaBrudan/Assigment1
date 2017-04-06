namespace FurnitureManager
{
    partial class UsersF
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
            this.gridusers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textaddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridusers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.lbl_id);
            // 
            // gridusers
            // 
            this.gridusers.AllowUserToAddRows = false;
            this.gridusers.AllowUserToDeleteRows = false;
            this.gridusers.AllowUserToResizeColumns = false;
            this.gridusers.AllowUserToResizeRows = false;
            this.gridusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridusers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Address,
            this.Username,
            this.Password});
            this.gridusers.Location = new System.Drawing.Point(287, 43);
            this.gridusers.MultiSelect = false;
            this.gridusers.Name = "gridusers";
            this.gridusers.RowHeadersVisible = false;
            this.gridusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridusers.Size = new System.Drawing.Size(443, 166);
            this.gridusers.TabIndex = 15;
            this.gridusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridusers_CellContentClick);
            this.gridusers.SelectionChanged += new System.EventHandler(this.gridusers_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Retrieve";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnretrieve_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Edit User";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(532, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Delete User";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(83, 177);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(100, 20);
            this.textusername.TabIndex = 21;
            this.textusername.Click += new System.EventHandler(this.txt_username);
            this.textusername.TextChanged += new System.EventHandler(this.textusername_TextChanged);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(83, 221);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(100, 20);
            this.textpassword.TabIndex = 22;
            this.textpassword.Click += new System.EventHandler(this.txt_password);
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.lbl_name);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.lbl_address);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(83, 43);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 0;
            this.textid.Click += new System.EventHandler(this.txt_id);
            this.textid.TextChanged += new System.EventHandler(this.textid_TextChanged);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(83, 88);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 1;
            this.textname.Click += new System.EventHandler(this.txt_name);
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(83, 129);
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(100, 20);
            this.textaddress.TabIndex = 2;
            this.textaddress.Click += new System.EventHandler(this.txt_address);
            this.textaddress.TextChanged += new System.EventHandler(this.textaddress_TextChanged);
            // 
            // UsersF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 318);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridusers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
          //  this.Name = "UsersF";
            this.Text = "UsersF";
            this.Load += new System.EventHandler(this.UsersF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridusers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        // private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
       // private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
         private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}