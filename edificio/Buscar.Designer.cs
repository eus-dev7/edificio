namespace edificio
{
    partial class Buscar
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
            this.lblBuscar1 = new System.Windows.Forms.Label();
            this.txtBuscarPropietario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMTelefono = new System.Windows.Forms.TextBox();
            this.txtMCi = new System.Windows.Forms.TextBox();
            this.txtMAMaterno = new System.Windows.Forms.TextBox();
            this.txtMAPaterno = new System.Windows.Forms.TextBox();
            this.txtMNombre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnModificarFoto = new System.Windows.Forms.Button();
            this.lblModificarFechaNac = new System.Windows.Forms.Label();
            this.lblModificarTelefono = new System.Windows.Forms.Label();
            this.lblModificarGenero = new System.Windows.Forms.Label();
            this.lblModificarCi = new System.Windows.Forms.Label();
            this.lblModificarAMaterno = new System.Windows.Forms.Label();
            this.lblModificarAPaterno = new System.Windows.Forms.Label();
            this.lblModificarNombre = new System.Windows.Forms.Label();
            this.id_propietario = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar1
            // 
            this.lblBuscar1.AutoSize = true;
            this.lblBuscar1.Location = new System.Drawing.Point(14, 28);
            this.lblBuscar1.Name = "lblBuscar1";
            this.lblBuscar1.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar1.TabIndex = 0;
            this.lblBuscar1.Text = "Buscar";
            // 
            // txtBuscarPropietario
            // 
            this.txtBuscarPropietario.Location = new System.Drawing.Point(77, 25);
            this.txtBuscarPropietario.Name = "txtBuscarPropietario";
            this.txtBuscarPropietario.Size = new System.Drawing.Size(234, 20);
            this.txtBuscarPropietario.TabIndex = 1;
            this.txtBuscarPropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarPropietario_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 208);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnMCancelar
            // 
            this.btnMCancelar.Location = new System.Drawing.Point(474, 264);
            this.btnMCancelar.Name = "btnMCancelar";
            this.btnMCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnMCancelar.TabIndex = 37;
            this.btnMCancelar.Text = "Cancelar";
            this.btnMCancelar.UseVisualStyleBackColor = true;
            this.btnMCancelar.Click += new System.EventHandler(this.btnMCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(17, 270);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Modificar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(555, 264);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Eliminar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(594, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 69);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(594, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // txtMTelefono
            // 
            this.txtMTelefono.Location = new System.Drawing.Point(594, 134);
            this.txtMTelefono.Name = "txtMTelefono";
            this.txtMTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtMTelefono.TabIndex = 32;
            this.txtMTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMTelefono_KeyPress);
            // 
            // txtMCi
            // 
            this.txtMCi.Location = new System.Drawing.Point(594, 88);
            this.txtMCi.Name = "txtMCi";
            this.txtMCi.Size = new System.Drawing.Size(121, 20);
            this.txtMCi.TabIndex = 31;
            this.txtMCi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMCi_KeyPress);
            // 
            // txtMAMaterno
            // 
            this.txtMAMaterno.Location = new System.Drawing.Point(594, 66);
            this.txtMAMaterno.Name = "txtMAMaterno";
            this.txtMAMaterno.Size = new System.Drawing.Size(121, 20);
            this.txtMAMaterno.TabIndex = 30;
            this.txtMAMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMAMaterno_KeyPress);
            // 
            // txtMAPaterno
            // 
            this.txtMAPaterno.Location = new System.Drawing.Point(594, 44);
            this.txtMAPaterno.Name = "txtMAPaterno";
            this.txtMAPaterno.Size = new System.Drawing.Size(121, 20);
            this.txtMAPaterno.TabIndex = 29;
            this.txtMAPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMAPaterno_KeyPress);
            // 
            // txtMNombre
            // 
            this.txtMNombre.Location = new System.Drawing.Point(594, 22);
            this.txtMNombre.Name = "txtMNombre";
            this.txtMNombre.Size = new System.Drawing.Size(121, 20);
            this.txtMNombre.TabIndex = 28;
            this.txtMNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMNombre_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboBox1.Location = new System.Drawing.Point(594, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // btnModificarFoto
            // 
            this.btnModificarFoto.Location = new System.Drawing.Point(468, 214);
            this.btnModificarFoto.Name = "btnModificarFoto";
            this.btnModificarFoto.Size = new System.Drawing.Size(105, 23);
            this.btnModificarFoto.TabIndex = 26;
            this.btnModificarFoto.Text = "Modificar Foto";
            this.btnModificarFoto.UseVisualStyleBackColor = true;
            // 
            // lblModificarFechaNac
            // 
            this.lblModificarFechaNac.AutoSize = true;
            this.lblModificarFechaNac.Location = new System.Drawing.Point(465, 165);
            this.lblModificarFechaNac.Name = "lblModificarFechaNac";
            this.lblModificarFechaNac.Size = new System.Drawing.Size(108, 13);
            this.lblModificarFechaNac.TabIndex = 25;
            this.lblModificarFechaNac.Text = "Fecha de Nacimiento";
            // 
            // lblModificarTelefono
            // 
            this.lblModificarTelefono.AutoSize = true;
            this.lblModificarTelefono.Location = new System.Drawing.Point(465, 137);
            this.lblModificarTelefono.Name = "lblModificarTelefono";
            this.lblModificarTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblModificarTelefono.TabIndex = 24;
            this.lblModificarTelefono.Text = "Telefono";
            // 
            // lblModificarGenero
            // 
            this.lblModificarGenero.AutoSize = true;
            this.lblModificarGenero.Location = new System.Drawing.Point(465, 113);
            this.lblModificarGenero.Name = "lblModificarGenero";
            this.lblModificarGenero.Size = new System.Drawing.Size(42, 13);
            this.lblModificarGenero.TabIndex = 23;
            this.lblModificarGenero.Text = "Genero";
            // 
            // lblModificarCi
            // 
            this.lblModificarCi.AutoSize = true;
            this.lblModificarCi.Location = new System.Drawing.Point(465, 91);
            this.lblModificarCi.Name = "lblModificarCi";
            this.lblModificarCi.Size = new System.Drawing.Size(20, 13);
            this.lblModificarCi.TabIndex = 22;
            this.lblModificarCi.Text = "C.I";
            // 
            // lblModificarAMaterno
            // 
            this.lblModificarAMaterno.AutoSize = true;
            this.lblModificarAMaterno.Location = new System.Drawing.Point(465, 69);
            this.lblModificarAMaterno.Name = "lblModificarAMaterno";
            this.lblModificarAMaterno.Size = new System.Drawing.Size(86, 13);
            this.lblModificarAMaterno.TabIndex = 21;
            this.lblModificarAMaterno.Text = "Apellido Materno";
            // 
            // lblModificarAPaterno
            // 
            this.lblModificarAPaterno.AutoSize = true;
            this.lblModificarAPaterno.Location = new System.Drawing.Point(465, 47);
            this.lblModificarAPaterno.Name = "lblModificarAPaterno";
            this.lblModificarAPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblModificarAPaterno.TabIndex = 20;
            this.lblModificarAPaterno.Text = "Apellido Paterno";
            this.lblModificarAPaterno.Click += new System.EventHandler(this.lblAPaterno_Click);
            // 
            // lblModificarNombre
            // 
            this.lblModificarNombre.AutoSize = true;
            this.lblModificarNombre.Location = new System.Drawing.Point(465, 25);
            this.lblModificarNombre.Name = "lblModificarNombre";
            this.lblModificarNombre.Size = new System.Drawing.Size(44, 13);
            this.lblModificarNombre.TabIndex = 19;
            this.lblModificarNombre.Text = "Nombre";
            // 
            // id_propietario
            // 
            this.id_propietario.AutoSize = true;
            this.id_propietario.Location = new System.Drawing.Point(618, 25);
            this.id_propietario.Name = "id_propietario";
            this.id_propietario.Size = new System.Drawing.Size(13, 13);
            this.id_propietario.TabIndex = 42;
            this.id_propietario.Text = "_";
            this.id_propietario.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(640, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Guardar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 308);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnMCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtMTelefono);
            this.Controls.Add(this.txtMCi);
            this.Controls.Add(this.txtMAMaterno);
            this.Controls.Add(this.txtMAPaterno);
            this.Controls.Add(this.txtMNombre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnModificarFoto);
            this.Controls.Add(this.lblModificarFechaNac);
            this.Controls.Add(this.lblModificarTelefono);
            this.Controls.Add(this.lblModificarGenero);
            this.Controls.Add(this.lblModificarCi);
            this.Controls.Add(this.lblModificarAMaterno);
            this.Controls.Add(this.lblModificarAPaterno);
            this.Controls.Add(this.lblModificarNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBuscarPropietario);
            this.Controls.Add(this.lblBuscar1);
            this.Controls.Add(this.id_propietario);
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar1;
        private System.Windows.Forms.TextBox txtBuscarPropietario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMTelefono;
        private System.Windows.Forms.TextBox txtMCi;
        private System.Windows.Forms.TextBox txtMAMaterno;
        private System.Windows.Forms.TextBox txtMAPaterno;
        private System.Windows.Forms.TextBox txtMNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnModificarFoto;
        private System.Windows.Forms.Label lblModificarFechaNac;
        private System.Windows.Forms.Label lblModificarTelefono;
        private System.Windows.Forms.Label lblModificarGenero;
        private System.Windows.Forms.Label lblModificarCi;
        private System.Windows.Forms.Label lblModificarAMaterno;
        private System.Windows.Forms.Label lblModificarAPaterno;
        private System.Windows.Forms.Label lblModificarNombre;
        private System.Windows.Forms.Label id_propietario;
        private System.Windows.Forms.Button btnUpdate;
    }
}