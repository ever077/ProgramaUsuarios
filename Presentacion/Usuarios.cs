using ProgramaUsuarios.Datos;
using ProgramaUsuarios.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaUsuarios.Presentacion
{
    public partial class Usuarios : Form
    {
        private int idUsuario;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void mostrarUsuarios()
        {
            DataTable dt;
            dusuarios funcion = new dusuarios();
            dt = funcion.mostrar_usuarios();
            dataGridView_listado.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            panel_usuario.Visible = true;
            panel_usuario.Dock = DockStyle.Fill;
            btn_guardar.Visible = true;
            btn_guardarCambios.Visible = false;
            textBox_usuario.Clear();
            textBox_pass.Clear();
            
        }

        private void pictureBox_imagenUsuario_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de Imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox_imagenUsuario.BackgroundImage = null;
                pictureBox_imagenUsuario.Image = new Bitmap(dlg.FileName);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (textBox_usuario.Text != "")
            {
                if (textBox_pass.Text != "")
                {
                    insertarUsuario();
                    mostrarUsuarios();
                }
                else
                {
                    MessageBox.Show("Ingrese una Contraseña", "Sin Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Usuario", "Sin Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertarUsuario()
        {
            lusuarios dt = new lusuarios();
            dusuarios funcion = new dusuarios();

            dt.Usuario = textBox_usuario.Text;
            dt.Pass = textBox_pass.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox_imagenUsuario.Image.Save(ms, pictureBox_imagenUsuario.Image.RawFormat);
            dt.Icono = ms.GetBuffer();
            dt.Estado = "ACTIVO";

            if (funcion.insertar_usuario(dt))
            {
                MessageBox.Show("Usuario Registrado", "Registro Correcto");
                panel_usuario.Visible = false;
                panel_usuario.Dock = DockStyle.None;
            }
        }

        private void dataGridView_listado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuario = Convert.ToInt32(dataGridView_listado.SelectedCells[2].Value.ToString());

            if (e.ColumnIndex == this.dataGridView_listado.Columns["Editar"].Index)
            {
                textBox_usuario.Text = dataGridView_listado.SelectedCells[3].Value.ToString();
                textBox_pass.Text = dataGridView_listado.SelectedCells[4].Value.ToString();
                pictureBox_imagenUsuario.BackgroundImage = null;
                byte[] b = (byte[])dataGridView_listado.SelectedCells[5].Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(b);
                pictureBox_imagenUsuario.Image = Image.FromStream(ms);

                panel_usuario.Visible = true;
                panel_usuario.Dock = DockStyle.Fill;
                btn_guardar.Visible = false;
                btn_guardarCambios.Visible = true;
            }

            if(e.ColumnIndex == this.dataGridView_listado.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente desea eliminar este registro?", "Eliminacion de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    eliminarUsuario();
                    mostrarUsuarios();
                }
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            panel_usuario.Visible = false;
            panel_usuario.Dock = DockStyle.None;
        }

        private void btn_guardarCambios_Click(object sender, EventArgs e)
        {
            editarUsuario();
            mostrarUsuarios();
        }

        private void editarUsuario()
        {
            lusuarios dt = new lusuarios();
            dusuarios funcion = new dusuarios();
            dt.Idusuario = idUsuario;
            dt.Usuario = textBox_usuario.Text;
            dt.Pass = textBox_pass.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox_imagenUsuario.Image.Save(ms, pictureBox_imagenUsuario.Image.RawFormat);
            dt.Icono = ms.GetBuffer();
            dt.Estado = "ACTIVO";

            if (funcion.editar_usuario(dt))
            {
                MessageBox.Show("Usuario Modificado", "Modificacion Correcta");
                panel_usuario.Visible = false;
                panel_usuario.Dock = DockStyle.None;
            }
        }

        private void eliminarUsuario()
        {
            lusuarios dt = new lusuarios();
            dusuarios funcion = new dusuarios();
            dt.Idusuario = idUsuario;
            if (funcion.eliminar_usuario(dt))
            {
                MessageBox.Show("Usuario Eliminado", "Eliminacion Correcta");
                panel_usuario.Visible = false;
                panel_usuario.Dock = DockStyle.None;
            }
        }

        private void textBox_busquedaUsuario_TextChanged(object sender, EventArgs e)
        {
            buscarUsuarios();
        }

        private void buscarUsuarios()
        {
            DataTable dt;
            dusuarios funcion = new dusuarios();
            dt = funcion.buscar_usuarios(textBox_busquedaUsuario.Text);
            dataGridView_listado.DataSource = dt;
        }
    }
}
