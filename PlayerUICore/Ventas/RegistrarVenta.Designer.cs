namespace PlayerUI.Ventas
{
    partial class RegistrarVenta
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
            txtCI = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            txtTotal = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarInstrumentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(235, 42, 83);
            label1.Location = new System.Drawing.Point(245, 23);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(180, 25);
            label1.TabIndex = 7;
            label1.Text = "GENERAR VENTA";
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
            btnConsultarInstrumento.Location = new System.Drawing.Point(508, 510);
            btnConsultarInstrumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConsultarInstrumento.Name = "btnConsultarInstrumento";
            btnConsultarInstrumento.Size = new System.Drawing.Size(138, 46);
            btnConsultarInstrumento.TabIndex = 15;
            btnConsultarInstrumento.Text = "Registrar";
            btnConsultarInstrumento.UseVisualStyleBackColor = false;
            btnConsultarInstrumento.Click += btnConsultarInstrumento_Click;
            // 
            // lblNombreInstrumento
            // 
            lblNombreInstrumento.AutoSize = true;
            lblNombreInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblNombreInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNombreInstrumento.ForeColor = System.Drawing.Color.LightGray;
            lblNombreInstrumento.Location = new System.Drawing.Point(42, 83);
            lblNombreInstrumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNombreInstrumento.Name = "lblNombreInstrumento";
            lblNombreInstrumento.Size = new System.Drawing.Size(192, 17);
            lblNombreInstrumento.TabIndex = 20;
            lblNombreInstrumento.Text = "Ingrese el número de cédula:";
            // 
            // dgvConsultarInstrumentos
            // 
            dgvConsultarInstrumentos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvConsultarInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarInstrumentos.Location = new System.Drawing.Point(46, 137);
            dgvConsultarInstrumentos.Margin = new System.Windows.Forms.Padding(2);
            dgvConsultarInstrumentos.Name = "dgvConsultarInstrumentos";
            dgvConsultarInstrumentos.RowHeadersWidth = 51;
            dgvConsultarInstrumentos.RowTemplate.Height = 24;
            dgvConsultarInstrumentos.Size = new System.Drawing.Size(599, 283);
            dgvConsultarInstrumentos.TabIndex = 21;
            // 
            // txtCI
            // 
            txtCI.Location = new System.Drawing.Point(239, 77);
            txtCI.MaxLength = 10;
            txtCI.Name = "txtCI";
            txtCI.Size = new System.Drawing.Size(262, 23);
            txtCI.TabIndex = 22;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.LightGray;
            button1.Location = new System.Drawing.Point(508, 63);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(137, 37);
            button1.TabIndex = 23;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(218, 472);
            txtTotal.MaxLength = 10;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(428, 23);
            txtTotal.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.LightGray;
            label2.Location = new System.Drawing.Point(49, 478);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(154, 17);
            label2.TabIndex = 24;
            label2.Text = "Total Venta (CON IVA):";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(217, 432);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(428, 23);
            textBox1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.LightGray;
            label3.Location = new System.Drawing.Point(48, 438);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(146, 17);
            label3.TabIndex = 26;
            label3.Text = "Total Venta (SIN IVA):";
            // 
            // RegistrarVenta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(700, 600);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtCI);
            Controls.Add(dgvConsultarInstrumentos);
            Controls.Add(lblNombreInstrumento);
            Controls.Add(btnConsultarInstrumento);
            Controls.Add(btnExit);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RegistrarVenta";
            Text = "Form3";
            Load += RegistrarVenta_Load;
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
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}