namespace TP01_200581
{
    partial class FrmPrincipal
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
            this.GpBControl = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblR1 = new System.Windows.Forms.Label();
            this.LblR2 = new System.Windows.Forms.Label();
            this.LblR3 = new System.Windows.Forms.Label();
            this.TxtR1 = new System.Windows.Forms.TextBox();
            this.TxtR2 = new System.Windows.Forms.TextBox();
            this.TxtR3 = new System.Windows.Forms.TextBox();
            this.LblSimbolOhm1 = new System.Windows.Forms.Label();
            this.LblSimbolOhm2 = new System.Windows.Forms.Label();
            this.LblSimbolOhm3 = new System.Windows.Forms.Label();
            this.LblCircuitoDelta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCalculoR4 = new System.Windows.Forms.Label();
            this.LblCalculoR5 = new System.Windows.Forms.Label();
            this.LblCalculoR6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GpBControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpBControl
            // 
            this.GpBControl.BackColor = System.Drawing.Color.SeaShell;
            this.GpBControl.Controls.Add(this.BtnExit);
            this.GpBControl.Controls.Add(this.BtnClear);
            this.GpBControl.Controls.Add(this.BtnCalculate);
            this.GpBControl.Location = new System.Drawing.Point(6, 191);
            this.GpBControl.Name = "GpBControl";
            this.GpBControl.Size = new System.Drawing.Size(383, 55);
            this.GpBControl.TabIndex = 0;
            this.GpBControl.TabStop = false;
            this.GpBControl.Text = "Área de Controle";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(288, 19);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(80, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Sair";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.LightGray;
            this.BtnClear.Location = new System.Drawing.Point(151, 19);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Limpar";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.Silver;
            this.BtnCalculate.Location = new System.Drawing.Point(16, 19);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "Calcular";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.GhostWhite;
            this.LblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(48, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(305, 19);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Conversor de Circuito Delta para Circiuto Y";
            // 
            // LblR1
            // 
            this.LblR1.AutoSize = true;
            this.LblR1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR1.Location = new System.Drawing.Point(19, 77);
            this.LblR1.Name = "LblR1";
            this.LblR1.Size = new System.Drawing.Size(28, 16);
            this.LblR1.TabIndex = 2;
            this.LblR1.Text = "R1:";
            // 
            // LblR2
            // 
            this.LblR2.AutoSize = true;
            this.LblR2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR2.Location = new System.Drawing.Point(19, 122);
            this.LblR2.Name = "LblR2";
            this.LblR2.Size = new System.Drawing.Size(28, 16);
            this.LblR2.TabIndex = 3;
            this.LblR2.Text = "R2:";
            // 
            // LblR3
            // 
            this.LblR3.AutoSize = true;
            this.LblR3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR3.Location = new System.Drawing.Point(19, 161);
            this.LblR3.Name = "LblR3";
            this.LblR3.Size = new System.Drawing.Size(28, 16);
            this.LblR3.TabIndex = 4;
            this.LblR3.Text = "R3:";
            // 
            // TxtR1
            // 
            this.TxtR1.Location = new System.Drawing.Point(61, 73);
            this.TxtR1.Name = "TxtR1";
            this.TxtR1.Size = new System.Drawing.Size(46, 20);
            this.TxtR1.TabIndex = 5;
            // 
            // TxtR2
            // 
            this.TxtR2.Location = new System.Drawing.Point(61, 118);
            this.TxtR2.Name = "TxtR2";
            this.TxtR2.Size = new System.Drawing.Size(46, 20);
            this.TxtR2.TabIndex = 6;
            // 
            // TxtR3
            // 
            this.TxtR3.Location = new System.Drawing.Point(61, 160);
            this.TxtR3.Name = "TxtR3";
            this.TxtR3.Size = new System.Drawing.Size(46, 20);
            this.TxtR3.TabIndex = 7;
            this.TxtR3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LblSimbolOhm1
            // 
            this.LblSimbolOhm1.AutoSize = true;
            this.LblSimbolOhm1.Location = new System.Drawing.Point(113, 73);
            this.LblSimbolOhm1.Name = "LblSimbolOhm1";
            this.LblSimbolOhm1.Size = new System.Drawing.Size(16, 13);
            this.LblSimbolOhm1.TabIndex = 8;
            this.LblSimbolOhm1.Text = "Ω";
            // 
            // LblSimbolOhm2
            // 
            this.LblSimbolOhm2.AutoSize = true;
            this.LblSimbolOhm2.Location = new System.Drawing.Point(113, 122);
            this.LblSimbolOhm2.Name = "LblSimbolOhm2";
            this.LblSimbolOhm2.Size = new System.Drawing.Size(16, 13);
            this.LblSimbolOhm2.TabIndex = 9;
            this.LblSimbolOhm2.Text = "Ω";
            // 
            // LblSimbolOhm3
            // 
            this.LblSimbolOhm3.AutoSize = true;
            this.LblSimbolOhm3.Location = new System.Drawing.Point(113, 167);
            this.LblSimbolOhm3.Name = "LblSimbolOhm3";
            this.LblSimbolOhm3.Size = new System.Drawing.Size(16, 13);
            this.LblSimbolOhm3.TabIndex = 10;
            this.LblSimbolOhm3.Text = "Ω";
            // 
            // LblCircuitoDelta
            // 
            this.LblCircuitoDelta.AutoSize = true;
            this.LblCircuitoDelta.BackColor = System.Drawing.Color.GhostWhite;
            this.LblCircuitoDelta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCircuitoDelta.Location = new System.Drawing.Point(30, 39);
            this.LblCircuitoDelta.Name = "LblCircuitoDelta";
            this.LblCircuitoDelta.Size = new System.Drawing.Size(86, 16);
            this.LblCircuitoDelta.TabIndex = 11;
            this.LblCircuitoDelta.Text = "Circuito Delta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "R4:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "R5:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "R6:";
            // 
            // LblCalculoR4
            // 
            this.LblCalculoR4.AutoSize = true;
            this.LblCalculoR4.Location = new System.Drawing.Point(257, 75);
            this.LblCalculoR4.Name = "LblCalculoR4";
            this.LblCalculoR4.Size = new System.Drawing.Size(0, 13);
            this.LblCalculoR4.TabIndex = 15;
            // 
            // LblCalculoR5
            // 
            this.LblCalculoR5.AutoSize = true;
            this.LblCalculoR5.Location = new System.Drawing.Point(255, 124);
            this.LblCalculoR5.Name = "LblCalculoR5";
            this.LblCalculoR5.Size = new System.Drawing.Size(0, 13);
            this.LblCalculoR5.TabIndex = 16;
            // 
            // LblCalculoR6
            // 
            this.LblCalculoR6.AutoSize = true;
            this.LblCalculoR6.Location = new System.Drawing.Point(253, 164);
            this.LblCalculoR6.Name = "LblCalculoR6";
            this.LblCalculoR6.Size = new System.Drawing.Size(0, 13);
            this.LblCalculoR6.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Circuito Convertido para Y";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(401, 258);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblCalculoR6);
            this.Controls.Add(this.LblCalculoR5);
            this.Controls.Add(this.LblCalculoR4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblCircuitoDelta);
            this.Controls.Add(this.LblSimbolOhm3);
            this.Controls.Add(this.LblSimbolOhm2);
            this.Controls.Add(this.LblSimbolOhm1);
            this.Controls.Add(this.TxtR3);
            this.Controls.Add(this.TxtR2);
            this.Controls.Add(this.TxtR1);
            this.Controls.Add(this.LblR3);
            this.Controls.Add(this.LblR2);
            this.Controls.Add(this.LblR1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GpBControl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmPrincipal";
            this.Text = "Conversor de Circuitos";
            this.GpBControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GpBControl;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblR1;
        private System.Windows.Forms.Label LblR2;
        private System.Windows.Forms.Label LblR3;
        private System.Windows.Forms.TextBox TxtR1;
        private System.Windows.Forms.TextBox TxtR2;
        private System.Windows.Forms.TextBox TxtR3;
        private System.Windows.Forms.Label LblSimbolOhm1;
        private System.Windows.Forms.Label LblSimbolOhm2;
        private System.Windows.Forms.Label LblSimbolOhm3;
        private System.Windows.Forms.Label LblCircuitoDelta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCalculoR4;
        private System.Windows.Forms.Label LblCalculoR5;
        private System.Windows.Forms.Label LblCalculoR6;
        private System.Windows.Forms.Label label4;
    }
}

