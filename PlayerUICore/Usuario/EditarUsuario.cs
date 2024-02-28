using DataAccess.Entities;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUICore.Usuario
{
    public partial class Editar_Usuario : Form
    {
        private User user;
        public Editar_Usuario(User user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.user = user;
            txtNom.Text = user.nombreUsuario;
            txtCon.Text = user.claveUsuario;
            txtTipo.Text = user.tipoUsuario;
            txtTipo.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Está seguro?", "Actualizar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserModel userModel = new UserModel();
                if (userModel.CheckUsuario(txtNom.Text))
                {
                    MessageBox.Show("Este nombre de usuario ya esta en uso!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                userModel.ActualizarUser(user.Id, txtNom.Text, txtCon.Text);
                MessageBox.Show("Usuario editado correctamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
