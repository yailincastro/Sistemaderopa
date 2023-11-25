using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemaderopa
{
	internal class claseconexion
	{
		SqlConnection conex = new SqlConnection();
		string CadenaConnection = "Data Source=W7USER-PC\\SQLEXPRESS;Initial Catalog=Ropa;Integrated Security=True";
		public SqlConnection Establecerconexion()
		{

			try
			{
				conex.ConnectionString = CadenaConnection;
				conex.Open();


			}
			catch (Exception ex)
			{
				MessageBox.Show("No Se a podido conectado" + ex.ToString());
			}
			return conex;
		}
		public void cerrarconexion()
		{
			conex.Close();
		}
	}
}
