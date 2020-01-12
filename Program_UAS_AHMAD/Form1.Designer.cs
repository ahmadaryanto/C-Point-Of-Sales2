namespace Program_UAS_AHMAD
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
            this.Label3 = new System.Windows.Forms.Label();
            this.BtCancel = new System.Windows.Forms.Button();
            this.BTlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(149, 28);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(104, 25);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Login Here";
            // 
            // BtCancel
            // 
            this.BtCancel.BackColor = System.Drawing.Color.Black;
            this.BtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancel.ForeColor = System.Drawing.Color.White;
            this.BtCancel.Location = new System.Drawing.Point(204, 161);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(101, 43);
            this.BtCancel.TabIndex = 19;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = false;
            // 
            // BTlogin
            // 
            this.BTlogin.BackColor = System.Drawing.Color.Black;
            this.BTlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTlogin.ForeColor = System.Drawing.Color.White;
            this.BTlogin.Location = new System.Drawing.Point(86, 161);
            this.BTlogin.Name = "BTlogin";
            this.BTlogin.Size = new System.Drawing.Size(101, 43);
            this.BTlogin.TabIndex = 18;
            this.BTlogin.Text = "Login";
            this.BTlogin.UseVisualStyleBackColor = false;
            this.BTlogin.Click += new System.EventHandler(this.BTlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(120, 113);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(164, 26);
            this.txtpassword.TabIndex = 17;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(120, 81);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(164, 26);
            this.txtname.TabIndex = 16;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 118);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 21);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 83);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 21);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Username ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 231);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BTlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Login Here";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button BtCancel;
        internal System.Windows.Forms.Button BTlogin;
        internal System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

