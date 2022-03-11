namespace WindowsFormsApplication1
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
            this.btnDers = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTablo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTabloYazdir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDers
            // 
            this.btnDers.Location = new System.Drawing.Point(12, 12);
            this.btnDers.Name = "btnDers";
            this.btnDers.Size = new System.Drawing.Size(75, 23);
            this.btnDers.TabIndex = 0;
            this.btnDers.Text = "Ders";
            this.btnDers.UseVisualStyleBackColor = true;
            this.btnDers.Click += new System.EventHandler(this.btnDers_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(547, 12);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "Öğrenci";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 190);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtTablo
            // 
            this.txtTablo.Location = new System.Drawing.Point(248, 14);
            this.txtTablo.Name = "txtTablo";
            this.txtTablo.Size = new System.Drawing.Size(100, 20);
            this.txtTablo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tablo:";
            // 
            // btnTabloYazdir
            // 
            this.btnTabloYazdir.Location = new System.Drawing.Point(354, 14);
            this.btnTabloYazdir.Name = "btnTabloYazdir";
            this.btnTabloYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnTabloYazdir.TabIndex = 5;
            this.btnTabloYazdir.Text = "Tablo Yazdır";
            this.btnTabloYazdir.UseVisualStyleBackColor = true;
            this.btnTabloYazdir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 242);
            this.Controls.Add(this.btnTabloYazdir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTablo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnDers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDers;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTablo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTabloYazdir;
    }
}

