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
	public partial class FrmReportes : Form
	{
		public FrmReportes()
		{
			InitializeComponent();
		}

		private void Volver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private void MostrarFormularioEnPanel(Form formulario)
		{
			formulario.TopLevel = false;
			formulario.FormBorderStyle = FormBorderStyle.None;
			formulario.Dock = DockStyle.Fill;

			panel1.Controls.Clear();
			panel1.Controls.Add(formulario);

			formulario.Show();

			formulario.Show();
		}
		private void reportesDeLasVentasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel( new FrmReportedelaventa());
		}

		private void reporteDeLasDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmReportedelasdevoluciones());
		}

		private void reporteDeLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmReportedelosproductos());
		}
	}
}
