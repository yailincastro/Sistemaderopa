using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemaderopa
{
	public partial class FrmReportedelaventa : Form
	{
		public FrmReportedelaventa()
		{
			InitializeComponent();
		}

		private void FrmReportedelaventa_Load(object sender, EventArgs e)
		{

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

		private void btnimprimir_Click(object sender, EventArgs e)
		{
			reportViewer1.Visible = true;
			MostrarReporte();
		}
		private void MostrarReporte()
		{
			//Crea un DataTable para almacenar tus datos de productos
			DataTable dt = new DataTable("Ventas");

			// Llena el DataTable con los datos de tu DataGridView dgvProductos
			foreach (DataGridViewColumn col in datagriventas.Columns)
			{
				dt.Columns.Add(col.Name);
			}

			foreach (DataGridViewRow row in datagriventas.Rows)
			{
				DataRow dRow = dt.NewRow();
				foreach (DataGridViewCell cell in row.Cells)
				{
					dRow[cell.ColumnIndex] = cell.Value;
				}
				dt.Rows.Add(dRow);
			}

			// Define una fuente de datos con tu DataTable
			ReportDataSource rds = new ReportDataSource("Ventas", dt);

			// Asigna la fuente de datos al control ReportViewer
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(rds);

			// Refresca el informe
			reportViewer1.RefreshReport();
		}
		private void btnbuscar_Click(object sender, EventArgs e)
		{
			reportViewer1.Visible = false;
			claseventas claseventas = new claseventas();
			claseventas.informacion(datagriventas);
		}
	}
}
