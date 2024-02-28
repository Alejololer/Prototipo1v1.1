namespace PlayerUI.Parametros
{
    partial class RegistrarTipoExamen
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
            label1 = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            txtNomTipo = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            txtCostoTipo = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtNomPar = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtValMin = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtvalMax = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtUn = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(235, 42, 83);
            label1.Location = new System.Drawing.Point(201, 29);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(299, 25);
            label1.TabIndex = 7;
            label1.Text = "REGISTRAR TIPO DE EXAMEN";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.ForeColor = System.Drawing.Color.LightGray;
            btnExit.Location = new System.Drawing.Point(14, 14);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(29, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // button9
            // 
            button9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button9.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button9.ForeColor = System.Drawing.Color.LightGray;
            button9.Location = new System.Drawing.Point(498, 236);
            button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(175, 46);
            button9.TabIndex = 15;
            button9.Text = "Registrar";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // txtNomTipo
            // 
            txtNomTipo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNomTipo.Location = new System.Drawing.Point(259, 123);
            txtNomTipo.Margin = new System.Windows.Forms.Padding(2);
            txtNomTipo.MaxLength = 30;
            txtNomTipo.Name = "txtNomTipo";
            txtNomTipo.Size = new System.Drawing.Size(413, 23);
            txtNomTipo.TabIndex = 19;
            txtNomTipo.TextChanged += txtNomTipo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.LightGray;
            label2.Location = new System.Drawing.Point(24, 129);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(191, 17);
            label2.TabIndex = 20;
            label2.Text = "Nombre del Tipo de Examen:";
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.LightGray;
            button1.Location = new System.Drawing.Point(498, 525);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(175, 46);
            button1.TabIndex = 46;
            button1.Text = "Añadir Parámetro";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.LightGray;
            label3.Location = new System.Drawing.Point(24, 186);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(236, 17);
            label3.TabIndex = 49;
            label3.Text = "Costo del Tipo de Examen (Sin IVA):";
            // 
            // txtCostoTipo
            // 
            txtCostoTipo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCostoTipo.Location = new System.Drawing.Point(260, 182);
            txtCostoTipo.Margin = new System.Windows.Forms.Padding(2);
            txtCostoTipo.MaxLength = 30;
            txtCostoTipo.Name = "txtCostoTipo";
            txtCostoTipo.Size = new System.Drawing.Size(413, 23);
            txtCostoTipo.TabIndex = 48;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(235, 42, 83);
            label4.Location = new System.Drawing.Point(166, 298);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(369, 25);
            label4.TabIndex = 50;
            label4.Text = "PARÁMETROS DEL TIPO DE EXAMEN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.LightGray;
            label5.Location = new System.Drawing.Point(24, 358);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(155, 17);
            label5.TabIndex = 52;
            label5.Text = "Nombre del Parámetro:";
            // 
            // txtNomPar
            // 
            txtNomPar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNomPar.Location = new System.Drawing.Point(260, 354);
            txtNomPar.Margin = new System.Windows.Forms.Padding(2);
            txtNomPar.MaxLength = 30;
            txtNomPar.Name = "txtNomPar";
            txtNomPar.Size = new System.Drawing.Size(413, 23);
            txtNomPar.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.LightGray;
            label6.Location = new System.Drawing.Point(24, 403);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(216, 17);
            label6.TabIndex = 54;
            label6.Text = "Valor mínimo del Rango Normal*:";
            // 
            // txtValMin
            // 
            txtValMin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtValMin.Location = new System.Drawing.Point(260, 397);
            txtValMin.Margin = new System.Windows.Forms.Padding(2);
            txtValMin.MaxLength = 30;
            txtValMin.Name = "txtValMin";
            txtValMin.Size = new System.Drawing.Size(413, 23);
            txtValMin.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.LightGray;
            label7.Location = new System.Drawing.Point(24, 446);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(219, 17);
            label7.TabIndex = 56;
            label7.Text = "Valor máximo del Rango Normal*:";
            // 
            // txtvalMax
            // 
            txtvalMax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtvalMax.Location = new System.Drawing.Point(260, 440);
            txtvalMax.Margin = new System.Windows.Forms.Padding(2);
            txtvalMax.MaxLength = 30;
            txtvalMax.Name = "txtvalMax";
            txtvalMax.Size = new System.Drawing.Size(413, 23);
            txtvalMax.TabIndex = 55;
            txtvalMax.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.LightGray;
            label8.Location = new System.Drawing.Point(24, 489);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(170, 17);
            label8.TabIndex = 58;
            label8.Text = "Unidades del Parámetro*:";
            // 
            // txtUn
            // 
            txtUn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtUn.Location = new System.Drawing.Point(260, 483);
            txtUn.Margin = new System.Windows.Forms.Padding(2);
            txtUn.MaxLength = 30;
            txtUn.Name = "txtUn";
            txtUn.Size = new System.Drawing.Size(413, 23);
            txtUn.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(235, 42, 83);
            label9.Location = new System.Drawing.Point(24, 554);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(357, 17);
            label9.TabIndex = 59;
            label9.Text = "El valor mínimo, máximo y las unidades son opcionales*";
            // 
            // RegistrarTipoExamen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(700, 600);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtUn);
            Controls.Add(label7);
            Controls.Add(txtvalMax);
            Controls.Add(label6);
            Controls.Add(txtValMin);
            Controls.Add(label5);
            Controls.Add(txtNomPar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCostoTipo);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtNomTipo);
            Controls.Add(button9);
            Controls.Add(btnExit);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5);
            Name = "RegistrarTipoExamen";
            Text = "Form3";
            Load += RegistrarTipoExamen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtNomTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCostoTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomPar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtvalMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUn;
        private System.Windows.Forms.Label label9;
    }
}