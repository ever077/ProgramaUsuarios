namespace ProgramaUsuarios.Presentacion
{
    partial class Usuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.panel_encabezado = new System.Windows.Forms.Panel();
            this.panel_contenedorBusqueda = new System.Windows.Forms.Panel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pictureBox_imagenLupa = new System.Windows.Forms.PictureBox();
            this.panel_subBusquedaUsuario = new System.Windows.Forms.Panel();
            this.textBox_busquedaUsuario = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dataGridView_listado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_usuario = new System.Windows.Forms.Panel();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_guardarCambios = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pictureBox_imagenUsuario = new System.Windows.Forms.PictureBox();
            this.label_icono = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_encabezado.SuspendLayout();
            this.panel_contenedorBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagenLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listado)).BeginInit();
            this.panel_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagenUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_encabezado
            // 
            this.panel_encabezado.Controls.Add(this.panel_contenedorBusqueda);
            this.panel_encabezado.Controls.Add(this.lbl_titulo);
            this.panel_encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_encabezado.Location = new System.Drawing.Point(0, 0);
            this.panel_encabezado.Name = "panel_encabezado";
            this.panel_encabezado.Size = new System.Drawing.Size(947, 121);
            this.panel_encabezado.TabIndex = 0;
            // 
            // panel_contenedorBusqueda
            // 
            this.panel_contenedorBusqueda.BackColor = System.Drawing.Color.White;
            this.panel_contenedorBusqueda.Controls.Add(this.btn_agregar);
            this.panel_contenedorBusqueda.Controls.Add(this.pictureBox_imagenLupa);
            this.panel_contenedorBusqueda.Controls.Add(this.panel_subBusquedaUsuario);
            this.panel_contenedorBusqueda.Controls.Add(this.textBox_busquedaUsuario);
            this.panel_contenedorBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedorBusqueda.Location = new System.Drawing.Point(0, 57);
            this.panel_contenedorBusqueda.Name = "panel_contenedorBusqueda";
            this.panel_contenedorBusqueda.Size = new System.Drawing.Size(947, 64);
            this.panel_contenedorBusqueda.TabIndex = 1;
            this.panel_contenedorBusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(396, 9);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(136, 46);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pictureBox_imagenLupa
            // 
            this.pictureBox_imagenLupa.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_imagenLupa.Image = global::ProgramaUsuarios.Properties.Resources.lupa;
            this.pictureBox_imagenLupa.Location = new System.Drawing.Point(356, 21);
            this.pictureBox_imagenLupa.Name = "pictureBox_imagenLupa";
            this.pictureBox_imagenLupa.Size = new System.Drawing.Size(21, 23);
            this.pictureBox_imagenLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_imagenLupa.TabIndex = 4;
            this.pictureBox_imagenLupa.TabStop = false;
            // 
            // panel_subBusquedaUsuario
            // 
            this.panel_subBusquedaUsuario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel_subBusquedaUsuario.Location = new System.Drawing.Point(22, 46);
            this.panel_subBusquedaUsuario.Name = "panel_subBusquedaUsuario";
            this.panel_subBusquedaUsuario.Size = new System.Drawing.Size(325, 1);
            this.panel_subBusquedaUsuario.TabIndex = 3;
            // 
            // textBox_busquedaUsuario
            // 
            this.textBox_busquedaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_busquedaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_busquedaUsuario.Location = new System.Drawing.Point(21, 25);
            this.textBox_busquedaUsuario.Name = "textBox_busquedaUsuario";
            this.textBox_busquedaUsuario.Size = new System.Drawing.Size(326, 19);
            this.textBox_busquedaUsuario.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox_busquedaUsuario, "Buscar un usuario por nombre o contraseña");
            this.textBox_busquedaUsuario.TextChanged += new System.EventHandler(this.textBox_busquedaUsuario_TextChanged);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(947, 57);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Usuarios";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_listado
            // 
            this.dataGridView_listado.AllowUserToAddRows = false;
            this.dataGridView_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.dataGridView_listado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_listado.Location = new System.Drawing.Point(0, 121);
            this.dataGridView_listado.Name = "dataGridView_listado";
            this.dataGridView_listado.RowHeadersWidth = 51;
            this.dataGridView_listado.RowTemplate.Height = 24;
            this.dataGridView_listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_listado.Size = new System.Drawing.Size(947, 411);
            this.dataGridView_listado.TabIndex = 1;
            this.dataGridView_listado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_listado_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::ProgramaUsuarios.Properties.Resources.Eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ProgramaUsuarios.Properties.Resources.Editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // panel_usuario
            // 
            this.panel_usuario.Controls.Add(this.btn_volver);
            this.panel_usuario.Controls.Add(this.btn_guardarCambios);
            this.panel_usuario.Controls.Add(this.btn_guardar);
            this.panel_usuario.Controls.Add(this.pictureBox_imagenUsuario);
            this.panel_usuario.Controls.Add(this.label_icono);
            this.panel_usuario.Controls.Add(this.textBox_pass);
            this.panel_usuario.Controls.Add(this.textBox_usuario);
            this.panel_usuario.Controls.Add(this.lbl_pass);
            this.panel_usuario.Controls.Add(this.lbl_usuario);
            this.panel_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_usuario.Location = new System.Drawing.Point(203, 145);
            this.panel_usuario.Name = "panel_usuario";
            this.panel_usuario.Size = new System.Drawing.Size(541, 359);
            this.panel_usuario.TabIndex = 2;
            this.panel_usuario.Visible = false;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(409, 310);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(112, 35);
            this.btn_volver.TabIndex = 8;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_guardarCambios
            // 
            this.btn_guardarCambios.Location = new System.Drawing.Point(203, 310);
            this.btn_guardarCambios.Name = "btn_guardarCambios";
            this.btn_guardarCambios.Size = new System.Drawing.Size(200, 35);
            this.btn_guardarCambios.TabIndex = 7;
            this.btn_guardarCambios.Text = "Guardar Cambios";
            this.btn_guardarCambios.UseVisualStyleBackColor = true;
            this.btn_guardarCambios.Click += new System.EventHandler(this.btn_guardarCambios_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(85, 310);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(112, 35);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // pictureBox_imagenUsuario
            // 
            this.pictureBox_imagenUsuario.Image = global::ProgramaUsuarios.Properties.Resources.foto;
            this.pictureBox_imagenUsuario.Location = new System.Drawing.Point(159, 162);
            this.pictureBox_imagenUsuario.Name = "pictureBox_imagenUsuario";
            this.pictureBox_imagenUsuario.Size = new System.Drawing.Size(152, 118);
            this.pictureBox_imagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_imagenUsuario.TabIndex = 5;
            this.pictureBox_imagenUsuario.TabStop = false;
            this.pictureBox_imagenUsuario.Click += new System.EventHandler(this.pictureBox_imagenUsuario_Click);
            // 
            // label_icono
            // 
            this.label_icono.AutoSize = true;
            this.label_icono.Location = new System.Drawing.Point(154, 134);
            this.label_icono.Name = "label_icono";
            this.label_icono.Size = new System.Drawing.Size(60, 25);
            this.label_icono.TabIndex = 4;
            this.label_icono.Text = "Icono";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(159, 82);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(233, 30);
            this.textBox_pass.TabIndex = 3;
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(159, 32);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(234, 30);
            this.textBox_usuario.TabIndex = 2;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(33, 87);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(120, 25);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Contraseña:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(68, 37);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(85, 25);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // dlg
            // 
            this.dlg.FileName = "openFileDialog1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::ProgramaUsuarios.Properties.Resources.Editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::ProgramaUsuarios.Properties.Resources.Eliminar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 532);
            this.Controls.Add(this.panel_usuario);
            this.Controls.Add(this.dataGridView_listado);
            this.Controls.Add(this.panel_encabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel_encabezado.ResumeLayout(false);
            this.panel_contenedorBusqueda.ResumeLayout(false);
            this.panel_contenedorBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagenLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listado)).EndInit();
            this.panel_usuario.ResumeLayout(false);
            this.panel_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagenUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_encabezado;
        private System.Windows.Forms.Panel panel_contenedorBusqueda;
        private System.Windows.Forms.Panel panel_subBusquedaUsuario;
        private System.Windows.Forms.TextBox textBox_busquedaUsuario;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox_imagenLupa;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dataGridView_listado;
        private System.Windows.Forms.Panel panel_usuario;
        private System.Windows.Forms.PictureBox pictureBox_imagenUsuario;
        private System.Windows.Forms.Label label_icono;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_guardarCambios;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}