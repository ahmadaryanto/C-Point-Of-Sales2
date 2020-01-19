namespace Program_UAS_AHMAD
{
    partial class frmregis
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.cmbtipe = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(88, 196);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(124, 48);
            this.btnupdate.TabIndex = 26;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Red;
            this.Label4.Location = new System.Drawing.Point(18, 93);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 30);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "Tipe";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbtipe
            // 
            this.cmbtipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtipe.FormattingEnabled = true;
            this.cmbtipe.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.cmbtipe.Location = new System.Drawing.Point(126, 94);
            this.cmbtipe.Name = "cmbtipe";
            this.cmbtipe.Size = new System.Drawing.Size(216, 33);
            this.cmbtipe.TabIndex = 23;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(218, 196);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(124, 48);
            this.btnsave.TabIndex = 24;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(126, 17);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(216, 31);
            this.txtuser.TabIndex = 19;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(126, 57);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(216, 31);
            this.txtpass.TabIndex = 21;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Red;
            this.Label2.Location = new System.Drawing.Point(18, 58);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(94, 30);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(18, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(102, 30);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Username";
            // 
            // frmregis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 277);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cmbtipe);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmregis";
            this.Text = "Register Here";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cmbtipe;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.TextBox txtuser;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}