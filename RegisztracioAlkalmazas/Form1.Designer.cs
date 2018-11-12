namespace RegisztracioAlkalmazas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.rb_f = new System.Windows.Forms.RadioButton();
            this.rb_n = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tb_hobbi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.b_load = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.tb_szul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szül. dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem:";
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(83, 6);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(70, 20);
            this.tb_nev.TabIndex = 4;
            // 
            // rb_f
            // 
            this.rb_f.AutoSize = true;
            this.rb_f.Location = new System.Drawing.Point(83, 59);
            this.rb_f.Name = "rb_f";
            this.rb_f.Size = new System.Drawing.Size(31, 17);
            this.rb_f.TabIndex = 5;
            this.rb_f.TabStop = true;
            this.rb_f.Text = "F";
            this.rb_f.UseVisualStyleBackColor = true;
            // 
            // rb_n
            // 
            this.rb_n.AutoSize = true;
            this.rb_n.Location = new System.Drawing.Point(120, 59);
            this.rb_n.Name = "rb_n";
            this.rb_n.Size = new System.Drawing.Size(33, 17);
            this.rb_n.TabIndex = 6;
            this.rb_n.TabStop = true;
            this.rb_n.Text = "N";
            this.rb_n.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kedvenc hobbi:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Hoki",
            "kori",
            "olvasas",
            "progi"});
            this.listBox1.Location = new System.Drawing.Point(162, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(79, 82);
            this.listBox1.TabIndex = 8;
            // 
            // tb_hobbi
            // 
            this.tb_hobbi.Location = new System.Drawing.Point(162, 113);
            this.tb_hobbi.Name = "tb_hobbi";
            this.tb_hobbi.Size = new System.Drawing.Size(79, 20);
            this.tb_hobbi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Új hobbi:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_load
            // 
            this.b_load.Location = new System.Drawing.Point(166, 188);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(75, 23);
            this.b_load.TabIndex = 12;
            this.b_load.Text = "Betöltés";
            this.b_load.UseVisualStyleBackColor = true;
            this.b_load.Click += new System.EventHandler(this.b_load_Click);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(85, 188);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 13;
            this.b_save.Text = "Mentés";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // tb_szul
            // 
            this.tb_szul.Location = new System.Drawing.Point(83, 32);
            this.tb_szul.Name = "tb_szul";
            this.tb_szul.Size = new System.Drawing.Size(70, 20);
            this.tb_szul.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 212);
            this.Controls.Add(this.tb_szul);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_load);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_hobbi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_n);
            this.Controls.Add(this.rb_f);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.RadioButton rb_f;
        private System.Windows.Forms.RadioButton rb_n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tb_hobbi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_load;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_szul;
    }
}

