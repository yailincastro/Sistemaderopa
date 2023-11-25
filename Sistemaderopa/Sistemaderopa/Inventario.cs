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
	public partial class FrmInventario : Form
	{
		public FrmInventario()
		{
			InitializeComponent();
			claseproducto claseproducto = new claseproducto();
			claseproducto.informacion(datagriinvetario);
		}

		private void Volver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			claseventas claseventas = new claseventas();
			claseventas.BuscarProductoPorIDoNombre(datagriinvetario, txtbuscar.Text);
		}
	}
}
