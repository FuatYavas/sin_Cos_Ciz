namespace projeödevi1
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
            txtGiris = new TextBox();
            btnMutlak = new Button();
            btnKok = new Button();
            btnMax = new Button();
            btnsin = new Button();
            btncos = new Button();
            label1 = new Label();
            btnGeri = new Button();
            groupBox1 = new GroupBox();
            btnCiz = new Button();
            radiocos = new RadioButton();
            radiosin = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtbit = new TextBox();
            txtbasla = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtGiris
            // 
            txtGiris.Location = new Point(45, 36);
            txtGiris.Name = "txtGiris";
            txtGiris.Size = new Size(261, 23);
            txtGiris.TabIndex = 0;
            txtGiris.TextChanged += txtGiris_TextChanged;
            // 
            // btnMutlak
            // 
            btnMutlak.Location = new Point(49, 105);
            btnMutlak.Name = "btnMutlak";
            btnMutlak.Size = new Size(75, 23);
            btnMutlak.TabIndex = 1;
            btnMutlak.Text = "mutlak";
            btnMutlak.UseVisualStyleBackColor = true;
            btnMutlak.Click += button1_Click;
            // 
            // btnKok
            // 
            btnKok.Location = new Point(169, 105);
            btnKok.Name = "btnKok";
            btnKok.Size = new Size(75, 23);
            btnKok.TabIndex = 2;
            btnKok.Text = "karekök";
            btnKok.UseVisualStyleBackColor = true;
            btnKok.Click += btnKok_Click;
            // 
            // btnMax
            // 
            btnMax.Location = new Point(282, 105);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(75, 23);
            btnMax.TabIndex = 3;
            btnMax.Text = "max";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnsin
            // 
            btnsin.Location = new Point(46, 180);
            btnsin.Name = "btnsin";
            btnsin.Size = new Size(75, 23);
            btnsin.TabIndex = 4;
            btnsin.Text = "sin";
            btnsin.UseVisualStyleBackColor = true;
            btnsin.Click += btnsin_Click;
            // 
            // btncos
            // 
            btncos.Location = new Point(156, 180);
            btncos.Name = "btncos";
            btncos.Size = new Size(75, 23);
            btncos.TabIndex = 5;
            btncos.Text = "cos";
            btncos.UseVisualStyleBackColor = true;
            btncos.Click += btncos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 142);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 6;
            label1.Text = "*a,b şeklinde giriniz";
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(282, 268);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 7;
            btnGeri.Text = "Geri al";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCiz);
            groupBox1.Controls.Add(radiocos);
            groupBox1.Controls.Add(radiosin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtbit);
            groupBox1.Controls.Add(txtbasla);
            groupBox1.Location = new Point(45, 366);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 153);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çizim";
            // 
            // btnCiz
            // 
            btnCiz.Location = new Point(154, 110);
            btnCiz.Name = "btnCiz";
            btnCiz.Size = new Size(75, 23);
            btnCiz.TabIndex = 8;
            btnCiz.Text = "Çiz";
            btnCiz.UseVisualStyleBackColor = true;
            btnCiz.Click += btnCiz_Click;
            // 
            // radiocos
            // 
            radiocos.AutoSize = true;
            radiocos.Location = new Point(24, 114);
            radiocos.Name = "radiocos";
            radiocos.Size = new Size(43, 19);
            radiocos.TabIndex = 6;
            radiocos.TabStop = true;
            radiocos.Text = "cos";
            radiocos.UseVisualStyleBackColor = true;
            // 
            // radiosin
            // 
            radiosin.AutoSize = true;
            radiosin.Location = new Point(24, 89);
            radiosin.Name = "radiosin";
            radiosin.Size = new Size(40, 19);
            radiosin.TabIndex = 5;
            radiosin.TabStop = true;
            radiosin.Text = "sin";
            radiosin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 53);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 4;
            label4.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 19);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Başlangıç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 19);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Bitiş";
            // 
            // txtbit
            // 
            txtbit.Location = new Point(154, 50);
            txtbit.Name = "txtbit";
            txtbit.Size = new Size(100, 23);
            txtbit.TabIndex = 1;
            // 
            // txtbasla
            // 
            txtbasla.Location = new Point(25, 50);
            txtbasla.Name = "txtbasla";
            txtbasla.Size = new Size(100, 23);
            txtbasla.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(452, 558);
            Controls.Add(groupBox1);
            Controls.Add(btnGeri);
            Controls.Add(label1);
            Controls.Add(btncos);
            Controls.Add(btnsin);
            Controls.Add(btnMax);
            Controls.Add(btnKok);
            Controls.Add(btnMutlak);
            Controls.Add(txtGiris);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGiris;
        private Button btnMutlak;
        private Button btnKok;
        private Button btnMax;
        private Button btnsin;
        private Button btncos;
        private Label label1;
        private Button btnGeri;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtbit;
        private TextBox txtbasla;
        private Button btnCiz;
        private RadioButton radiocos;
        private RadioButton radiosin;
        private Label label4;
        private Label label3;
    }
}