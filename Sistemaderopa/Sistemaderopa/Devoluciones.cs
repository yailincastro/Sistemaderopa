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
	public partial class FrmDevoluciones : Form
	{
		public FrmDevoluciones()
		{
			InitializeComponent();
		}

		private void FrmDevoluciones_Load(object sender, EventArgs e)
		{

		}

		private void btncalcular_Click(object sender, EventArgs e)
		{
			clasedevoluciones clasedevoluciones = new clasedevoluciones();
			clasedevoluciones.RegistrarDevolucion(txtfactura.Text,txtcantidad.Text,txtrazon.Text,FEcha.Value);
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			clasedevoluciones clasedevoluciones = new clasedevoluciones();
			clasedevoluciones.BuscarFacturaPorID(txtbuscar.Text,datagridevolucion);
		}

		private void datagridevolucion_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			clasedevoluciones clasedevoluciones = new clasedevoluciones();
			clasedevoluciones.SeleccionarDevolucion(datagridevolucion, txtfactura,txtarticulo,txtcantidad);
		}

		private void txtid_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
