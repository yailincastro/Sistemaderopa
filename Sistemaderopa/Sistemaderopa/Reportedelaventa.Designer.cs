namespace Sistemaderopa
{
	partial class FrmReportedelaventa
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.txtbuscar = new Guna.UI.WinForms.GunaTextBox();
			this.btnbuscar = new Guna.UI.WinForms.GunaButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.datagriventas = new Guna.UI.WinForms.GunaDataGridView();
			this.btnimprimir = new Guna.UI.WinForms.GunaButton();
			this.dataSetVentas = new Sistemaderopa.DataSetVentas();
			this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagriventas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetVentas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Buscar ventas";
			// 
			// txtbuscar
			// 
			this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtbuscar.BackColor = System.Drawing.Color.Transparent;
			this.txtbuscar.BaseColor = System.Drawing.Color.White;
			this.txtbuscar.BorderColor = System.Drawing.Color.Silver;
			this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtbuscar.FocusedBaseColor = System.Drawing.Color.White;
			this.txtbuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtbuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtbuscar.Location = new System.Drawing.Point(13, 131);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.PasswordChar = '\0';
			this.txtbuscar.Radius = 5;
			this.txtbuscar.SelectedText = "";
			this.txtbuscar.Size = new System.Drawing.Size(160, 30);
			this.txtbuscar.TabIndex = 1;
			// 
			// btnbuscar
			// 
			this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnbuscar.AnimationHoverSpeed = 0.07F;
			this.btnbuscar.AnimationSpeed = 0.03F;
			this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
			this.btnbuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnbuscar.BorderColor = System.Drawing.Color.Black;
			this.btnbuscar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnbuscar.FocusedColor = System.Drawing.Color.Empty;
			this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnbuscar.ForeColor = System.Drawing.Color.White;
			this.btnbuscar.Image = global::Sistemaderopa.Properties.Resources.buscar;
			this.btnbuscar.ImageSize = new System.Drawing.Size(20, 20);
			this.btnbuscar.Location = new System.Drawing.Point(200, 127);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 12;
			this.btnbuscar.Size = new System.Drawing.Size(98, 34);
			this.btnbuscar.TabIndex = 18;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.reportViewer1);
			this.panel1.Controls.Add(this.datagriventas);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 171);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 279);
			this.panel1.TabIndex = 19;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "Ventas";
			reportDataSource1.Value = this.ventasBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistemaderopa.Informeventas.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(800, 279);
			this.reportViewer1.TabIndex = 21;
			this.reportViewer1.Visible = false;
			// 
			// datagriventas
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.datagriventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.datagriventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datagriventas.BackgroundColor = System.Drawing.Color.White;
			this.datagriventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.datagriventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagriventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagriventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.datagriventas.ColumnHeadersHeight = 4;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagriventas.DefaultCellStyle = dataGridViewCellStyle3;
			this.datagriventas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.datagriventas.EnableHeadersVisualStyles = false;
			this.datagriventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriventas.Location = new System.Drawing.Point(0, 0);
			this.datagriventas.Name = "datagriventas";
			this.datagriventas.RowHeadersVisible = false;
			this.datagriventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagriventas.Size = new System.Drawing.Size(800, 279);
			this.datagriventas.TabIndex = 20;
			this.datagriventas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.datagriventas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.datagriventas.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.datagriventas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.datagriventas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.datagriventas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.datagriventas.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.datagriventas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriventas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datagriventas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.datagriventas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagriventas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.datagriventas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.datagriventas.ThemeStyle.HeaderStyle.Height = 4;
			this.datagriventas.ThemeStyle.ReadOnly = false;
			this.datagriventas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.datagriventas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagriventas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagriventas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.datagriventas.ThemeStyle.RowsStyle.Height = 22;
			this.datagriventas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriventas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// btnimprimir
			// 
			this.btnimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnimprimir.AnimationHoverSpeed = 0.07F;
			this.btnimprimir.AnimationSpeed = 0.03F;
			this.btnimprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnimprimir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnimprimir.BorderColor = System.Drawing.Color.Black;
			this.btnimprimir.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnimprimir.FocusedColor = System.Drawing.Color.Empty;
			this.btnimprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnimprimir.ForeColor = System.Drawing.Color.White;
			this.btnimprimir.Image = global::Sistemaderopa.Properties.Resources.buscar;
			this.btnimprimir.ImageSize = new System.Drawing.Size(20, 20);
			this.btnimprimir.Location = new System.Drawing.Point(310, 127);
			this.btnimprimir.Name = "btnimprimir";
			this.btnimprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnimprimir.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnimprimir.OnHoverForeColor = System.Drawing.Color.White;
			this.btnimprimir.OnHoverImage = null;
			this.btnimprimir.OnPressedColor = System.Drawing.Color.Black;
			this.btnimprimir.Radius = 12;
			this.btnimprimir.Size = new System.Drawing.Size(98, 34);
			this.btnimprimir.TabIndex = 23;
			this.btnimprimir.Text = "Imprimir";
			this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
			// 
			// dataSetVentas
			// 
			this.dataSetVentas.DataSetName = "DataSetVentas";
			this.dataSetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ventasBindingSource
			// 
			this.ventasBindingSource.DataMember = "Ventas";
			this.ventasBindingSource.DataSource = this.dataSetVentas;
			// 
			// FrmReportedelaventa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnimprimir);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmReportedelaventa";
			this.Text = "Reportedelaventa";
			this.Load += new System.EventHandler(this.FrmReportedelaventa_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.datagriventas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetVentas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaTextBox txtbuscar;
		private System.Windows.Forms.Label label1;
		private Guna.UI.WinForms.GunaButton btnbuscar;
		private System.Windows.Forms.Panel panel1;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private Guna.UI.WinForms.GunaDataGridView datagriventas;
		private Guna.UI.WinForms.GunaButton btnimprimir;
		private System.Windows.Forms.BindingSource ventasBindingSource;
		private DataSetVentas dataSetVentas;
	}
}