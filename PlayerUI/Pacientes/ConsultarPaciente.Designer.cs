namespace PlayerUI.Pacientes
{
    partial class ConsultarPaciente
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
            this.dgvConsultarInstrumentos = new System.Windows.Forms.DataGridView();
            this.lblNombreInstrumento = new System.Windows.Forms.Label();
            this.txtNombreInstrumento = new System.Windows.Forms.TextBox();
            this.btnConsultarPaciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarInstrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultarInstrumentos
            // 
            this.dgvConsultarInstrumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultarInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarInstrumentos.Location = new System.Drawing.Point(85, 180);
            this.dgvConsultarInstrumentos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultarInstrumentos.Name = "dgvConsultarInstrumentos";
            this.dgvConsultarInstrumentos.RowHeadersWidth = 51;
            this.dgvConsultarInstrumentos.RowTemplate.Height = 24;
            this.dgvConsultarInstrumentos.Size = new System.Drawing.Size(468, 204);
            this.dgvConsultarInstrumentos.TabIndex = 26;
            // 
            // lblNombreInstrumento
            // 
            this.lblNombreInstrumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreInstrumento.AutoSize = true;
            this.lblNombreInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInstrumento.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombreInstrumento.Location = new System.Drawing.Point(82, 122);
            this.lblNombreInstrumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreInstrumento.Name = "lblNombreInstrumento";
            this.lblNombreInstrumento.Size = new System.Drawing.Size(144, 17);
            this.lblNombreInstrumento.TabIndex = 25;
            this.lblNombreInstrumento.Text = "Nombre del Paciente:";
            this.lblNombreInstrumento.Click += new System.EventHandler(this.lblNombreInstrumento_Click);
            // 
            // txtNombreInstrumento
            // 
            this.txtNombreInstrumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreInstrumento.Location = new System.Drawing.Point(246, 121);
            this.txtNombreInstrumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreInstrumento.Name = "txtNombreInstrumento";
            this.txtNombreInstrumento.Size = new System.Drawing.Size(307, 20);
            this.txtNombreInstrumento.TabIndex = 24;
            // 
            // btnConsultarPaciente
            // 
            this.btnConsultarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnConsultarPaciente.FlatAppearance.BorderSize = 0;
            this.btnConsultarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPaciente.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsultarPaciente.Location = new System.Drawing.Point(497, 461);
            this.btnConsultarPaciente.Name = "btnConsultarPaciente";
            this.btnConsultarPaciente.Size = new System.Drawing.Size(115, 27);
            this.btnConsultarPaciente.TabIndex = 23;
            this.btnConsultarPaciente.Text = "Consultar";
            this.btnConsultarPaciente.UseVisualStyleBackColor = false;
            this.btnConsultarPaciente.Click += new System.EventHandler(this.btnConsultarPaciente_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(266, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Consultar Paciente";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LightGray;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ConsultarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvConsultarInstrumentos);
            this.Controls.Add(this.lblNombreInstrumento);
            this.Controls.Add(this.txtNombreInstrumento);
            this.Controls.Add(this.btnConsultarPaciente);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarPaciente";
            this.Text = "ConsultarPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarInstrumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarInstrumentos;
        private System.Windows.Forms.Label lblNombreInstrumento;
        private System.Windows.Forms.TextBox txtNombreInstrumento;
        private System.Windows.Forms.Button btnConsultarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}