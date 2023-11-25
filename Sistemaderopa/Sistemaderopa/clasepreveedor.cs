using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemaderopa
{
	internal class clasepreveedor
	{
		public void VerInformacionProveedor(DataGridView dataGridView)
		{
			claseconexion objetConexion = new claseconexion();

			try
			{
				string query = "SELECT * FROM proveedor";

				SqlDataAdapter adapter = new SqlDataAdapter(query, objetConexion.Establecerconexion());
				DataTable dataTable = new DataTable();

				adapter.Fill(dataTable);
				dataGridView.DataSource = dataTable;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos de la tabla 'proveedor': " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		public void RegistrarProveedor(string articulo, string nombre, string telefono, string direccion)
		{
			claseconexion objetoConexion = new claseconexion();

			try
			{
				string query = "INSERT INTO Proveedor (Articulo, Nombre, Telefono, Direccion) " +
							   "VALUES (@Articulo, @Nombre, @Telefono, @Direccion)";

				using (SqlConnection connection = objetoConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Articulo", articulo);
					command.Parameters.AddWithValue("@Nombre", nombre);
					command.Parameters.AddWithValue("@Telefono", telefono);
					command.Parameters.AddWithValue("@Direccion", direccion);

				
					command.ExecuteNonQuery();

					MessageBox.Show("Proveedor registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al registrar el proveedor: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				objetoConexion.cerrarconexion();
			}
		}

		public void ModificarProveedor(string id, string nuevoArticulo, string nuevoNombre, string nuevoTelefono, string nuevaDireccion)
		{
			claseconexion objetoConexion = new claseconexion();

			try
			{
				string query = "UPDATE Proveedor " +
							   "SET Articulo = @NuevoArticulo, " +
							   "Nombre = @NuevoNombre, " +
							   "Telefono = @NuevoTelefono, " +
							   "Direccion = @NuevaDireccion " +
							   "WHERE ID = @ID;";

				using (SqlConnection connection = objetoConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@NuevoArticulo", nuevoArticulo);
					command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
					command.Parameters.AddWithValue("@NuevoTelefono", nuevoTelefono);
					command.Parameters.AddWithValue("@NuevaDireccion", nuevaDireccion);
					command.Parameters.AddWithValue("@ID", id);

					
					int rowsAffected = command.ExecuteNonQuery();

					if (rowsAffected > 0)
						MessageBox.Show("Proveedor modificado exitosamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show("No se encontró un proveedor con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al modificar el proveedor: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				objetoConexion.cerrarconexion();
			}
		}

		public void EliminarProveedor(string id)
		{
			claseconexion objetoConexion = new claseconexion();

			try
			{
				string query = "DELETE FROM Proveedor WHERE ID = @ID;";

				using (SqlConnection connection = objetoConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@ID", id);

					
					int rowsAffected = command.ExecuteNonQuery();

					if (rowsAffected > 0)
						MessageBox.Show("Proveedor eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show("No se encontró un proveedor con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar el proveedor: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				objetoConexion.cerrarconexion();
			}
		}

		public void BuscarProveedorPorNombre(string nombre, GunaDataGridView tabla)
		{
			claseconexion objetoConexion = new claseconexion();

			try
			{
				string query = "SELECT * FROM Proveedor WHERE Nombre LIKE @Nombre;";

				using (SqlConnection connection = objetoConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

				

					DataTable dt = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter(command);
					adapter.Fill(dt);

					tabla.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al buscar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				objetoConexion.cerrarconexion();
			}
		}

		public void SeleccionarProveedor(GunaDataGridView tabla, GunaTextBox idProveedor,GunaTextBox Articulo, GunaTextBox nombre, GunaTextBox telefono, GunaTextBox direccion)
		{
			try
			{
				if (tabla.CurrentRow != null)
				{
					idProveedor.Text = tabla.CurrentRow.Cells[0].Value.ToString();
					Articulo.Text = tabla.CurrentRow.Cells[1].Value.ToString();
					nombre.Text = tabla.CurrentRow.Cells[2].Value.ToString();
					telefono.Text = tabla.CurrentRow.Cells[3].Value.ToString();
					direccion.Text = tabla.CurrentRow.Cells[4].Value.ToString();
				}
				else
				{
					MessageBox.Show("No se ha seleccionado ninguna fila.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al seleccionar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
