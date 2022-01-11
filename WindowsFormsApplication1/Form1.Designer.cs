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
            this.lstbox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblİsimGiriniz = new System.Windows.Forms.Label();
            this.lblDersNotu = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstbox1
            // 
            this.lstbox1.FormattingEnabled = true;
            this.lstbox1.Location = new System.Drawing.Point(72, 75);
            this.lstbox1.Name = "lstbox1";
            this.lstbox1.Size = new System.Drawing.Size(120, 95);
            this.lstbox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblİsimGiriniz
            // 
            this.lblİsimGiriniz.AutoSize = true;
            this.lblİsimGiriniz.Location = new System.Drawing.Point(12, 26);
            this.lblİsimGiriniz.Name = "lblİsimGiriniz";
            this.lblİsimGiriniz.Size = new System.Drawing.Size(13, 13);
            this.lblİsimGiriniz.TabIndex = 3;
            this.lblİsimGiriniz.Text = "0";
            this.lblİsimGiriniz.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDersNotu
            // 
            this.lblDersNotu.AutoSize = true;
            this.lblDersNotu.Location = new System.Drawing.Point(12, 52);
            this.lblDersNotu.Name = "lblDersNotu";
            this.lblDersNotu.Size = new System.Drawing.Size(55, 13);
            this.lblDersNotu.TabIndex = 4;
            this.lblDersNotu.Text = "Ders Notu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "LİSTELE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(88, 49);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(100, 20);
            this.txtbox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblDersNotu);
            this.Controls.Add(this.lblİsimGiriniz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstbox1);
            this.Name = "Form1";
            this.Text = "DENEME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblİsimGiriniz;
        private System.Windows.Forms.Label lblDersNotu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbox2;
    }
}

