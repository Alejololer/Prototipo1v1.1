﻿using DataAccess.Entities;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Parametros
{
    public partial class ConsultarTipoExamen : Form
    {
        TipoExamen tipoExamen = null;
        public ConsultarTipoExamen()
        {
            InitializeComponent();
            txtValor.ReadOnly = true;
            txtNomTipo.KeyPress += OnKeyPress;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ConsultarTipoExamen_Load(object sender, EventArgs e)
        {

        }

        private void obtenerPrecio()
        {
            if (txtNomTipo.Text.Length <= 1)
            {
                MessageBox.Show("Nombre de Tipo de examen inválido!", "Modificar precio Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TipoExamenModel model = new TipoExamenModel();
            if (!model.Check(txtNomTipo.Text))
            {
                MessageBox.Show("Tipo de examen no encontrado!", "Modificar precio Tipo de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tipoExamen = model.GetTipoExamen(txtNomTipo.Text);
            txtValor.Text = tipoExamen.costoTipoExamen.ToString("#.##");
        }
        private void llenarDataGridView()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Requerimientos;Integrated Security=SSPI";
                string query = "SELECT p.IDPARAMETRO, NOMBREPARAMETRO, MINPARAMETRO, MAXPARAMETRO, UNIDADPARAMETRO" +
                    " FROM TIPOSEXAMEN te JOIN TIPOEXAMEN_PARAMETRO tep ON te.IDTIPOEXAMEN = tep.IDTIPOEXAMEN" +
                    " JOIN PARAMETROSTIPOEXAMEN p ON tep.IDPARAMETRO = p.IDPARAMETRO WHERE te.IDTIPOEXAMEN = @id";
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var consulta = new SqlCommand(query, connection))
                    {
                        consulta.Parameters.AddWithValue("@id", tipoExamen.Id);

                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(consulta))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvTipoExamen.DataSource = dt;
                            /*Formato
                            dgvUsuarios.Columns[0].HeaderText = "ID";
                            dgvUsuarios.Columns[0].Width = 50;
                            dgvUsuarios.Columns[1].HeaderText = "Nombre de Usuario";
                            dgvUsuarios.Columns[1].Width = 150;
                            dgvUsuarios.Columns[2].HeaderText = "Contraseña";
                            dgvUsuarios.Columns[3].HeaderText = "Tipo de Usuario";
                            dgvUsuarios.Columns[3].Width = 250;*/

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No se encontraron parámetros para este tipo de examen!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obtenerPrecio();
            llenarDataGridView();
        }

        private void OnKeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar switch
            {
                >= '0' and <= '9' => false, // allow numerics
                >= 'a' and <= 'z' => false, // allow lowercase characters
                >= 'A' and <= 'Z' => false, // allow uppercase characters
                '\b' => false,              // allow backspace
                '-' => false,
                '/' => false,
                _ => true
            };
        }

        private void dgvTipoExamen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
