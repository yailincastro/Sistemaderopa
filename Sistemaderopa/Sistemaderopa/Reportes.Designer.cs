namespace Sistemaderopa
{
	partial class FrmReportes
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.reportesDeLasVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reporteDeLasDevolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reporteDeLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Volver = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Volver)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeLasVentasToolStripMenuItem,
            this.reporteDeLasDevolucionesToolStripMenuItem,
            this.reporteDeLosProductosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 22;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// reportesDeLasVentasToolStripMenuItem
			// 
			this.reportesDeLasVentasToolStripMenuItem.Name = "reportesDeLasVentasToolStripMenuItem";
			this.reportesDeLasVentasToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
			this.reportesDeLasVentasToolStripMenuItem.Text = "Reportes de las ventas";
			this.reportesDeLasVentasToolStripMenuItem.Click += new System.EventHandler(this.reportesDeLasVentasToolStripMenuItem_Click);
			// 
			// reporteDeLasDevolucionesToolStripMenuItem
			// 
			this.reporteDeLasDevolucionesToolStripMenuItem.Name = "reporteDeLasDevolucionesToolStripMenuItem";
			this.reporteDeLasDevolucionesToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
			this.reporteDeLasDevolucionesToolStripMenuItem.Text = "Reporte de las devoluciones";
			this.reporteDeLasDevolucionesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeLasDevolucionesToolStripMenuItem_Click);
			// 
			// reporteDeLosProductosToolStripMenuItem
			// 
			this.reporteDeLosProductosToolStripMenuItem.Name = "reporteDeLosProductosToolStripMenuItem";
			this.reporteDeLosProductosToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
			this.reporteDeLosProductosToolStripMenuItem.Text = "Reporte de los Productos";
			this.reporteDeLosProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeLosProductosToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 426);
			this.panel1.TabIndex = 23;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// Volver
			// 
			this.Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Volver.Image = global::Sistemaderopa.Properties.Resources.deshacer;
			this.Volver.Location = new System.Drawing.Point(766, 0);
			this.Volver.Name = "Volver";
			this.Volver.Size = new System.Drawing.Size(31, 24);
			this.Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Volver.TabIndex = 21;
			this.Volver.TabStop = false;
			this.Volver.Click += new System.EventHandler(this.Volver_Click);
			// 
			// FrmReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Volver);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmReportes";
			this.Text = "Reportes";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Volver)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private System.Windows.Forms.PictureBox Volver;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem reportesDeLasVentasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reporteDeLasDevolucionesToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem reporteDeLosProductosToolStripMenuItem;
	}
}