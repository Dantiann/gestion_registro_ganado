using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGanado
{
    public partial class lblGestionganado : Form
    {
        public lblGestionganado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo, marca, tipo, descripcion, ubicacion, propietario, pie, limpio;
            int nacimiento;
            int edad = 0;
            float peso = 0.0f, precio = 0.0f;
            const int fecha = 2023;

            codigo = txtCodigo.Text;
            marca = txtMarca.Text;
            tipo = cmbTipo.Text;
            descripcion = txtDescripcion.Text;
            ubicacion = txtUbicacion.Text;
            propietario = txtPropietario.Text;
            pie = rbnPie.Checked.ToString();
            limpio = rbnLimpio.Checked.ToString();
            nacimiento = int.Parse(txtNacimiento.Text);
            peso = float.Parse(txtPeso.Text);

            edad = fecha - nacimiento;
           
            if (rbnPie.Checked)
            {
                precio = 20000 * peso;
            }
            else if (rbnLimpio.Checked)
            {
                precio = 40000 * peso;
            }


            dgvGestionganado.Rows.Add(codigo, marca, tipo, descripcion, nacimiento, edad, peso, precio, ubicacion, propietario, pie, limpio);

         
            txtCodigo.Text = "";
            txtMarca.Text = "";
            cmbTipo.Text = "";
            txtDescripcion.Text = "";
            txtUbicacion.Text = "";
            txtPropietario.Text = "";
            txtNacimiento.Text = "";
            txtPeso.Text = "";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvGestionganado.Rows.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtPropietario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUbicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void lblUbicacion_Click(object sender, EventArgs e)
        {

        }

        private void lblPropietario_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void lblGestiondeganado_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbnPie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnLimpio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
