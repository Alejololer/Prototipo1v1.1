﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            hideSubMenu();
        }
        private void customizeDesign()
        {
            panelPacientesSubMenu.Visible = false;
            panelPedidosSubMenu.Visible = false;
            panelResultadosSubMenu.Visible = false;
            panelReactivosSubMenu.Visible = false;
            panelUsuariosSubMenu.Visible = false;
            panelParámetrosSubMenu.Visible = false;
            panelVentasSubMenu.Visible = false;
            panelInstrumentosSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelPacientesSubMenu.Visible == true)
                panelPacientesSubMenu.Visible = false;

            if (panelPedidosSubMenu.Visible == true)
                panelPedidosSubMenu.Visible = false;

            if (panelResultadosSubMenu.Visible == true)
                panelResultadosSubMenu.Visible = false;

            if (panelReactivosSubMenu.Visible == true)
                panelReactivosSubMenu.Visible = false;

            if (panelUsuariosSubMenu.Visible == true)
                panelUsuariosSubMenu.Visible = false;

            if (panelParámetrosSubMenu.Visible == true)
                panelParámetrosSubMenu.Visible = false;

            if (panelVentasSubMenu.Visible == true)
                panelVentasSubMenu.Visible = false;

            if (panelInstrumentosSubMenu.Visible == true)
                panelInstrumentosSubMenu.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPacientesSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //..
            //your codes
            //..
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPedidosSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelResultadosSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelResultadosSubMenu);

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void panelPacientesSubPacientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReactivos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReactivosSubMenu);
        }

        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInstrumentosSubMenu);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVentasSubMenu);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUsuariosSubMenu);
        }

        private void btnParámetros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelParámetrosSubMenu);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
