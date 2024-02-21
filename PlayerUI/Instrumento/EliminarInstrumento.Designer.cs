﻿namespace PlayerUI.Instrumento
{
    partial class EliminarInstrumento
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
            this.lblInstrumento = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnActualizarInstrumento = new System.Windows.Forms.Button();
            this.txtNombreInstrumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lblInstrumento.Location = new System.Drawing.Point(350, 25);
            this.lblInstrumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(212, 29);
            this.lblInstrumento.TabIndex = 7;
            this.lblInstrumento.Text = "INSTRUMENTOS";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LightGray;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 31);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnActualizarInstrumento
            // 
            this.btnActualizarInstrumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarInstrumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnActualizarInstrumento.FlatAppearance.BorderSize = 0;
            this.btnActualizarInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarInstrumento.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizarInstrumento.Location = new System.Drawing.Point(650, 432);
            this.btnActualizarInstrumento.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarInstrumento.Name = "btnActualizarInstrumento";
            this.btnActualizarInstrumento.Size = new System.Drawing.Size(200, 49);
            this.btnActualizarInstrumento.TabIndex = 15;
            this.btnActualizarInstrumento.Text = "Eliminar";
            this.btnActualizarInstrumento.UseVisualStyleBackColor = false;
            this.btnActualizarInstrumento.Click += new System.EventHandler(this.btnActualizarInstrumento_Click);
            // 
            // txtNombreInstrumento
            // 
            this.txtNombreInstrumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreInstrumento.Location = new System.Drawing.Point(266, 132);
            this.txtNombreInstrumento.Name = "txtNombreInstrumento";
            this.txtNombreInstrumento.Size = new System.Drawing.Size(584, 22);
            this.txtNombreInstrumento.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(48, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre Instrumento";
            // 
            // txtCantidadEntrada
            // 
            this.txtCantidadEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidadEntrada.Location = new System.Drawing.Point(266, 232);
            this.txtCantidadEntrada.Name = "txtCantidadEntrada";
            this.txtCantidadEntrada.Size = new System.Drawing.Size(584, 22);
            this.txtCantidadEntrada.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(48, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad de entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(48, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cantidad de salida";
            // 
            // txtCantidadSalida
            // 
            this.txtCantidadSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidadSalida.Location = new System.Drawing.Point(266, 332);
            this.txtCantidadSalida.Name = "txtCantidadSalida";
            this.txtCantidadSalida.Size = new System.Drawing.Size(584, 22);
            this.txtCantidadSalida.TabIndex = 23;
            // 
            // EliminarInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(912, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidadEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreInstrumento);
            this.Controls.Add(this.btnActualizarInstrumento);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblInstrumento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EliminarInstrumento";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInstrumento;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnActualizarInstrumento;
        private System.Windows.Forms.TextBox txtNombreInstrumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadSalida;
    }
}