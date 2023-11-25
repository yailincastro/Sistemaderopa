using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Sistemaderopa
{
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}
		private void MostrarFormularioEnPanel(Form formulario)
		{
			formulario.TopLevel = false;
			formulario.FormBorderStyle = FormBorderStyle.None;
			formulario.Dock = DockStyle.Fill;

			panel.Controls.Clear();
			panel.Controls.Add(formulario);

			formulario.Show();

			formulario.Show();
		}
		private void btnventas_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmVentas());
		}

		private void btnproductos_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmProductos());
		}

		private void btninventario_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmInventario());
		}

		private void btnproveedor_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmProveedores());

		}
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnreportes_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmReportes());
		}

		private void btnacercade_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmAcercade());
		}

		private void btndevolucione_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmDevoluciones());
		}

		private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}
		

		
	}
}
