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
	public partial class FrmProveedores : Form
	{
		public FrmProveedores()
		{
			InitializeComponent();
			clasepreveedor clasepreveedor = new clasepreveedor();
			clasepreveedor.VerInformacionProveedor(Datagriproveedor);
		}

		private void Volver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnregistrar_Click(object sender, EventArgs e)
		{
			clasepreveedor clasepreveedor = new clasepreveedor();
			clasepreveedor.RegistrarProveedor(txtarticulo.Text,Txtnombre.Text,txttelefono.Text,txtdireccion.Text);
			clasepreveedor.VerInformacionProveedor(Datagriproveedor);
		}

		private void btnmodificar_Click(object sender, EventArgs e)
		{
			clasepreveedor clasepreveedor = new clasepreveedor();
			clasepreveedor.ModificarProveedor(txtId.Text,txtarticulo.Text, Txtnombre.Text, txttelefono.Text, txtdireccion.Text);
			clasepreveedor.VerInformacionProveedor(Datagriproveedor);
		}

		private void btneliminar_Click(object sender, EventArgs e)
		{
			clasepreveedor clasepreveedor = new clasepreveedor();
			clasepreveedor.EliminarProveedor(txtId.Text);
			clasepreveedor.VerInformacionProveedor(Datagriproveedor);
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			clasepreveedor clasepreveedor = new clasepreveedor();
			clasepreveedor.BuscarProveedorPorNombre( txtbuscar.Text,Datagriproveedor);
		}

		private void Datagriproveedor_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			clasepreveedor clasepreveedor = new clasepreveedor();
			clasepreveedor.SeleccionarProveedor(Datagriproveedor,txtId, txtarticulo, Txtnombre, txttelefono, txtdireccion);

		}
	}
}
