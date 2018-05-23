using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edificio
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void lblAPaterno_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            llenarData();
            buttonsfalse();
        }

        public void llenarData()
        {
            //MessageBox.Show(nombre +"  "+ idTipo +"  "+ idClasificacion,"Prueba");

            dataGridView1.DataSource = BRL.PropietarioBRL.Propietarios();
            //dataGridViewBuscar.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "A. Paterno";
            dataGridView1.Columns[3].HeaderText = "A. Materno";
            dataGridView1.Columns[4].HeaderText = "Telefono";
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = dataGridView1.CurrentCell.RowIndex;
                id_propietario.Text = Convert.ToString(dataGridView1.Rows[Index].Cells[0].Value);
                //txtMNombre.Text = Convert.ToString(dataGridView1.CurrentCell.RowIndex);
                DAL.Propietario p = BRL.PropietarioBRL.buscarPropietario(id_propietario.Text);
                txtMNombre.Text = p.Nombre;
                txtMAPaterno.Text = p.Apaterno;
                txtMAMaterno.Text = p.Amaterno;
                txtMCi.Text = p.Ci;
                txtMTelefono.Text = p.Telefono;
                comboBox1.Text = p.Genero;
                dateTimePicker1.Value = p.FechaNacimiento;
                buttonstrue();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un propietario");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DAL.Propietario propietario = new DAL.Propietario();

            propietario.Id = Convert.ToInt32(id_propietario.Text);
            propietario.Nombre = txtMNombre.Text;
            propietario.Apaterno = txtMAPaterno.Text;
            propietario.Amaterno = txtMAMaterno.Text;
            propietario.Ci = txtMCi.Text;
            propietario.Genero = comboBox1.Text;
            propietario.Telefono = txtMTelefono.Text;
            propietario.FechaNacimiento = dateTimePicker1.Value;

            BRL.PropietarioBRL.ActualizarPropietario(propietario);
            MessageBox.Show("Registro Actualizado");
            llenarData();
            vaciarText();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Esta seguro de eliminar al Propietario " + txtMNombre.Text, "Alerta", MessageBoxButtons.YesNo);
            if(msg==DialogResult.Yes)
            {
                BRL.PropietarioBRL.eliminarPropietario(id_propietario.Text);
                MessageBox.Show("Registro Eliminado");
                llenarData();
                vaciarText();
            }
            else if (msg == DialogResult.No)
            {

            }

        }

        void buttonstrue()
        {
            btnMCancelar.Enabled = true;
            btnModificar.Enabled = true;
            btnUpdate.Enabled = true;
        }
        void buttonsfalse()
        {
            btnMCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnUpdate.Enabled = false;
        }
        void vaciarText()
        {
            txtMNombre.Text = "";
            txtMAPaterno.Text = "";
            txtMAMaterno.Text = "";
            txtMCi.Text = "";
            txtMTelefono.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            id_propietario.Text = "";
            buttonsfalse();
        }

        private void btnMCancelar_Click(object sender, EventArgs e)
        {
            vaciarText();
            buttonsfalse();
        }

        void filterData()
        {
            //MessageBox.Show(nombre +"  "+ idTipo +"  "+ idClasificacion,"Prueba");

            dataGridView1.DataSource = BRL.PropietarioBRL.filterPropietarios(txtBuscarPropietario.Text);
            //dataGridViewBuscar.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "A. Paterno";
            dataGridView1.Columns[3].HeaderText = "A. Materno";
            dataGridView1.Columns[4].HeaderText = "Telefono";
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
        }
        private void txtBuscarPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterData();
        }

        private void txtMNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Validar.SoloLetras(e, sender);
        }

        private void txtMAPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Validar.SoloLetras(e, sender);
        }

        private void txtMAMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Validar.SoloLetras(e, sender);
        }

        private void txtMCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Validar.SoloNumeros(e);
        }

        private void txtMTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Validar.SoloNumeros(e);
        }
    }
}
