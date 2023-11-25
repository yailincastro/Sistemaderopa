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
	public partial class FrmProductos : Form
	{
		public FrmProductos()
		{
			InitializeComponent();
			claseproducto claseproducto = new claseproducto();
			claseproducto.informacion(Datagriproducto);
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			claseproducto claseproducto = new claseproducto();
			claseproducto.BuscarProductoPorNombre(txtbuscar.Text,Datagriproducto);
		}

		private void btnregistrar_Click(object sender, EventArgs e)
		{
			claseproducto claseproducto = new claseproducto();
			claseproducto.RegistrarProducto(txtarticulo.Text,Txtcolor.Text,txtcantidad.Text,txtprecio.Text);
			claseproducto.informacion(Datagriproducto);
		}

		private void btnmodificar_Click(object sender, EventArgs e)
		{
			claseproducto claseproducto = new claseproducto();
			claseproducto.ModificarProducto(txtId.Text,txtarticulo.Text, Txtcolor.Text, txtcantidad.Text, txtprecio.Text);
			claseproducto.informacion(Datagriproducto);
		}

		private void btneliminar_Click(object sender, EventArgs e)
		{
			claseproducto claseproducto = new claseproducto();
			claseproducto.EliminarProducto(txtId.Text);
			claseproducto.informacion(Datagriproducto);
		}

		private void Datagriproducto_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			claseproducto claseproducto = new claseproducto();
			claseproducto.SeleccionarProducto(Datagriproducto,txtId, txtarticulo, Txtcolor, txtcantidad, txtprecio);
		}

		private void Volver_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
