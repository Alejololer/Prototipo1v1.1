namespace PlayerUI.Resultados
{
    partial class ModificarResul
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
            cmbxPedidos = new System.Windows.Forms.ComboBox();
            dgvConsultarInstrumentos = new System.Windows.Forms.DataGridView();
            lblNombreInstrumento = new System.Windows.Forms.Label();
            btnConsultarInstrumento = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarInstrumentos).BeginInit();
            SuspendLayout();
            // 
            // cmbxPedidos
            // 
            cmbxPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbxPedidos.FormattingEnabled = true;
            cmbxPedidos.Location = new System.Drawing.Point(191, 77);
            cmbxPedidos.Margin = new System.Windows.Forms.Padding(2);
            cmbxPedidos.Name = "cmbxPedidos";
            cmbxPedidos.Size = new System.Drawing.Size(484, 23);
            cmbxPedidos.TabIndex = 34;
            // 
            // dgvConsultarInstrumentos
            // 
            dgvConsultarInstrumentos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvConsultarInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarInstrumentos.Location = new System.Drawing.Point(13, 129);
            dgvConsultarInstrumentos.Margin = new System.Windows.Forms.Padding(2);
            dgvConsultarInstrumentos.Name = "dgvConsultarInstrumentos";
            dgvConsultarInstrumentos.RowHeadersWidth = 51;
            dgvConsultarInstrumentos.RowTemplate.Height = 24;
            dgvConsultarInstrumentos.Size = new System.Drawing.Size(662, 390);
            dgvConsultarInstrumentos.TabIndex = 33;
            // 
            // lblNombreInstrumento
            // 
            lblNombreInstrumento.AutoSize = true;
            lblNombreInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblNombreInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNombreInstrumento.ForeColor = System.Drawing.Color.LightGray;
            lblNombreInstrumento.Location = new System.Drawing.Point(13, 82);
            lblNombreInstrumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNombreInstrumento.Name = "lblNombreInstrumento";
            lblNombreInstrumento.Size = new System.Drawing.Size(149, 17);
            lblNombreInstrumento.TabIndex = 32;
            lblNombreInstrumento.Text = "Seleccione el examen:";
            // 
            // btnConsultarInstrumento
            // 
            btnConsultarInstrumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnConsultarInstrumento.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            btnConsultarInstrumento.FlatAppearance.BorderSize = 0;
            btnConsultarInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsultarInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnConsultarInstrumento.ForeColor = System.Drawing.Color.LightGray;
            btnConsultarInstrumento.Location = new System.Drawing.Point(501, 540);
            btnConsultarInstrumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConsultarInstrumento.Name = "btnConsultarInstrumento";
            btnConsultarInstrumento.Size = new System.Drawing.Size(175, 46);
            btnConsultarInstrumento.TabIndex = 31;
            btnConsultarInstrumento.Text = "Modificar";
            btnConsultarInstrumento.UseVisualStyleBackColor = false;
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
            btnExit.TabIndex = 30;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(235, 42, 83);
            label1.Location = new System.Drawing.Point(124, 23);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(386, 25);
            label1.TabIndex = 29;
            label1.Text = "MODIFICAR RESULTADOS DE EXAMEN";
            // 
            // ModificarResul
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(700, 600);
            Controls.Add(cmbxPedidos);
            Controls.Add(dgvConsultarInstrumentos);
            Controls.Add(lblNombreInstrumento);
            Controls.Add(btnConsultarInstrumento);
            Controls.Add(btnExit);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ModificarResul";
            Text = "ModificarResult";
            ((System.ComponentModel.ISupportInitialize)dgvConsultarInstrumentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxPedidos;
        private System.Windows.Forms.DataGridView dgvConsultarInstrumentos;
        private System.Windows.Forms.Label lblNombreInstrumento;
        private System.Windows.Forms.Button btnConsultarInstrumento;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}