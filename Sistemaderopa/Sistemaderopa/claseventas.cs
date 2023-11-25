using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace Sistemaderopa
{
	internal class claseventas
	{
		public void informacion(GunaDataGridView tabla)
		{
			claseconexion objetConexion = new claseconexion();

			try
			{
				tabla.DataSource = null;
				SqlDataAdapter adapter = new SqlDataAdapter("select ID, ArticuloID AS Articulo, Color, Cantidad, Precio, ITB, Descuento from Ventas;", objetConexion.Establecerconexion());
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
		public void BuscarProductoPorIDoNombre(DataGridView dataGridView, string busqueda)
		{
			claseconexion objetConexion = new claseconexion();

			try
			{
				// Verificar si la búsqueda es numérica (ID) o por nombre (Articulo)
				string query;
				if (int.TryParse(busqueda, out _))
				{
					query = "SELECT ID,Articulo,Color,Precio FROM Producto WHERE ID = @Busqueda";
				}
				else
				{
					query = "SELECT ID,Articulo,Color,Precio FROM Producto WHERE Articulo LIKE @Busqueda";
				}

				SqlDataAdapter adapter = new SqlDataAdapter(query, objetConexion.Establecerconexion());
				adapter.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");

				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				dataGridView.DataSource = dataTable;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al buscar en la tabla 'Producto': " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}


	}
}
