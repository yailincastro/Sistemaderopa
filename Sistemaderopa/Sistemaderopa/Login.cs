using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemaderopa
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{

		}
		public void Cuentas(GunaTextBox paramNombre, GunaTextBox ParamClave)
		{
			string CadenaConnection = "Data Source=DESKTOP-TP2GOM2\\SQLEXPRESS;Initial Catalog=Ropa;Integrated Security=True";
			SqlConnection conex = new SqlConnection(CadenaConnection);
			try
			{
				conex.Open();
				SqlCommand cmd = new SqlCommand("select Correo,Clave from LOGIN where Correo='" + paramNombre.Text + "' and Clave ='" + ParamClave.Text + "'", conex);

				SqlDataReader sql = cmd.ExecuteReader();
				if (sql.Read())

				{
					this.Hide();

					FrmMenu llama = new FrmMenu();
					llama.Show();


				}
				else
				{
					MessageBox.Show("Usuario invalido");
				}
			}
			catch (Exception ex)
			{


				MessageBox.Show("Usuario invalido" + ex.ToString());



			}
		}

		private void btnentrar_Click(object sender, EventArgs e)
		{
			Cuentas(txtcorreo, Txtclave);
		}

		private void cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
