namespace EFCF1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIslemDep = new System.Windows.Forms.Button();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.DaGriVieDep = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.cmbAra = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIslemPer = new System.Windows.Forms.Button();
            this.txtPerAra = new System.Windows.Forms.TextBox();
            this.txtPerSoyad = new System.Windows.Forms.TextBox();
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.DatGriViePer = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silPerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaGriVieDep)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatGriViePer)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnIslemDep);
            this.groupBox1.Controls.Add(this.txtDep);
            this.groupBox1.Controls.Add(this.DaGriVieDep);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departman";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departman Adı:";
            // 
            // BtnIslemDep
            // 
            this.BtnIslemDep.Location = new System.Drawing.Point(122, 296);
            this.BtnIslemDep.Name = "BtnIslemDep";
            this.BtnIslemDep.Size = new System.Drawing.Size(167, 23);
            this.BtnIslemDep.TabIndex = 2;
            this.BtnIslemDep.Text = "EKLE";
            this.BtnIslemDep.UseVisualStyleBackColor = true;
            this.BtnIslemDep.Click += new System.EventHandler(this.BtnIslemDep_Click);
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(122, 247);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(167, 20);
            this.txtDep.TabIndex = 1;
            // 
            // DaGriVieDep
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DaGriVieDep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DaGriVieDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DaGriVieDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaGriVieDep.ContextMenuStrip = this.contextMenuStrip1;
            this.DaGriVieDep.Location = new System.Drawing.Point(6, 79);
            this.DaGriVieDep.Name = "DaGriVieDep";
            this.DaGriVieDep.Size = new System.Drawing.Size(307, 150);
            this.DaGriVieDep.TabIndex = 0;
            this.DaGriVieDep.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DaGriVieDep_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbDep);
            this.groupBox2.Controls.Add(this.cmbAra);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnIslemPer);
            this.groupBox2.Controls.Add(this.txtPerAra);
            this.groupBox2.Controls.Add(this.txtPerSoyad);
            this.groupBox2.Controls.Add(this.txtPerAd);
            this.groupBox2.Controls.Add(this.DatGriViePer);
            this.groupBox2.Location = new System.Drawing.Point(375, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 403);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Departmanı:";
            // 
            // cmbDep
            // 
            this.cmbDep.DisplayMember = "Ad";
            this.cmbDep.FormattingEnabled = true;
            this.cmbDep.Location = new System.Drawing.Point(122, 312);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(167, 21);
            this.cmbDep.TabIndex = 5;
            this.cmbDep.ValueMember = "ID";
            // 
            // cmbAra
            // 
            this.cmbAra.DisplayMember = "Ad";
            this.cmbAra.FormattingEnabled = true;
            this.cmbAra.Items.AddRange(new object[] {
            "Adına Göre",
            "Soyadına Göre",
            "Departmanına Göre"});
            this.cmbAra.Location = new System.Drawing.Point(6, 46);
            this.cmbAra.Name = "cmbAra";
            this.cmbAra.Size = new System.Drawing.Size(141, 21);
            this.cmbAra.TabIndex = 5;
            this.cmbAra.ValueMember = "ID";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(269, 47);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(93, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Adı:";
            // 
            // btnIslemPer
            // 
            this.btnIslemPer.Location = new System.Drawing.Point(122, 359);
            this.btnIslemPer.Name = "btnIslemPer";
            this.btnIslemPer.Size = new System.Drawing.Size(167, 23);
            this.btnIslemPer.TabIndex = 2;
            this.btnIslemPer.Text = "EKLE";
            this.btnIslemPer.UseVisualStyleBackColor = true;
            this.btnIslemPer.Click += new System.EventHandler(this.btnIslemPer_Click);
            // 
            // txtPerAra
            // 
            this.txtPerAra.Location = new System.Drawing.Point(153, 47);
            this.txtPerAra.Name = "txtPerAra";
            this.txtPerAra.Size = new System.Drawing.Size(110, 20);
            this.txtPerAra.TabIndex = 1;
            // 
            // txtPerSoyad
            // 
            this.txtPerSoyad.Location = new System.Drawing.Point(122, 276);
            this.txtPerSoyad.Name = "txtPerSoyad";
            this.txtPerSoyad.Size = new System.Drawing.Size(167, 20);
            this.txtPerSoyad.TabIndex = 1;
            // 
            // txtPerAd
            // 
            this.txtPerAd.Location = new System.Drawing.Point(122, 250);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(167, 20);
            this.txtPerAd.TabIndex = 1;
            // 
            // DatGriViePer
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DatGriViePer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DatGriViePer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatGriViePer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatGriViePer.ContextMenuStrip = this.contextMenuStrip2;
            this.DatGriViePer.Location = new System.Drawing.Point(6, 79);
            this.DatGriViePer.Name = "DatGriViePer";
            this.DatGriViePer.Size = new System.Drawing.Size(356, 150);
            this.DatGriViePer.TabIndex = 0;
            this.DatGriViePer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DatGriViePer_MouseDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silPerToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(87, 26);
            // 
            // silPerToolStripMenuItem
            // 
            this.silPerToolStripMenuItem.Name = "silPerToolStripMenuItem";
            this.silPerToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silPerToolStripMenuItem.Text = "Sil";
            this.silPerToolStripMenuItem.Click += new System.EventHandler(this.silPerToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Filtrele:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaGriVieDep)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatGriViePer)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIslemDep;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.DataGridView DaGriVieDep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIslemPer;
        private System.Windows.Forms.TextBox txtPerAra;
        private System.Windows.Forms.TextBox txtPerAd;
        private System.Windows.Forms.DataGridView DatGriViePer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem silPerToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerSoyad;
        private System.Windows.Forms.Label label5;
    }
}

