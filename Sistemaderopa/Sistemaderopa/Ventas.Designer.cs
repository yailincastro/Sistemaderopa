namespace Sistemaderopa
{
	partial class FrmVentas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.txtbuscar = new Guna.UI.WinForms.GunaTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.datagriarticulos = new Guna.UI.WinForms.GunaDataGridView();
			this.datagriventas = new Guna.UI.WinForms.GunaDataGridView();
			this.txttotal = new Guna.UI.WinForms.GunaTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtefectivo = new Guna.UI.WinForms.GunaTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtmontodevuelta = new Guna.UI.WinForms.GunaTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtdescuento = new Guna.UI.WinForms.GunaTextBox();
			this.btncalcular = new Guna.UI.WinForms.GunaButton();
			this.Volver = new System.Windows.Forms.PictureBox();
			this.btnbuscar = new Guna.UI.WinForms.GunaButton();
			this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.datagriarticulos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datagriventas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Volver)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// txtbuscar
			// 
			this.txtbuscar.BackColor = System.Drawing.Color.Transparent;
			this.txtbuscar.BaseColor = System.Drawing.Color.White;
			this.txtbuscar.BorderColor = System.Drawing.Color.Silver;
			this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtbuscar.FocusedBaseColor = System.Drawing.Color.White;
			this.txtbuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtbuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtbuscar.Location = new System.Drawing.Point(96, 41);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.PasswordChar = '\0';
			this.txtbuscar.Radius = 5;
			this.txtbuscar.SelectedText = "";
			this.txtbuscar.Size = new System.Drawing.Size(160, 30);
			this.txtbuscar.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Buscar";
			// 
			// datagriarticulos
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.datagriarticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.datagriarticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datagriarticulos.BackgroundColor = System.Drawing.Color.White;
			this.datagriarticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.datagriarticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagriarticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagriarticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.datagriarticulos.ColumnHeadersHeight = 20;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagriarticulos.DefaultCellStyle = dataGridViewCellStyle6;
			this.datagriarticulos.EnableHeadersVisualStyles = false;
			this.datagriarticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriarticulos.Location = new System.Drawing.Point(12, 81);
			this.datagriarticulos.Name = "datagriarticulos";
			this.datagriarticulos.RowHeadersVisible = false;
			this.datagriarticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagriarticulos.Size = new System.Drawing.Size(407, 166);
			this.datagriarticulos.TabIndex = 8;
			this.datagriarticulos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.datagriarticulos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.datagriarticulos.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.datagriarticulos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.datagriarticulos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.datagriarticulos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.datagriarticulos.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.datagriarticulos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriarticulos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datagriarticulos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.datagriarticulos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagriarticulos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.datagriarticulos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.datagriarticulos.ThemeStyle.HeaderStyle.Height = 20;
			this.datagriarticulos.ThemeStyle.ReadOnly = false;
			this.datagriarticulos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.datagriarticulos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagriarticulos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagriarticulos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.datagriarticulos.ThemeStyle.RowsStyle.Height = 22;
			this.datagriarticulos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriarticulos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.datagriarticulos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagriarticulos_CellEnter);
			this.datagriarticulos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagriarticulos_CellMouseClick);
			this.datagriarticulos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagriarticulos_CellMouseDown);
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
			this.datagriventas.ColumnHeadersHeight = 20;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagriventas.DefaultCellStyle = dataGridViewCellStyle3;
			this.datagriventas.EnableHeadersVisualStyles = false;
			this.datagriventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriventas.Location = new System.Drawing.Point(453, 121);
			this.datagriventas.Name = "datagriventas";
			this.datagriventas.RowHeadersVisible = false;
			this.datagriventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagriventas.Size = new System.Drawing.Size(355, 166);
			this.datagriventas.TabIndex = 8;
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
			this.datagriventas.ThemeStyle.HeaderStyle.Height = 20;
			this.datagriventas.ThemeStyle.ReadOnly = false;
			this.datagriventas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.datagriventas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagriventas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagriventas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.datagriventas.ThemeStyle.RowsStyle.Height = 22;
			this.datagriventas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriventas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.datagriventas.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagriventas_CellMouseDown);
			// 
			// txttotal
			// 
			this.txttotal.BackColor = System.Drawing.Color.Transparent;
			this.txttotal.BaseColor = System.Drawing.Color.White;
			this.txttotal.BorderColor = System.Drawing.Color.Silver;
			this.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttotal.FocusedBaseColor = System.Drawing.Color.White;
			this.txttotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txttotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txttotal.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttotal.Location = new System.Drawing.Point(155, 341);
			this.txttotal.Name = "txttotal";
			this.txttotal.PasswordChar = '\0';
			this.txttotal.Radius = 5;
			this.txttotal.SelectedText = "";
			this.txttotal.Size = new System.Drawing.Size(92, 30);
			this.txttotal.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 348);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Total a pagar";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(522, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Efectivo";
			// 
			// txtefectivo
			// 
			this.txtefectivo.BackColor = System.Drawing.Color.Transparent;
			this.txtefectivo.BaseColor = System.Drawing.Color.White;
			this.txtefectivo.BorderColor = System.Drawing.Color.Silver;
			this.txtefectivo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtefectivo.FocusedBaseColor = System.Drawing.Color.White;
			this.txtefectivo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtefectivo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtefectivo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtefectivo.Location = new System.Drawing.Point(602, 44);
			this.txtefectivo.Name = "txtefectivo";
			this.txtefectivo.PasswordChar = '\0';
			this.txtefectivo.Radius = 5;
			this.txtefectivo.SelectedText = "";
			this.txtefectivo.Size = new System.Drawing.Size(92, 30);
			this.txtefectivo.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(448, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Monto a Devolver";
			// 
			// txtmontodevuelta
			// 
			this.txtmontodevuelta.BackColor = System.Drawing.Color.Transparent;
			this.txtmontodevuelta.BaseColor = System.Drawing.Color.White;
			this.txtmontodevuelta.BorderColor = System.Drawing.Color.Silver;
			this.txtmontodevuelta.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmontodevuelta.FocusedBaseColor = System.Drawing.Color.White;
			this.txtmontodevuelta.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtmontodevuelta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtmontodevuelta.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtmontodevuelta.Location = new System.Drawing.Point(602, 81);
			this.txtmontodevuelta.Name = "txtmontodevuelta";
			this.txtmontodevuelta.PasswordChar = '\0';
			this.txtmontodevuelta.Radius = 5;
			this.txtmontodevuelta.SelectedText = "";
			this.txtmontodevuelta.Size = new System.Drawing.Size(92, 30);
			this.txtmontodevuelta.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(700, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Descuento";
			// 
			// txtdescuento
			// 
			this.txtdescuento.BackColor = System.Drawing.Color.Transparent;
			this.txtdescuento.BaseColor = System.Drawing.Color.White;
			this.txtdescuento.BorderColor = System.Drawing.Color.Silver;
			this.txtdescuento.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtdescuento.FocusedBaseColor = System.Drawing.Color.White;
			this.txtdescuento.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtdescuento.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtdescuento.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtdescuento.Location = new System.Drawing.Point(702, 81);
			this.txtdescuento.Name = "txtdescuento";
			this.txtdescuento.PasswordChar = '\0';
			this.txtdescuento.Radius = 5;
			this.txtdescuento.SelectedText = "";
			this.txtdescuento.Size = new System.Drawing.Size(92, 30);
			this.txtdescuento.TabIndex = 11;
			// 
			// btncalcular
			// 
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
			this.btncalcular.Location = new System.Drawing.Point(376, 338);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btncalcular.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btncalcular.OnHoverForeColor = System.Drawing.Color.White;
			this.btncalcular.OnHoverImage = null;
			this.btncalcular.OnPressedColor = System.Drawing.Color.Black;
			this.btncalcular.Radius = 10;
			this.btncalcular.Size = new System.Drawing.Size(94, 35);
			this.btncalcular.TabIndex = 22;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
			// 
			// Volver
			// 
			this.Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Volver.Image = global::Sistemaderopa.Properties.Resources.deshacer;
			this.Volver.Location = new System.Drawing.Point(826, 5);
			this.Volver.Name = "Volver";
			this.Volver.Size = new System.Drawing.Size(31, 28);
			this.Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Volver.TabIndex = 21;
			this.Volver.TabStop = false;
			this.Volver.Click += new System.EventHandler(this.Volver_Click);
			// 
			// btnbuscar
			// 
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
			this.btnbuscar.Location = new System.Drawing.Point(273, 35);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 12;
			this.btnbuscar.Size = new System.Drawing.Size(87, 36);
			this.btnbuscar.TabIndex = 18;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// gunaButton2
			// 
			this.gunaButton2.AnimationHoverSpeed = 0.07F;
			this.gunaButton2.AnimationSpeed = 0.03F;
			this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
			this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.gunaButton2.BorderColor = System.Drawing.Color.Black;
			this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
			this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
			this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.gunaButton2.ForeColor = System.Drawing.Color.White;
			this.gunaButton2.Image = global::Sistemaderopa.Properties.Resources.ingresos;
			this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
			this.gunaButton2.Location = new System.Drawing.Point(266, 337);
			this.gunaButton2.Name = "gunaButton2";
			this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
			this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
			this.gunaButton2.OnHoverImage = null;
			this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
			this.gunaButton2.Radius = 12;
			this.gunaButton2.Size = new System.Drawing.Size(94, 36);
			this.gunaButton2.TabIndex = 9;
			this.gunaButton2.Text = "Pagar";
			this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(861, 24);
			this.menuStrip1.TabIndex = 23;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// herramientasToolStripMenuItem
			// 
			this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem});
			this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
			this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.herramientasToolStripMenuItem.Text = "Herramientas";
			// 
			// calculadoraToolStripMenuItem
			// 
			this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
			this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.calculadoraToolStripMenuItem.Text = "Calculadora";
			this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
			// 
			// FrmVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 407);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.Volver);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtmontodevuelta);
			this.Controls.Add(this.txtdescuento);
			this.Controls.Add(this.txtefectivo);
			this.Controls.Add(this.txttotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gunaButton2);
			this.Controls.Add(this.datagriventas);
			this.Controls.Add(this.datagriarticulos);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmVentas";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.FrmVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.datagriarticulos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datagriventas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Volver)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaDataGridView datagriarticulos;
		private Guna.UI.WinForms.GunaTextBox txtbuscar;
		private System.Windows.Forms.Label label1;
		private Guna.UI.WinForms.GunaTextBox txtmontodevuelta;
		private Guna.UI.WinForms.GunaTextBox txtefectivo;
		private Guna.UI.WinForms.GunaTextBox txttotal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private Guna.UI.WinForms.GunaButton gunaButton2;
		private Guna.UI.WinForms.GunaDataGridView datagriventas;
		private Guna.UI.WinForms.GunaButton btnbuscar;
		private System.Windows.Forms.PictureBox Volver;
		private Guna.UI.WinForms.GunaTextBox txtdescuento;
		private System.Windows.Forms.Label label5;
		private Guna.UI.WinForms.GunaButton btncalcular;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
	}
}