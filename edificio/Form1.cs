using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace edificio
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirImagen();
        }

        private void AbrirImagen()
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            if(Abrir.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(Abrir.FileName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void GuardarImagen(string pictureCode)
        {
           

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DAL.Propietario propietario = new DAL.Propietario();

            propietario.Nombre = txtNombre.Text;
            propietario.Apaterno = txtAPaterno.Text;
            propietario.Amaterno = txtAMaterno.Text;
            propietario.Ci = txtCi.Text;
            propietario.Genero = comboBox1.Text;
            propietario.Telefono = txtTelefono.Text;
            propietario.FechaNacimiento = dateTimePicker1.Value;

            BRL.PropietarioBRL.registroPropietario(propietario);
            MessageBox.Show("Registro exitoso");
            this.Close();
        }



        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Validar.SoloLetras(e, sender);
        }

        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Validar.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Validar.SoloNumeros(e);
        }

        private void txtAPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Validar.SoloLetras(e, sender);
        }

        private void txtAMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Validar.SoloLetras(e, sender);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Buscar p = new Buscar();
            p.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
