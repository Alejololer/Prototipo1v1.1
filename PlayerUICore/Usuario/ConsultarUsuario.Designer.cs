namespace PlayerUI.Usuario
{
    partial class ConsultarUsuario
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
            txtNombreUsuario = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            dgvUsuarios = new System.Windows.Forms.DataGridView();
            btnEliminar = new System.Windows.Forms.Button();
            btnConsultar = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(235, 42, 83);
            label1.Location = new System.Drawing.Point(261, 39);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(304, 29);
            label1.TabIndex = 7;
            label1.Text = "CONSULTAR USUARIOS";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.ForeColor = System.Drawing.Color.LightGray;
            btnExit.Location = new System.Drawing.Point(16, 19);
            btnExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(33, 39);
            btnExit.TabIndex = 14;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNombreUsuario.Location = new System.Drawing.Point(266, 108);
            txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new System.Drawing.Size(471, 27);
            txtNombreUsuario.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.LightGray;
            label2.Location = new System.Drawing.Point(48, 108);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(154, 20);
            label2.TabIndex = 20;
            label2.Text = "Nombre de Usuario";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new System.Drawing.Point(53, 184);
            dgvUsuarios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new System.Drawing.Size(688, 419);
            dgvUsuarios.TabIndex = 21;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEliminar.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = System.Drawing.Color.LightGray;
            btnEliminar.Location = new System.Drawing.Point(539, 635);
            btnEliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(200, 61);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnConsultar.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = System.Drawing.Color.LightGray;
            btnConsultar.Location = new System.Drawing.Point(53, 635);
            btnConsultar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(200, 61);
            btnConsultar.TabIndex = 24;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button1.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.LightGray;
            button1.Location = new System.Drawing.Point(301, 635);
            button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(200, 61);
            button1.TabIndex = 25;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            // 
            // ConsultarUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(800, 800);
            Controls.Add(button1);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvUsuarios);
            Controls.Add(label2);
            Controls.Add(txtNombreUsuario);
            Controls.Add(btnExit);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "ConsultarUsuario";
            Text = "Form3";
            Load += ConsultarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button button1;
    }
}