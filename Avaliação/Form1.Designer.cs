namespace Avaliação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            panel1 = new Panel();
            btCalcular = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtIMC = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(36, 333);
            button1.Name = "button1";
            button1.Size = new Size(63, 45);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AdicionarNumeros;
            // 
            // btDel
            // 
            btDel.Location = new Point(208, 486);
            btDel.Name = "btDel";
            btDel.Size = new Size(63, 45);
            btDel.TabIndex = 1;
            btDel.Text = "Del";
            btDel.UseVisualStyleBackColor = true;
            btDel.Click += AdicionarNumeros;
            // 
            // button3
            // 
            button3.Location = new Point(123, 486);
            button3.Name = "button3";
            button3.Size = new Size(63, 45);
            button3.TabIndex = 2;
            button3.Text = "0";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AdicionarNumeros;
            // 
            // button4
            // 
            button4.Location = new Point(36, 486);
            button4.Name = "button4";
            button4.Size = new Size(63, 45);
            button4.TabIndex = 3;
            button4.Text = ",";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AdicionarNumeros;
            // 
            // button5
            // 
            button5.Location = new Point(123, 331);
            button5.Name = "button5";
            button5.Size = new Size(63, 45);
            button5.TabIndex = 4;
            button5.Text = "2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += AdicionarNumeros;
            // 
            // button6
            // 
            button6.Location = new Point(208, 435);
            button6.Name = "button6";
            button6.Size = new Size(63, 45);
            button6.TabIndex = 5;
            button6.Text = "9";
            button6.UseVisualStyleBackColor = true;
            button6.Click += AdicionarNumeros;
            // 
            // button7
            // 
            button7.Location = new Point(123, 435);
            button7.Name = "button7";
            button7.Size = new Size(63, 45);
            button7.TabIndex = 6;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += AdicionarNumeros;
            // 
            // button8
            // 
            button8.Location = new Point(36, 435);
            button8.Name = "button8";
            button8.Size = new Size(63, 45);
            button8.TabIndex = 7;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += AdicionarNumeros;
            // 
            // button9
            // 
            button9.Location = new Point(208, 384);
            button9.Name = "button9";
            button9.Size = new Size(63, 45);
            button9.TabIndex = 8;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = true;
            button9.Click += AdicionarNumeros;
            // 
            // button10
            // 
            button10.Location = new Point(110, 64);
            button10.Name = "button10";
            button10.Size = new Size(63, 45);
            button10.TabIndex = 9;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += AdicionarNumeros;
            // 
            // button11
            // 
            button11.Location = new Point(36, 384);
            button11.Name = "button11";
            button11.Size = new Size(63, 45);
            button11.TabIndex = 10;
            button11.Text = "4";
            button11.UseVisualStyleBackColor = true;
            button11.Click += AdicionarNumeros;
            // 
            // button12
            // 
            button12.Location = new Point(208, 333);
            button12.Name = "button12";
            button12.Size = new Size(63, 45);
            button12.TabIndex = 11;
            button12.Text = "3";
            button12.UseVisualStyleBackColor = true;
            button12.Click += AdicionarNumeros;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btCalcular);
            panel1.Controls.Add(button10);
            panel1.Location = new Point(13, 318);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 280);
            panel1.TabIndex = 12;
            // 
            // btCalcular
            // 
            btCalcular.BackColor = Color.Transparent;
            btCalcular.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCalcular.Location = new Point(18, 219);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(240, 45);
            btCalcular.TabIndex = 14;
            btCalcular.Text = "Calcular Índice de Massa Corporal";
            btCalcular.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txtIMC);
            panel2.Controls.Add(txtAltura);
            panel2.Controls.Add(txtPeso);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 300);
            panel2.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 139);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtIMC
            // 
            txtIMC.Location = new Point(93, 187);
            txtIMC.Name = "txtIMC";
            txtIMC.Size = new Size(86, 23);
            txtIMC.TabIndex = 10;
            txtIMC.TextChanged += txtIMC_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(93, 146);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(86, 23);
            txtAltura.TabIndex = 9;
            txtAltura.TextChanged += txtAltura_TextChanged;
            txtAltura.Enter += AlturaEnter;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.WhiteSmoke;
            txtPeso.ForeColor = Color.Black;
            txtPeso.Location = new Point(93, 106);
            txtPeso.Name = "txtPeso";
            txtPeso.RightToLeft = RightToLeft.No;
            txtPeso.Size = new Size(86, 23);
            txtPeso.TabIndex = 8;
            txtPeso.TextChanged += txtPeso_TextChanged;
            txtPeso.Enter += PesoEnter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(19, 269);
            label8.Name = "label8";
            label8.Size = new Size(68, 16);
            label8.TabIndex = 7;
            label8.Text = "Situação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(45, 108);
            label7.Name = "label7";
            label7.Size = new Size(42, 16);
            label7.TabIndex = 6;
            label7.Text = "Peso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(37, 146);
            label6.Name = "label6";
            label6.Size = new Size(50, 16);
            label6.TabIndex = 5;
            label6.Text = "Altura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(52, 187);
            label5.Name = "label5";
            label5.Size = new Size(35, 16);
            label5.TabIndex = 4;
            label5.Text = "IMC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(196, 146);
            label4.Name = "label4";
            label4.Size = new Size(21, 16);
            label4.TabIndex = 3;
            label4.Text = "m";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(196, 108);
            label3.Name = "label3";
            label3.Size = new Size(24, 16);
            label3.TabIndex = 2;
            label3.Text = "kg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(32, 41);
            label2.Name = "label2";
            label2.Size = new Size(198, 16);
            label2.TabIndex = 1;
            label2.Text = "Informe seu Peso e Altura ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 12);
            label1.Name = "label1";
            label1.Size = new Size(211, 29);
            label1.TabIndex = 0;
            label1.Text = "Cálculo de IMC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(303, 610);
            Controls.Add(panel2);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btDel);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "CalculadoraIMC";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btDel;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtIMC;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Button btCalcular;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
