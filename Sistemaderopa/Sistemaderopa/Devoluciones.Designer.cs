namespace Sistemaderopa
{
	partial class FrmDevoluciones
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevoluciones));
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.txtarticulo = new Guna.UI.WinForms.GunaTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtrazon = new Guna.UI.WinForms.GunaTextBox();
			this.FEcha = new Guna.UI.WinForms.GunaDateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtcantidad = new Guna.UI.WinForms.GunaTextBox();
			this.datagridevolucion = new Guna.UI.WinForms.GunaDataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.btnbuscar = new Guna.UI.WinForms.GunaButton();
			this.txtbuscar = new Guna.UI.WinForms.GunaTextBox();
			this.btncalcular = new Guna.UI.WinForms.GunaButton();
			this.txtid = new Guna.UI.WinForms.GunaTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtfactura = new Guna.UI.WinForms.GunaTextBox();
			((System.ComponentModel.ISupportInitialize)(this.datagridevolucion)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(87, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "Articulo";
			// 
			// txtarticulo
			// 
			this.txtarticulo.BackColor = System.Drawing.Color.Transparent;
			this.txtarticulo.BaseColor = System.Drawing.Color.White;
			this.txtarticulo.BorderColor = System.Drawing.Color.Silver;
			this.txtarticulo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtarticulo.FocusedBaseColor = System.Drawing.Color.White;
			this.txtarticulo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtarticulo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtarticulo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtarticulo.Location = new System.Drawing.Point(163, 62);
			this.txtarticulo.Name = "txtarticulo";
			this.txtarticulo.PasswordChar = '\0';
			this.txtarticulo.Radius = 5;
			this.txtarticulo.SelectedText = "";
			this.txtarticulo.Size = new System.Drawing.Size(130, 30);
			this.txtarticulo.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(371, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Razon";
			// 
			// txtrazon
			// 
			this.txtrazon.BackColor = System.Drawing.Color.Transparent;
			this.txtrazon.BaseColor = System.Drawing.Color.White;
			this.txtrazon.BorderColor = System.Drawing.Color.Silver;
			this.txtrazon.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtrazon.FocusedBaseColor = System.Drawing.Color.White;
			this.txtrazon.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtrazon.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtrazon.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtrazon.Location = new System.Drawing.Point(438, 54);
			this.txtrazon.Name = "txtrazon";
			this.txtrazon.PasswordChar = '\0';
			this.txtrazon.Radius = 5;
			this.txtrazon.SelectedText = "";
			this.txtrazon.Size = new System.Drawing.Size(130, 30);
			this.txtrazon.TabIndex = 16;
			// 
			// FEcha
			// 
			this.FEcha.BackColor = System.Drawing.Color.Transparent;
			this.FEcha.BaseColor = System.Drawing.Color.White;
			this.FEcha.BorderColor = System.Drawing.Color.Silver;
			this.FEcha.CustomFormat = null;
			this.FEcha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.FEcha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.FEcha.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FEcha.ForeColor = System.Drawing.Color.Black;
			this.FEcha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.FEcha.Location = new System.Drawing.Point(438, 9);
			this.FEcha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.FEcha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.FEcha.Name = "FEcha";
			this.FEcha.OnHoverBaseColor = System.Drawing.Color.White;
			this.FEcha.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.FEcha.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.FEcha.OnPressedColor = System.Drawing.Color.Black;
			this.FEcha.Radius = 5;
			this.FEcha.Size = new System.Drawing.Size(139, 30);
			this.FEcha.TabIndex = 18;
			this.FEcha.Text = "29/10/2023";
			this.FEcha.Value = new System.DateTime(2023, 10, 29, 16, 1, 42, 363);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(373, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Fecha";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(76, 109);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 20);
			this.label8.TabIndex = 12;
			this.label8.Text = "Cantidad";
			// 
			// txtcantidad
			// 
			this.txtcantidad.BackColor = System.Drawing.Color.Transparent;
			this.txtcantidad.BaseColor = System.Drawing.Color.White;
			this.txtcantidad.BorderColor = System.Drawing.Color.Silver;
			this.txtcantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtcantidad.FocusedBaseColor = System.Drawing.Color.White;
			this.txtcantidad.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtcantidad.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtcantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtcantidad.Location = new System.Drawing.Point(163, 103);
			this.txtcantidad.Name = "txtcantidad";
			this.txtcantidad.PasswordChar = '\0';
			this.txtcantidad.Radius = 5;
			this.txtcantidad.SelectedText = "";
			this.txtcantidad.Size = new System.Drawing.Size(130, 30);
			this.txtcantidad.TabIndex = 16;
			// 
			// datagridevolucion
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.datagridevolucion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.datagridevolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datagridevolucion.BackgroundColor = System.Drawing.Color.White;
			this.datagridevolucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.datagridevolucion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagridevolucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagridevolucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.datagridevolucion.ColumnHeadersHeight = 20;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagridevolucion.DefaultCellStyle = dataGridViewCellStyle6;
			this.datagridevolucion.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.datagridevolucion.EnableHeadersVisualStyles = false;
			this.datagridevolucion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagridevolucion.Location = new System.Drawing.Point(0, 263);
			this.datagridevolucion.Name = "datagridevolucion";
			this.datagridevolucion.RowHeadersVisible = false;
			this.datagridevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagridevolucion.Size = new System.Drawing.Size(800, 187);
			this.datagridevolucion.TabIndex = 19;
			this.datagridevolucion.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.datagridevolucion.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.datagridevolucion.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.datagridevolucion.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.datagridevolucion.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.datagridevolucion.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.datagridevolucion.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.datagridevolucion.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagridevolucion.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datagridevolucion.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.datagridevolucion.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagridevolucion.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.datagridevolucion.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.datagridevolucion.ThemeStyle.HeaderStyle.Height = 20;
			this.datagridevolucion.ThemeStyle.ReadOnly = false;
			this.datagridevolucion.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.datagridevolucion.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagridevolucion.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagridevolucion.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.datagridevolucion.ThemeStyle.RowsStyle.Height = 22;
			this.datagridevolucion.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagridevolucion.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.datagridevolucion.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridevolucion_CellMouseDown);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(4, 204);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(132, 20);
			this.label9.TabIndex = 22;
			this.label9.Text = "Buscar Factura";
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
			this.btnbuscar.Location = new System.Drawing.Point(154, 224);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 12;
			this.btnbuscar.Size = new System.Drawing.Size(98, 33);
			this.btnbuscar.TabIndex = 21;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
			this.txtbuscar.Location = new System.Drawing.Point(8, 227);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.PasswordChar = '\0';
			this.txtbuscar.Radius = 5;
			this.txtbuscar.SelectedText = "";
			this.txtbuscar.Size = new System.Drawing.Size(122, 30);
			this.txtbuscar.TabIndex = 20;
			// 
			// btncalcular
			// 
			this.btncalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btncalcular.AnimationHoverSpeed = 0.07F;
			this.btncalcular.AnimationSpeed = 0.03F;
			this.btncalcular.BackColor = System.Drawing.Color.Transparent;
			this.btncalcular.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btncalcular.BorderColor = System.Drawing.Color.Black;
			this.btncalcular.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btncalcular.FocusedColor = System.Drawing.Color.Empty;
			this.btncalcular.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btncalcular.ForeColor = System.Drawing.Color.White;
			this.btncalcular.Image = ((System.Drawing.Image)(resources.GetObject("btncalcular.Image")));
			this.btncalcular.ImageSize = new System.Drawing.Size(20, 20);
			this.btncalcular.Location = new System.Drawing.Point(274, 222);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btncalcular.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btncalcular.OnHoverForeColor = System.Drawing.Color.White;
			this.btncalcular.OnHoverImage = null;
			this.btncalcular.OnPressedColor = System.Drawing.Color.Black;
			this.btncalcular.Radius = 10;
			this.btncalcular.Size = new System.Drawing.Size(94, 35);
			this.btncalcular.TabIndex = 23;
			this.btncalcular.Text = "Reportar";
			this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
			// 
			// txtid
			// 
			this.txtid.BackColor = System.Drawing.Color.Transparent;
			this.txtid.BaseColor = System.Drawing.Color.White;
			this.txtid.BorderColor = System.Drawing.Color.Silver;
			this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtid.FocusedBaseColor = System.Drawing.Color.White;
			this.txtid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtid.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtid.Location = new System.Drawing.Point(163, 62);
			this.txtid.Name = "txtid";
			this.txtid.PasswordChar = '\0';
			this.txtid.Radius = 5;
			this.txtid.SelectedText = "";
			this.txtid.Size = new System.Drawing.Size(130, 30);
			this.txtid.TabIndex = 16;
			this.txtid.Visible = false;
			this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(62, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Factura ID";
			// 
			// txtfactura
			// 
			this.txtfactura.BackColor = System.Drawing.Color.Transparent;
			this.txtfactura.BaseColor = System.Drawing.Color.White;
			this.txtfactura.BorderColor = System.Drawing.Color.Silver;
			this.txtfactura.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtfactura.FocusedBaseColor = System.Drawing.Color.White;
			this.txtfactura.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtfactura.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtfactura.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtfactura.Location = new System.Drawing.Point(163, 19);
			this.txtfactura.Name = "txtfactura";
			this.txtfactura.PasswordChar = '\0';
			this.txtfactura.Radius = 5;
			this.txtfactura.SelectedText = "";
			this.txtfactura.Size = new System.Drawing.Size(130, 30);
			this.txtfactura.TabIndex = 16;
			// 
			// FrmDevoluciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.datagridevolucion);
			this.Controls.Add(this.FEcha);
			this.Controls.Add(this.txtfactura);
			this.Controls.Add(this.txtcantidad);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtarticulo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtrazon);
			this.Controls.Add(this.label6);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmDevoluciones";
			this.Text = "Devoluciones";
			this.Load += new System.EventHandler(this.FrmDevoluciones_Load);
			((System.ComponentModel.ISupportInitialize)(this.datagridevolucion)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaTextBox txtarticulo;
		private System.Windows.Forms.Label label2;
		private Guna.UI.WinForms.GunaTextBox txtrazon;
		private System.Windows.Forms.Label label6;
		private Guna.UI.WinForms.GunaDateTimePicker FEcha;
		private System.Windows.Forms.Label label7;
		private Guna.UI.WinForms.GunaDataGridView datagridevolucion;
		private Guna.UI.WinForms.GunaTextBox txtcantidad;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private Guna.UI.WinForms.GunaButton btnbuscar;
		private Guna.UI.WinForms.GunaTextBox txtbuscar;
		private Guna.UI.WinForms.GunaButton btncalcular;
		private Guna.UI.WinForms.GunaTextBox txtid;
		private Guna.UI.WinForms.GunaTextBox txtfactura;
		private System.Windows.Forms.Label label1;
	}
}