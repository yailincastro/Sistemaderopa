using Guna.UI.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
	internal class clasedevoluciones
	{
		public void RegistrarDevolucion(string ventaID, string cantidadDevuelta, string motivo, DateTime fechaDevolucion)
		{
			claseconexion objetoConexion = new claseconexion();

			try
			{
				// Insertar en la tabla Devoluciones
				string insertDevolucionQuery = "INSERT INTO Devoluciones (VentaID, CantidadDevuelta, Motivo, FechaDevolucion) " +
											  "VALUES (@VentaID, @CantidadDevuelta, @Motivo, @FechaDevolucion);";

				using (SqlConnection connection = objetoConexion.Establecerconexion())
				using (SqlCommand insertCommand = new SqlCommand(insertDevolucionQuery, connection))
				{
					insertCommand.Parameters.AddWithValue("@VentaID", ventaID);
					insertCommand.Parameters.AddWithValue("@CantidadDevuelta", cantidadDevuelta);
					insertCommand.Parameters.AddWithValue("@Motivo", motivo);
					insertCommand.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion);

					insertCommand.ExecuteNonQuery();
					MessageBox.Show("Devolución registrada exitosamente en la tabla Devoluciones.");
				}
				objetoConexion.cerrarconexion();
				// Actualizar la tabla Producto con la cantidad devuelta
				string updateProductoQuery = "UPDATE Producto SET Cantidad = Cantidad + @CantidadDevuelta WHERE ID = @ID;";

				using (SqlCommand updateCommand = new SqlCommand(updateProductoQuery, objetoConexion.Establecerconexion()))
				{
					updateCommand.Parameters.AddWithValue("@ID", ventaID);
					updateCommand.Parameters.AddWithValue("@CantidadDevuelta", cantidadDevuelta);

					updateCommand.ExecuteNonQuery();
					MessageBox.Show("Cantidad devuelta actualizada en la tabla Producto.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al registrar la devolución y actualizar la cantidad del producto: " + ex.Message);
			}
			finally
			{
				objetoConexion.cerrarconexion();
			}
		}
		
		public void informacion(GunaDataGridView tabla)
		{
			claseconexion objetConexion = new claseconexion();

			try
			{
				tabla.DataSource = null;

				
				string query = "SELECT d.ID, v.ArticuloID as FacturaID, p.Articulo AS Articulo, v.Color, d.CantidadDevuelta as Cantidad, d.Motivo, d.FechaDevolucion as Fecha " +
							   "FROM Devoluciones d " +
							   "INNER JOIN ventas v ON d.VentaID = v.ID " +
							   "INNER JOIN Producto p ON v.ArticuloID = p.ID;";

				SqlDataAdapter adapter = new SqlDataAdapter(query, objetConexion.Establecerconexion());
				DataTable dt = new DataTable();

				adapter.Fill(dt);
				tabla.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró agregar los datos: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}


		public void BuscarFacturaPorID(string idFactura, GunaDataGridView tabla)
		{
			claseconexion objetoConexion = new claseconexion();

			try
			{
				string query = "SELECT v.ID, p.Articulo AS Articulo, v.Color, v.Cantidad, v.Precio, v.ITB, v.descuento FROM ventas v " +
							   "JOIN Producto p ON v.ArticuloID = p.ID " +
							   "WHERE v.ID = @IDFactura;";

				using (SqlConnection connection = objetoConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@IDFactura", idFactura);

					DataTable dt = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter(command);
					adapter.Fill(dt);

					tabla.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo realizar la búsqueda. Error: " + ex.ToString());
			}
			finally
			{
				objetoConexion.cerrarconexion();
			}
		}

		public void SeleccionarDevolucion(GunaDataGridView tabla, GunaTextBox idDevolucion, GunaTextBox ventaID, GunaTextBox cantidad)
		{
			try
			{
				if (tabla.CurrentRow != null)
				{
					idDevolucion.Text = tabla.CurrentRow.Cells["ID"].Value.ToString();
					ventaID.Text = tabla.CurrentRow.Cells["Articulo"].Value.ToString();
					cantidad.Text = tabla.CurrentRow.Cells["Cantidad"].Value.ToString();
				
				}
				else
				{
					MessageBox.Show("No se ha seleccionado ninguna fila.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al seleccionar la devolución: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
