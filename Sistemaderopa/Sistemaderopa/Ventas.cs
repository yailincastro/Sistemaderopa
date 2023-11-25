using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemaderopa
{
	public partial class FrmVentas : Form
	{
		public FrmVentas()
		{
			InitializeComponent();
		}

		private void FrmVentas_Load(object sender, EventArgs e)
		{

		}

		private void Volver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			claseventas claseventas =	new claseventas();
			claseventas.BuscarProductoPorIDoNombre(datagriarticulos, txtbuscar.Text);
		}
		private void PasarDatosConColumnas(DataGridView origen, DataGridView destino)
		{
			// Limpiar el DataGridView destino
			
			

			foreach (DataGridViewColumn columna in origen.Columns)
			{
				if (!destino.Columns.Contains(columna.Name))
				{
					DataGridViewTextBoxColumn nuevaColumna = new DataGridViewTextBoxColumn();
					nuevaColumna.Name = columna.Name;
					nuevaColumna.HeaderText = columna.HeaderText;
					destino.Columns.Add(nuevaColumna);
				}
			}

			if (origen.SelectedRows.Count > 0)
			{
				int indiceFila = destino.Rows.Add();
				DataGridViewRow filaSeleccionada = origen.SelectedRows[0];

				for (int i = 0; i < filaSeleccionada.Cells.Count; i++)
				{
					destino.Rows[indiceFila].Cells[i].Value = filaSeleccionada.Cells[i].Value;
				}
			}
		}



		private void datagriarticulos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{

			
		}
		private void CalcularTotal()
		{
			double total = 0;

			// Iterar por las filas del DataGridView
			foreach (DataGridViewRow fila in datagriventas.Rows)
			{
				double precio = Convert.ToDouble(fila.Cells["Precio"].Value);
				total += precio;
			}

			double descuentoPorcentaje = 0;
			if (!string.IsNullOrEmpty(txtdescuento.Text))
			{
				descuentoPorcentaje = Convert.ToDouble(txtdescuento.Text);
			}

			double descuento = total * (descuentoPorcentaje / 100); // Calcula el descuento en porcentaje

			total -= descuento;

			// Calcular ITB (18%)
			double itb = total * 0.18;
			total += itb;

			txttotal.Text = total.ToString();

			// Calcular el monto a devolver
			double efectivoEntregado = 0;
			if (!string.IsNullOrEmpty(txtefectivo.Text))
			{
				efectivoEntregado = Convert.ToDouble(txtefectivo.Text);
			}

			double montoDevuelto = efectivoEntregado - total;
			txtmontodevuelta.Text = montoDevuelto.ToString();
		}

		private void btncalcular_Click(object sender, EventArgs e)
		{
			CalcularTotal();
		}

		private void datagriventas_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (datagriventas.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow fila in datagriventas.SelectedRows)
				{
					if (!fila.IsNewRow) // Verificar si la fila no es una fila nueva
					{
						datagriventas.Rows.Remove(fila);
					}
				}
			}

		}

		private void RegistrarVenta()
		{
			claseconexion objetoConexion = new claseconexion();

			try
			{
				using (SqlConnection connection = objetoConexion.Establecerconexion())
				{
					Dictionary<string, int> cantidadPorArticulo = new Dictionary<string, int>();

					foreach (DataGridViewRow fila in datagriventas.Rows)
					{
						if (fila.Cells["ID"].Value != null)
						{
							string articuloID = fila.Cells["ID"].Value.ToString();

							if (cantidadPorArticulo.ContainsKey(articuloID))
							{
								cantidadPorArticulo[articuloID]++;
							}
							else
							{
								cantidadPorArticulo[articuloID] = 1;
							}
						}
					}

					// Verificar disponibilidad del producto antes de vender
					foreach (var par in cantidadPorArticulo)
					{
						string stockCheckQuery = "SELECT Cantidad FROM Producto WHERE ID = @ID";
						using (SqlCommand stockCheckCommand = new SqlCommand(stockCheckQuery, connection))
						{
							stockCheckCommand.Parameters.AddWithValue("@ID", par.Key);
							int availableQuantity = (int)stockCheckCommand.ExecuteScalar();

							if (availableQuantity - par.Value < 0)
							{
								MessageBox.Show("No hay suficiente stock para el producto con ID " + par.Key + ".");
								return;
							}
						}
					}

					// Restar la cantidad vendida en la tabla "Producto"
					foreach (var par in cantidadPorArticulo)
					{
						string updateQuery = "UPDATE Producto SET Cantidad = Cantidad - @Cantidad WHERE ID = @ID";
						using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
						{
							updateCommand.Parameters.AddWithValue("@ID", par.Key); // ID del artículo
							updateCommand.Parameters.AddWithValue("@Cantidad", par.Value); // Cantidad a restar
							updateCommand.ExecuteNonQuery();
						}
					}

					string insertQuery = "INSERT INTO ventas (ArticuloID, Color, Cantidad, Precio, ITB, Descuento) " +
										"VALUES (@ArticuloID, @Color, @Cantidad, @Precio, @ITB, @Descuento)";

					foreach (var par in cantidadPorArticulo)
					{
						// Obtener los valores específicos de la fila actual
						DataGridViewRow row = datagriventas.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["ID"].Value.ToString() == par.Key);
						if (row != null)
						{
							string color = row.Cells["Color"].Value.ToString();
							decimal precio = decimal.Parse(row.Cells["Precio"].Value.ToString());

							using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
							{
								insertCommand.Parameters.AddWithValue("@ArticuloID", par.Key);
								insertCommand.Parameters.AddWithValue("@Color", color);
								insertCommand.Parameters.AddWithValue("@Cantidad", par.Value);
								insertCommand.Parameters.AddWithValue("@Precio", precio);

								decimal descuento = 0; // Asigna el descuento
								decimal itb = precio * 0.18M; // Calcula el ITB

								insertCommand.Parameters.AddWithValue("@Descuento", descuento);
								insertCommand.Parameters.AddWithValue("@ITB", itb);

								insertCommand.ExecuteNonQuery();
							}
						}
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al actualizar la cantidad del producto: " + ex.Message);
				return;
			}
			finally
			{
				objetoConexion.cerrarconexion();
			}
		}

		private void gunaButton2_Click(object sender, EventArgs e)
		{
			RegistrarVenta();
		}

		private void datagriarticulos_CellEnter(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void datagriarticulos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{

			PasarDatosConColumnas(datagriarticulos, datagriventas);
		}

		private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
		{

			
			string rutaCalculadora = @"C:\Windows\System32\calc.exe";

			
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = rutaCalculadora,
				UseShellExecute = true
			};

			try
			{
				
				Process.Start(startInfo);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error al abrir la calculadora: " + ex.Message);
			}

		}
	}
}
