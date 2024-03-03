﻿using DataAccess.Entities;
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
        private bool mostrarTexto = false;

        private User user;
        public Editar_Usuario(User user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.user = user;
            txtNom.Text = user.nombreUsuario;
            txtNom.ReadOnly = true;
            txtCon.Text = user.claveUsuario;
            txtTipo.Text = user.tipoUsuario;
            txtTipo.ReadOnly = true;
            btnMostrar.MouseDown += buttonMostrar_MouseDown;
            btnMostrar.MouseUp += buttonMostrar_MouseUp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro?", "Actualizar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserModel userModel = new UserModel();
                
                userModel.ActualizarUser(user.Id, txtCon.Text);
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

        private void buttonMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            mostrarTexto = true; // Mostrar el texto
            MostrarOcultarTexto();
        }

        private void buttonMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            mostrarTexto = false; // Ocultar el texto
            MostrarOcultarTexto();
        }

        private void MostrarOcultarTexto()
        {
            if (mostrarTexto)
            {
                txtCon.PasswordChar = '\0'; // Mostrar el texto sin enmascarar
            }
            else
            {
                txtCon.PasswordChar = '*'; // Enmascarar el texto
            }
        }
    }
}
