﻿namespace PlayerUI.Ventas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConsultarInstrumento = new System.Windows.Forms.Button();
            this.lblNombreInstrumento = new System.Windows.Forms.Label();
            this.dgvConsultarInstrumentos = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarInstrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(214, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "GENERAR FACTURA";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LightGray;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConsultarInstrumento
            // 
            this.btnConsultarInstrumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarInstrumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnConsultarInstrumento.FlatAppearance.BorderSize = 0;
            this.btnConsultarInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarInstrumento.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsultarInstrumento.Location = new System.Drawing.Point(493, 436);
            this.btnConsultarInstrumento.Name = "btnConsultarInstrumento";
            this.btnConsultarInstrumento.Size = new System.Drawing.Size(150, 40);
            this.btnConsultarInstrumento.TabIndex = 15;
            this.btnConsultarInstrumento.Text = "Modificar";
            this.btnConsultarInstrumento.UseVisualStyleBackColor = false;
            this.btnConsultarInstrumento.Click += new System.EventHandler(this.btnConsultarInstrumento_Click);
            // 
            // lblNombreInstrumento
            // 
            this.lblNombreInstrumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreInstrumento.AutoSize = true;
            this.lblNombreInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInstrumento.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombreInstrumento.Location = new System.Drawing.Point(37, 67);
            this.lblNombreInstrumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreInstrumento.Name = "lblNombreInstrumento";
            this.lblNombreInstrumento.Size = new System.Drawing.Size(269, 17);
            this.lblNombreInstrumento.TabIndex = 20;
            this.lblNombreInstrumento.Text = "Selecciona la previsualización de factura:";
            // 
            // dgvConsultarInstrumentos
            // 
            this.dgvConsultarInstrumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultarInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarInstrumentos.Location = new System.Drawing.Point(40, 113);
            this.dgvConsultarInstrumentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConsultarInstrumentos.Name = "dgvConsultarInstrumentos";
            this.dgvConsultarInstrumentos.RowHeadersWidth = 51;
            this.dgvConsultarInstrumentos.RowTemplate.Height = 24;
            this.dgvConsultarInstrumentos.Size = new System.Drawing.Size(603, 294);
            this.dgvConsultarInstrumentos.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Previsualización de Factura 1"});
            this.comboBox1.Location = new System.Drawing.Point(311, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // GenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 514);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvConsultarInstrumentos);
            this.Controls.Add(this.lblNombreInstrumento);
            this.Controls.Add(this.btnConsultarInstrumento);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerarFactura";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarInstrumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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