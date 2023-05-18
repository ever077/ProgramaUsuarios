using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProgramaUsuarios.Logica;
using System.Windows.Forms;
using System.Data;

namespace ProgramaUsuarios.Datos
{
    internal class dusuarios
    {
        private SqlCommand cmd = new SqlCommand();
        private int idusuario;

        public bool insertar_usuario(lusuarios dt)
        {
            try
            {
                ConexionMaestra.abrir();
                cmd = new SqlCommand("insertar_usuario", ConexionMaestra.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", dt.Usuario);
                cmd.Parameters.AddWithValue("@Pass", dt.Pass);
                cmd.Parameters.AddWithValue("@Icono", dt.Icono);
                cmd.Parameters.AddWithValue("@Estado", dt.Estado);
                if(cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }

        public DataTable mostrar_usuarios()
        {
            try
            {
                ConexionMaestra.abrir();
                cmd = new SqlCommand("mostrar_usuarios", ConexionMaestra.conexion);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }

        public bool editar_usuario(lusuarios dt)
        {
            try
            {
                ConexionMaestra.abrir();
                cmd = new SqlCommand("editar_usuario", ConexionMaestra.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_usuario", dt.Idusuario);
                cmd.Parameters.AddWithValue("@Usuario", dt.Usuario);
                cmd.Parameters.AddWithValue("@Pass", dt.Pass);
                cmd.Parameters.AddWithValue("@Icono", dt.Icono);
                cmd.Parameters.AddWithValue("@Estado", dt.Estado);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }

        public bool eliminar_usuario(lusuarios dt)
        {
            try
            {
                ConexionMaestra.abrir();
                cmd = new SqlCommand("eliminar_usuario", ConexionMaestra.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_usuario", dt.Idusuario);
                if(cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }

        public DataTable buscar_usuarios(string parametros)
        {
            try
            {
                ConexionMaestra.abrir();
                cmd = new SqlCommand("buscar_usuarios", ConexionMaestra.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscador", parametros);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }
    }
}
