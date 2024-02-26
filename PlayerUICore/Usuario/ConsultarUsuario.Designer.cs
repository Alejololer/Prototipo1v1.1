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
            txtNombreInstrumento = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnActualizarInstrumento = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(235, 42, 83);
            label1.Location = new System.Drawing.Point(228, 29);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(245, 25);
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
            btnExit.Location = new System.Drawing.Point(14, 14);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(29, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtNombreInstrumento
            // 
            txtNombreInstrumento.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNombreInstrumento.Location = new System.Drawing.Point(233, 81);
            txtNombreInstrumento.Margin = new System.Windows.Forms.Padding(2);
            txtNombreInstrumento.Name = "txtNombreInstrumento";
            txtNombreInstrumento.Size = new System.Drawing.Size(413, 23);
            txtNombreInstrumento.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.LightGray;
            label2.Location = new System.Drawing.Point(42, 81);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 17);
            label2.TabIndex = 20;
            label2.Text = "Nombre de Usuario";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(46, 138);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(602, 314);
            dataGridView1.TabIndex = 21;
            // 
            // btnActualizarInstrumento
            // 
            btnActualizarInstrumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnActualizarInstrumento.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            btnActualizarInstrumento.FlatAppearance.BorderSize = 0;
            btnActualizarInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizarInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnActualizarInstrumento.ForeColor = System.Drawing.Color.LightGray;
            btnActualizarInstrumento.Location = new System.Drawing.Point(472, 476);
            btnActualizarInstrumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnActualizarInstrumento.Name = "btnActualizarInstrumento";
            btnActualizarInstrumento.Size = new System.Drawing.Size(175, 46);
            btnActualizarInstrumento.TabIndex = 22;
            btnActualizarInstrumento.Text = "Eliminar";
            btnActualizarInstrumento.UseVisualStyleBackColor = false;
            btnActualizarInstrumento.Click += btnActualizarInstrumento_Click;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button2.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.LightGray;
            button2.Location = new System.Drawing.Point(46, 476);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(175, 46);
            button2.TabIndex = 24;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button1.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.LightGray;
            button1.Location = new System.Drawing.Point(263, 476);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(175, 46);
            button1.TabIndex = 25;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            // 
            // ConsultarUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(700, 600);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btnActualizarInstrumento);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(txtNombreInstrumento);
            Controls.Add(btnExit);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Name = "ConsultarUsuario";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNombreInstrumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizarInstrumento;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}