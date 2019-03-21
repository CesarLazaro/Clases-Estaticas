namespace AREAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnTri = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnCir = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnRom = new System.Windows.Forms.Button();
            this.btnTrap = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.ljlk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtL1
            // 
            this.txtL1.Location = new System.Drawing.Point(47, 12);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(100, 20);
            this.txtL1.TabIndex = 0;
            this.txtL1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hipotenusa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(216, 33);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Radio";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(216, 7);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 4;
            // 
            // txtL2
            // 
            this.txtL2.Location = new System.Drawing.Point(47, 38);
            this.txtL2.Name = "txtL2";
            this.txtL2.Size = new System.Drawing.Size(100, 20);
            this.txtL2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lado";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(478, 196);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(52, 26);
            this.Area.TabIndex = 8;
            this.Area.Text = ":DD";
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Image = ((System.Drawing.Image)(resources.GetObject("btnCuadrado.Image")));
            this.btnCuadrado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuadrado.Location = new System.Drawing.Point(47, 120);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(71, 73);
            this.btnCuadrado.TabIndex = 9;
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTri
            // 
            this.btnTri.Image = ((System.Drawing.Image)(resources.GetObject("btnTri.Image")));
            this.btnTri.Location = new System.Drawing.Point(257, 120);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(83, 76);
            this.btnTri.TabIndex = 10;
            this.btnTri.UseVisualStyleBackColor = true;
            this.btnTri.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHex
            // 
            this.btnHex.Image = ((System.Drawing.Image)(resources.GetObject("btnHex.Image")));
            this.btnHex.Location = new System.Drawing.Point(363, 214);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(93, 76);
            this.btnHex.TabIndex = 11;
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCir
            // 
            this.btnCir.Image = ((System.Drawing.Image)(resources.GetObject("btnCir.Image")));
            this.btnCir.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCir.Location = new System.Drawing.Point(363, 120);
            this.btnCir.Name = "btnCir";
            this.btnCir.Size = new System.Drawing.Size(83, 78);
            this.btnCir.TabIndex = 12;
            this.btnCir.UseVisualStyleBackColor = true;
            this.btnCir.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPen
            // 
            this.btnPen.Image = ((System.Drawing.Image)(resources.GetObject("btnPen.Image")));
            this.btnPen.Location = new System.Drawing.Point(240, 211);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(100, 83);
            this.btnPen.TabIndex = 13;
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRom
            // 
            this.btnRom.Image = ((System.Drawing.Image)(resources.GetObject("btnRom.Image")));
            this.btnRom.Location = new System.Drawing.Point(151, 211);
            this.btnRom.Name = "btnRom";
            this.btnRom.Size = new System.Drawing.Size(83, 83);
            this.btnRom.TabIndex = 14;
            this.btnRom.UseVisualStyleBackColor = true;
            this.btnRom.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnTrap
            // 
            this.btnTrap.Image = ((System.Drawing.Image)(resources.GetObject("btnTrap.Image")));
            this.btnTrap.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTrap.Location = new System.Drawing.Point(32, 231);
            this.btnTrap.Name = "btnTrap";
            this.btnTrap.Size = new System.Drawing.Size(102, 63);
            this.btnTrap.TabIndex = 15;
            this.btnTrap.UseVisualStyleBackColor = true;
            this.btnTrap.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnRec
            // 
            this.btnRec.Image = ((System.Drawing.Image)(resources.GetObject("btnRec.Image")));
            this.btnRec.Location = new System.Drawing.Point(151, 134);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(83, 59);
            this.btnRec.TabIndex = 16;
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(216, 59);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 17;
            // 
            // ljlk
            // 
            this.ljlk.AutoSize = true;
            this.ljlk.Location = new System.Drawing.Point(179, 59);
            this.ljlk.Name = "ljlk";
            this.ljlk.Size = new System.Drawing.Size(34, 13);
            this.ljlk.TabIndex = 18;
            this.ljlk.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "EL AREA ES:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 60);
            this.button1.TabIndex = 21;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ljlk);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.btnTrap);
            this.Controls.Add(this.btnRom);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.btnCir);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnTri);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtL2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtL1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtL2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnTri;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnCir;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnRom;
        private System.Windows.Forms.Button btnTrap;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label ljlk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

