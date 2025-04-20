namespace FuzzyWashingMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nudHassaslik = new NumericUpDown();
            nudMiktar = new NumericUpDown();
            nudKirlilik = new NumericUpDown();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDeterjan_1 = new TextBox();
            txtSure = new TextBox();
            txtDonusHizi = new TextBox();
            picDeterjan = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudHassaslik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKirlilik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDeterjan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 72);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Hassaslık";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(641, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Miktar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(949, 72);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Kirlilik";
            // 
            // nudHassaslik
            // 
            nudHassaslik.DecimalPlaces = 1;
            nudHassaslik.Location = new Point(288, 123);
            nudHassaslik.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudHassaslik.Name = "nudHassaslik";
            nudHassaslik.Size = new Size(60, 27);
            nudHassaslik.TabIndex = 3;
            // 
            // nudMiktar
            // 
            nudMiktar.DecimalPlaces = 1;
            nudMiktar.Location = new Point(641, 123);
            nudMiktar.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(66, 27);
            nudMiktar.TabIndex = 4;
            nudMiktar.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // nudKirlilik
            // 
            nudKirlilik.DecimalPlaces = 1;
            nudKirlilik.Location = new Point(936, 123);
            nudKirlilik.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudKirlilik.Name = "nudKirlilik";
            nudKirlilik.Size = new Size(63, 27);
            nudKirlilik.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(625, 215);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 316);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 7;
            label4.Text = "Deterjan Miktarı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(650, 307);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 8;
            label5.Text = "Süre ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(949, 307);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 9;
            label6.Text = "Dönüş Hızı";
            // 
            // txtDeterjan_1
            // 
            txtDeterjan_1.Location = new Point(279, 391);
            txtDeterjan_1.Name = "txtDeterjan_1";
            txtDeterjan_1.ReadOnly = true;
            txtDeterjan_1.Size = new Size(125, 27);
            txtDeterjan_1.TabIndex = 10;
            // 
            // txtSure
            // 
            txtSure.Location = new Point(613, 391);
            txtSure.Name = "txtSure";
            txtSure.ReadOnly = true;
            txtSure.Size = new Size(125, 27);
            txtSure.TabIndex = 11;
            // 
            // txtDonusHizi
            // 
            txtDonusHizi.Location = new Point(924, 391);
            txtDonusHizi.Name = "txtDonusHizi";
            txtDonusHizi.ReadOnly = true;
            txtDonusHizi.Size = new Size(106, 27);
            txtDonusHizi.TabIndex = 12;
            // 
            // picDeterjan
            // 
            picDeterjan.BorderStyle = BorderStyle.FixedSingle;
            picDeterjan.Location = new Point(470, 469);
            picDeterjan.Name = "picDeterjan";
            picDeterjan.Size = new Size(400, 150);
            picDeterjan.TabIndex = 13;
            picDeterjan.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 710);
            Controls.Add(picDeterjan);
            Controls.Add(txtDonusHizi);
            Controls.Add(txtSure);
            Controls.Add(txtDeterjan_1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(nudKirlilik);
            Controls.Add(nudMiktar);
            Controls.Add(nudHassaslik);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudHassaslik).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKirlilik).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDeterjan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nudHassaslik;
        private NumericUpDown nudMiktar;
        private NumericUpDown nudKirlilik;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDeterjan_1;
        private TextBox txtSure;
        private TextBox txtDonusHizi;
        private PictureBox picDeterjan;
    }
}
