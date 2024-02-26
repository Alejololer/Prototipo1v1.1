namespace PlayerUI.Ventas
{
    partial class GenerarFactura
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
            btnConsultarInstrumento = new System.Windows.Forms.Button();
            lblNombreInstrumento = new System.Windows.Forms.Label();
            dgvConsultarInstrumentos = new System.Windows.Forms.DataGridView();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarInstrumentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(235, 42, 83);
            label1.Location = new System.Drawing.Point(230, 23);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(207, 25);
            label1.TabIndex = 7;
            label1.Text = "GENERAR FACTURA";
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
            // btnConsultarInstrumento
            // 
            btnConsultarInstrumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnConsultarInstrumento.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            btnConsultarInstrumento.FlatAppearance.BorderSize = 0;
            btnConsultarInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsultarInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnConsultarInstrumento.ForeColor = System.Drawing.Color.LightGray;
            btnConsultarInstrumento.Location = new System.Drawing.Point(477, 510);
            btnConsultarInstrumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConsultarInstrumento.Name = "btnConsultarInstrumento";
            btnConsultarInstrumento.Size = new System.Drawing.Size(175, 46);
            btnConsultarInstrumento.TabIndex = 15;
            btnConsultarInstrumento.Text = "Modificar";
            btnConsultarInstrumento.UseVisualStyleBackColor = false;
            btnConsultarInstrumento.Click += btnConsultarInstrumento_Click;
            // 
            // lblNombreInstrumento
            // 
            lblNombreInstrumento.AutoSize = true;
            lblNombreInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblNombreInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNombreInstrumento.ForeColor = System.Drawing.Color.LightGray;
            lblNombreInstrumento.Location = new System.Drawing.Point(43, 77);
            lblNombreInstrumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNombreInstrumento.Name = "lblNombreInstrumento";
            lblNombreInstrumento.Size = new System.Drawing.Size(135, 17);
            lblNombreInstrumento.TabIndex = 20;
            lblNombreInstrumento.Text = "Seleccione la venta:";
            lblNombreInstrumento.Click += lblNombreInstrumento_Click;
            // 
            // dgvConsultarInstrumentos
            // 
            dgvConsultarInstrumentos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvConsultarInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarInstrumentos.Location = new System.Drawing.Point(47, 130);
            dgvConsultarInstrumentos.Margin = new System.Windows.Forms.Padding(2);
            dgvConsultarInstrumentos.Name = "dgvConsultarInstrumentos";
            dgvConsultarInstrumentos.RowHeadersWidth = 51;
            dgvConsultarInstrumentos.RowTemplate.Height = 24;
            dgvConsultarInstrumentos.Size = new System.Drawing.Size(605, 346);
            dgvConsultarInstrumentos.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Previsualización de Factura 1" });
            comboBox1.Location = new System.Drawing.Point(184, 73);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(467, 23);
            comboBox1.TabIndex = 22;
            // 
            // GenerarFactura
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(700, 600);
            Controls.Add(comboBox1);
            Controls.Add(dgvConsultarInstrumentos);
            Controls.Add(lblNombreInstrumento);
            Controls.Add(btnConsultarInstrumento);
            Controls.Add(btnExit);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "GenerarFactura";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dgvConsultarInstrumentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConsultarInstrumento;
        private System.Windows.Forms.Label lblNombreInstrumento;
        private System.Windows.Forms.DataGridView dgvConsultarInstrumentos;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}