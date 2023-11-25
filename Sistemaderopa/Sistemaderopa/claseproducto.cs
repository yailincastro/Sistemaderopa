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
	internal class claseproducto
	{
		public void informacion(GunaDataGridView tabla)
		{
			claseconexion objetConexion = new claseconexion();

			try
			{
				tabla.DataSource = null;
				SqlDataAdapter adapter = new SqlDataAdapter("select *from Producto;", objetConexion.Establecerconexion());
				DataTable dt = new DataTable();

				adapter.Fill(dt);
				tabla.DataSource = dt;
				objetConexion.cerrarconexion();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logro agregar los datos" + ex.ToString());

			}
			objetConexion.cerrarconexion();
		}
		public void RegistrarProducto(string articulo, string color, string cantidad, string precio)
		{
			claseconexion objetConexion = new claseconexion();

			try
			{
				string query = "INSERT INTO Producto (Articulo, Color, Cantidad, Precio) " +
							   "VALUES (@Articulo, @Color, @Cantidad, @Precio);";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Articulo", articulo);
					command.Parameters.AddWithValue("@Color", color);
					command.Parameters.AddWithValue("@Cantidad", cantidad);
					command.Parameters.AddWithValue("@Precio", precio);

					command.ExecuteNonQuery();
					MessageBox.Show("Producto registrado exitosamente.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró registrar el producto. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		public void ModificarProducto(string id, string articulo, string color, string cantidad, string precio)
		{
			claseconexion objetConexion = new claseconexion();

			try
			{
				string query = "UPDATE Producto " +
							   "SET Articulo = @Articulo, " +
							   "Color = @Color, " +
							   "Cantidad = @Cantidad, " +
							   "Precio = @Precio " +
							   "WHERE ID = @ID;";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Articulo", articulo);
					command.Parameters.AddWithValue("@Color", color);
					command.Parameters.AddWithValue("@Cantidad", cantidad);
					command.Parameters.AddWithValue("@Precio", precio);
					command.Parameters.AddWithValue("@ID", id);

					int rowsAffected = command.ExecuteNonQuery();
					if (rowsAffected > 0)
						MessageBox.Show("Producto modificado exitosamente.");
					else
						MessageBox.Show("No se encontró un producto con el ID proporcionado.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró modificar el producto. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		public void EliminarProducto(string id)
		{
			claseconexion objetConexion = new claseconexion();

			try
			{
				string query = "DELETE FROM Producto WHERE ID = @ID;";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@ID", id);

					int rowsAffected = command.ExecuteNonQuery();
					if (rowsAffected > 0)
						MessageBox.Show("Producto eliminado exitosamente.");
					else
						MessageBox.Show("No se encontró un producto con el ID proporcionado.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró eliminar el producto. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		public void BuscarProductoPorNombre(string nombreArticulo, GunaDataGridView Tabla)
		{
			claseconexion objetConexion = new claseconexion();

			try
			{
				string query = "SELECT * FROM Producto WHERE Articulo LIKE @NombreArticulo;";
				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@NombreArticulo", "%" + nombreArticulo + "%");

					DataTable dt = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter(command);
					adapter.Fill(dt);

					Tabla.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo realizar la búsqueda. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		public void SeleccionarProducto(GunaDataGridView Tabla, GunaTextBox paramID, GunaTextBox Articulo, GunaTextBox Color,
								 GunaTextBox Cantidad, GunaTextBox Precio)
		{
			try
			{
				if (Tabla.CurrentRow != null)
				{
					paramID.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
					Articulo.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
					Color.Text = Tabla.CurrentRow.Cells[2].Value.ToString();
					Cantidad.Text = Tabla.CurrentRow.Cells[3].Value.ToString();
					Precio.Text = Tabla.CurrentRow.Cells[4].Value.ToString();
				}
				else
				{
					MessageBox.Show("No se ha seleccionado ninguna fila.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró seleccionar: " + ex.ToString());
			}
		}


	}
}
