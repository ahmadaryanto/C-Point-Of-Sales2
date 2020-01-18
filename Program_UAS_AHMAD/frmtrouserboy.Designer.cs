namespace Program_UAS_AHMAD
{
    partial class frmtrouserboy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtrouserboy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btsave = new System.Windows.Forms.Button();
            this.DG = new System.Windows.Forms.DataGridView();
            this.Button2 = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btnew = new System.Windows.Forms.Button();
            this.lblfilename = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtkat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblfilename2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btsave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsave.Image = ((System.Drawing.Image)(resources.GetObject("btsave.Image")));
            this.btsave.Location = new System.Drawing.Point(50, 0);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(50, 50);
            this.btsave.TabIndex = 3;
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG.DefaultCellStyle = dataGridViewCellStyle16;
            this.DG.Location = new System.Drawing.Point(10, 314);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersVisible = false;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(755, 231);
            this.DG.TabIndex = 31;
            this.DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellContentClick);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Location = new System.Drawing.Point(200, 0);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(51, 50);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Show All";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btsearch
            // 
            this.btsearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsearch.Image = ((System.Drawing.Image)(resources.GetObject("btsearch.Image")));
            this.btsearch.Location = new System.Drawing.Point(150, 0);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(50, 50);
            this.btsearch.TabIndex = 5;
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btdelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.Location = new System.Drawing.Point(100, 0);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(50, 50);
            this.btdelete.TabIndex = 4;
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btnew
            // 
            this.btnew.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnew.Image = ((System.Drawing.Image)(resources.GetObject("btnew.Image")));
            this.btnew.Location = new System.Drawing.Point(0, 0);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(50, 50);
            this.btnew.TabIndex = 2;
            this.btnew.UseVisualStyleBackColor = false;
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfilename.Location = new System.Drawing.Point(533, 190);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(16, 24);
            this.lblfilename.TabIndex = 33;
            this.lblfilename.Text = "-";
            this.lblfilename.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(423, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "File name :";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(594, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 43);
            this.button4.TabIndex = 31;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnopen.FlatAppearance.BorderSize = 0;
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnopen.Location = new System.Drawing.Point(594, 48);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(83, 43);
            this.btnopen.TabIndex = 7;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(427, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 151);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblid.Location = new System.Drawing.Point(146, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(54, 24);
            this.lblid.TabIndex = 29;
            this.lblid.Text = "CPR-";
            // 
            // txtkat
            // 
            this.txtkat.Enabled = false;
            this.txtkat.Location = new System.Drawing.Point(157, 99);
            this.txtkat.Name = "txtkat";
            this.txtkat.Size = new System.Drawing.Size(241, 29);
            this.txtkat.TabIndex = 28;
            this.txtkat.Text = "Celana Pria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kategori";
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(155, 136);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(241, 29);
            this.txtharga.TabIndex = 3;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(157, 64);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(241, 29);
            this.txtdes.TabIndex = 4;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(199, 27);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(197, 29);
            this.txtid.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label3.Location = new System.Drawing.Point(4, 139);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 24);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Harga";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Location = new System.Drawing.Point(6, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 24);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Deskripsi";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(6, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(27, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "ID";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblfilename2);
            this.GroupBox1.Controls.Add(this.lblfilename);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.button4);
            this.GroupBox1.Controls.Add(this.btnopen);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Controls.Add(this.lblid);
            this.GroupBox1.Controls.Add(this.txtkat);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.button3);
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Controls.Add(this.txtstok);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.txtharga);
            this.GroupBox1.Controls.Add(this.txtdes);
            this.GroupBox1.Controls.Add(this.txtid);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox1.Location = new System.Drawing.Point(10, 84);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(755, 224);
            this.GroupBox1.TabIndex = 29;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Detail";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(277, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 31);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(235, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 31);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(154, 173);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(75, 29);
            this.txtstok.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stok";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MidnightBlue;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(721, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 39);
            this.button5.TabIndex = 32;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.btsearch);
            this.Panel1.Controls.Add(this.btdelete);
            this.Panel1.Controls.Add(this.btsave);
            this.Panel1.Controls.Add(this.btnew);
            this.Panel1.Location = new System.Drawing.Point(10, 15);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(251, 50);
            this.Panel1.TabIndex = 30;
            // 
            // lblfilename2
            // 
            this.lblfilename2.AutoSize = true;
            this.lblfilename2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfilename2.Location = new System.Drawing.Point(533, 190);
            this.lblfilename2.Name = "lblfilename2";
            this.lblfilename2.Size = new System.Drawing.Size(16, 24);
            this.lblfilename2.TabIndex = 40;
            this.lblfilename2.Text = "-";
            // 
            // frmtrouserboy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(774, 554);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtrouserboy";
            this.Text = "frmtrouserboy";
            this.Load += new System.EventHandler(this.frmtrouserboy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btsave;
        internal System.Windows.Forms.DataGridView DG;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btsearch;
        internal System.Windows.Forms.Button btdelete;
        internal System.Windows.Forms.Button btnew;
        internal System.Windows.Forms.Label lblfilename;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label lblid;
        internal System.Windows.Forms.TextBox txtkat;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtharga;
        internal System.Windows.Forms.TextBox txtdes;
        internal System.Windows.Forms.TextBox txtid;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox txtstok;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblfilename2;
    }
}