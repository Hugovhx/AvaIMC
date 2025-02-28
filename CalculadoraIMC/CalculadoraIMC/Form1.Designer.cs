namespace CalculadoraIMC
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
            btSete = new Button();
            btOito = new Button();
            btNove = new Button();
            btQuatro = new Button();
            btCinco = new Button();
            btSeis = new Button();
            btUm = new Button();
            btDois = new Button();
            btTres = new Button();
            btVirgula = new Button();
            btZero = new Button();
            btDel = new Button();
            btCalcular = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lblSituacao = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIMC = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btSete
            // 
            btSete.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btSete.Location = new Point(29, 29);
            btSete.Name = "btSete";
            btSete.Size = new Size(69, 49);
            btSete.TabIndex = 0;
            btSete.Text = "7";
            btSete.UseVisualStyleBackColor = true;
            btSete.Click += AdicionarNumeros;
            // 
            // btOito
            // 
            btOito.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btOito.Location = new Point(106, 29);
            btOito.Name = "btOito";
            btOito.Size = new Size(72, 49);
            btOito.TabIndex = 1;
            btOito.Text = "8";
            btOito.UseVisualStyleBackColor = true;
            btOito.Click += AdicionarNumeros;
            // 
            // btNove
            // 
            btNove.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btNove.Location = new Point(184, 29);
            btNove.Name = "btNove";
            btNove.Size = new Size(66, 49);
            btNove.TabIndex = 2;
            btNove.Text = "9";
            btNove.UseVisualStyleBackColor = true;
            btNove.Click += AdicionarNumeros;
            // 
            // btQuatro
            // 
            btQuatro.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btQuatro.Location = new Point(29, 84);
            btQuatro.Name = "btQuatro";
            btQuatro.Size = new Size(69, 50);
            btQuatro.TabIndex = 3;
            btQuatro.Text = "4";
            btQuatro.UseVisualStyleBackColor = true;
            btQuatro.Click += AdicionarNumeros;
            // 
            // btCinco
            // 
            btCinco.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btCinco.Location = new Point(106, 84);
            btCinco.Name = "btCinco";
            btCinco.Size = new Size(72, 50);
            btCinco.TabIndex = 4;
            btCinco.Text = "5";
            btCinco.UseVisualStyleBackColor = true;
            btCinco.Click += AdicionarNumeros;
            // 
            // btSeis
            // 
            btSeis.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btSeis.Location = new Point(184, 84);
            btSeis.Name = "btSeis";
            btSeis.Size = new Size(66, 50);
            btSeis.TabIndex = 5;
            btSeis.Text = "6";
            btSeis.UseVisualStyleBackColor = true;
            btSeis.Click += AdicionarNumeros;
            // 
            // btUm
            // 
            btUm.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btUm.Location = new Point(29, 140);
            btUm.Name = "btUm";
            btUm.Size = new Size(71, 52);
            btUm.TabIndex = 6;
            btUm.Text = "1";
            btUm.UseVisualStyleBackColor = true;
            btUm.Click += AdicionarNumeros;
            // 
            // btDois
            // 
            btDois.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btDois.Location = new Point(106, 140);
            btDois.Name = "btDois";
            btDois.Size = new Size(72, 52);
            btDois.TabIndex = 7;
            btDois.Text = "2";
            btDois.UseVisualStyleBackColor = true;
            btDois.Click += AdicionarNumeros;
            // 
            // btTres
            // 
            btTres.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btTres.Location = new Point(184, 140);
            btTres.Name = "btTres";
            btTres.Size = new Size(66, 52);
            btTres.TabIndex = 8;
            btTres.Text = "3";
            btTres.UseVisualStyleBackColor = true;
            btTres.Click += AdicionarNumeros;
            // 
            // btVirgula
            // 
            btVirgula.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btVirgula.Location = new Point(29, 198);
            btVirgula.Name = "btVirgula";
            btVirgula.Size = new Size(71, 40);
            btVirgula.TabIndex = 9;
            btVirgula.Text = ",";
            btVirgula.UseVisualStyleBackColor = true;
            btVirgula.Click += AdicionarNumeros;
            // 
            // btZero
            // 
            btZero.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btZero.Location = new Point(106, 198);
            btZero.Name = "btZero";
            btZero.Size = new Size(72, 40);
            btZero.TabIndex = 10;
            btZero.Text = "0";
            btZero.UseVisualStyleBackColor = true;
            btZero.Click += AdicionarNumeros;
            // 
            // btDel
            // 
            btDel.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btDel.Location = new Point(184, 199);
            btDel.Name = "btDel";
            btDel.Size = new Size(66, 40);
            btDel.TabIndex = 11;
            btDel.Text = "Del";
            btDel.UseVisualStyleBackColor = true;
            btDel.Click += btDel_Click;
            // 
            // btCalcular
            // 
            btCalcular.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCalcular.Location = new Point(41, 488);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(221, 40);
            btCalcular.TabIndex = 12;
            btCalcular.Text = "Calcular Índice de Massa Corporal";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btDel);
            panel1.Controls.Add(btSete);
            panel1.Controls.Add(btQuatro);
            panel1.Controls.Add(btUm);
            panel1.Controls.Add(btVirgula);
            panel1.Controls.Add(btZero);
            panel1.Controls.Add(btTres);
            panel1.Controls.Add(btSeis);
            panel1.Controls.Add(btDois);
            panel1.Controls.Add(btNove);
            panel1.Controls.Add(btOito);
            panel1.Controls.Add(btCinco);
            panel1.Location = new Point(12, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 300);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSituacao);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtIMC);
            panel2.Controls.Add(txtAltura);
            panel2.Controls.Add(txtPeso);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 226);
            panel2.TabIndex = 14;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Enabled = false;
            lblSituacao.Font = new Font("Verdana", 18F, FontStyle.Bold);
            lblSituacao.ForeColor = SystemColors.AppWorkspace;
            lblSituacao.Location = new Point(15, 194);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(128, 29);
            lblSituacao.TabIndex = 10;
            lblSituacao.Text = "Situação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(195, 106);
            label7.Name = "label7";
            label7.Size = new Size(24, 18);
            label7.TabIndex = 9;
            label7.Text = "m";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(195, 57);
            label6.Name = "label6";
            label6.Size = new Size(31, 18);
            label6.TabIndex = 8;
            label6.Text = "Kg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(63, 160);
            label5.Name = "label5";
            label5.Size = new Size(43, 18);
            label5.TabIndex = 7;
            label5.Text = "IMC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(39, 106);
            label4.Name = "label4";
            label4.Size = new Size(61, 18);
            label4.TabIndex = 6;
            label4.Text = "Altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(49, 57);
            label3.Name = "label3";
            label3.Size = new Size(51, 18);
            label3.TabIndex = 5;
            label3.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 23);
            label2.Name = "label2";
            label2.Size = new Size(194, 16);
            label2.TabIndex = 4;
            label2.Text = "Informe seu Peso e Altura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 5);
            label1.Name = "label1";
            label1.Size = new Size(137, 18);
            label1.TabIndex = 3;
            label1.Text = "Cálculo de IMC";
            // 
            // txtIMC
            // 
            txtIMC.Location = new Point(106, 157);
            txtIMC.Name = "txtIMC";
            txtIMC.Size = new Size(84, 23);
            txtIMC.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(106, 103);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(84, 23);
            txtAltura.TabIndex = 1;
            txtAltura.Tag = "";
            txtAltura.Enter += txtAltura_Enter;
            txtAltura.Leave += txtAltura_Leave;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(106, 54);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(84, 23);
            txtPeso.TabIndex = 0;
            txtPeso.Tag = "";
            txtPeso.Enter += txtPeso_Enter;
            txtPeso.Leave += txtPeso_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(304, 556);
            Controls.Add(panel2);
            Controls.Add(btCalcular);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btSete;
        private Button btOito;
        private Button btNove;
        private Button btQuatro;
        private Button btCinco;
        private Button btSeis;
        private Button btUm;
        private Button btDois;
        private Button btTres;
        private Button btVirgula;
        private Button btZero;
        private Button btDel;
        private Button btCalcular;
        private Panel panel1;
        private Panel panel2;
        private Label lblSituacao;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIMC;
        private TextBox txtAltura;
        private TextBox txtPeso;
    }
}
