namespace Program_UAS_AHMAD
{
    partial class frmbayar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbayar));
            this.txtkembali = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbayar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpembelian = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtkembali
            // 
            this.txtkembali.Enabled = false;
            this.txtkembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkembali.Location = new System.Drawing.Point(197, 193);
            this.txtkembali.Name = "txtkembali";
            this.txtkembali.Size = new System.Drawing.Size(178, 29);
            this.txtkembali.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Kembalian";
            // 
            // txtbayar
            // 
            this.txtbayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbayar.Location = new System.Drawing.Point(197, 147);
            this.txtbayar.Name = "txtbayar";
            this.txtbayar.Size = new System.Drawing.Size(178, 29);
            this.txtbayar.TabIndex = 30;
            this.txtbayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbayar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Jumlah Pembayaran";
            // 
            // txttax
            // 
            this.txttax.Enabled = false;
            this.txttax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttax.Location = new System.Drawing.Point(197, 103);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(178, 29);
            this.txttax.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "tax";
            // 
            // txtpembelian
            // 
            this.txtpembelian.Enabled = false;
            this.txtpembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpembelian.Location = new System.Drawing.Point(197, 58);
            this.txtpembelian.Name = "txtpembelian";
            this.txtpembelian.Size = new System.Drawing.Size(178, 29);
            this.txtpembelian.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Jumlah Pembelian";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MidnightBlue;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(409, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 39);
            this.button5.TabIndex = 33;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmbayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 269);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtkembali);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbayar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpembelian);
            this.Controls.Add(this.label5);
            this.Name = "frmbayar";
            this.Text = "frmbayar";
            this.Load += new System.EventHandler(this.frmbayar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtkembali;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtbayar;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txttax;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtpembelian;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
    }
}