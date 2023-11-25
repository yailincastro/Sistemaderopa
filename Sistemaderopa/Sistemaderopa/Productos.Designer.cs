namespace Sistemaderopa
{
	partial class FrmProductos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.txtcantidad = new Guna.UI.WinForms.GunaTextBox();
			this.txtarticulo = new Guna.UI.WinForms.GunaTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Txtcolor = new Guna.UI.WinForms.GunaTextBox();
			this.txtbuscar = new Guna.UI.WinForms.GunaTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtprecio = new Guna.UI.WinForms.GunaTextBox();
			this.txtId = new Guna.UI.WinForms.GunaTextBox();
			this.Datagriproducto = new Guna.UI.WinForms.GunaDataGridView();
			this.Volver = new System.Windows.Forms.PictureBox();
			this.btneliminar = new Guna.UI.WinForms.GunaButton();
			this.btnmodificar = new Guna.UI.WinForms.GunaButton();
			this.btnregistrar = new Guna.UI.WinForms.GunaButton();
			this.btnbuscar = new Guna.UI.WinForms.GunaButton();
			((System.ComponentModel.ISupportInitialize)(this.Datagriproducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Volver)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
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
			this.txtcantidad.Location = new System.Drawing.Point(369, 43);
			this.txtcantidad.Name = "txtcantidad";
			this.txtcantidad.PasswordChar = '\0';
			this.txtcantidad.Radius = 5;
			this.txtcantidad.SelectedText = "";
			this.txtcantidad.Size = new System.Drawing.Size(134, 30);
			this.txtcantidad.TabIndex = 14;
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
			this.txtarticulo.Location = new System.Drawing.Point(124, 42);
			this.txtarticulo.Name = "txtarticulo";
			this.txtarticulo.PasswordChar = '\0';
			this.txtarticulo.Radius = 5;
			this.txtarticulo.SelectedText = "";
			this.txtarticulo.Size = new System.Drawing.Size(92, 30);
			this.txtarticulo.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(279, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "Cantidad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(48, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 20);
			this.label3.TabIndex = 13;
			this.label3.Text = "Articulo";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(59, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Color";
			// 
			// Txtcolor
			// 
			this.Txtcolor.BackColor = System.Drawing.Color.Transparent;
			this.Txtcolor.BaseColor = System.Drawing.Color.White;
			this.Txtcolor.BorderColor = System.Drawing.Color.Silver;
			this.Txtcolor.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Txtcolor.FocusedBaseColor = System.Drawing.Color.White;
			this.Txtcolor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Txtcolor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.Txtcolor.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Txtcolor.Location = new System.Drawing.Point(124, 100);
			this.Txtcolor.Name = "Txtcolor";
			this.Txtcolor.PasswordChar = '\0';
			this.Txtcolor.Radius = 5;
			this.Txtcolor.SelectedText = "";
			this.Txtcolor.Size = new System.Drawing.Size(131, 30);
			this.Txtcolor.TabIndex = 14;
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
			this.txtbuscar.Location = new System.Drawing.Point(30, 251);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.PasswordChar = '\0';
			this.txtbuscar.Radius = 5;
			this.txtbuscar.SelectedText = "";
			this.txtbuscar.Size = new System.Drawing.Size(122, 30);
			this.txtbuscar.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 228);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 20);
			this.label2.TabIndex = 18;
			this.label2.Text = "Buscar arituclo";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(304, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 20);
			this.label5.TabIndex = 12;
			this.label5.Text = "Precio";
			// 
			// txtprecio
			// 
			this.txtprecio.BackColor = System.Drawing.Color.Transparent;
			this.txtprecio.BaseColor = System.Drawing.Color.White;
			this.txtprecio.BorderColor = System.Drawing.Color.Silver;
			this.txtprecio.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtprecio.FocusedBaseColor = System.Drawing.Color.White;
			this.txtprecio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtprecio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtprecio.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtprecio.Location = new System.Drawing.Point(369, 107);
			this.txtprecio.Name = "txtprecio";
			this.txtprecio.PasswordChar = '\0';
			this.txtprecio.Radius = 5;
			this.txtprecio.SelectedText = "";
			this.txtprecio.Size = new System.Drawing.Size(134, 30);
			this.txtprecio.TabIndex = 14;
			// 
			// txtId
			// 
			this.txtId.BackColor = System.Drawing.Color.Transparent;
			this.txtId.BaseColor = System.Drawing.Color.White;
			this.txtId.BorderColor = System.Drawing.Color.Silver;
			this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtId.FocusedBaseColor = System.Drawing.Color.White;
			this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtId.Location = new System.Drawing.Point(124, 42);
			this.txtId.Name = "txtId";
			this.txtId.PasswordChar = '\0';
			this.txtId.Radius = 5;
			this.txtId.SelectedText = "";
			this.txtId.Size = new System.Drawing.Size(131, 30);
			this.txtId.TabIndex = 15;
			this.txtId.Visible = false;
			// 
			// Datagriproducto
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.Datagriproducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.Datagriproducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Datagriproducto.BackgroundColor = System.Drawing.Color.White;
			this.Datagriproducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Datagriproducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.Datagriproducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Datagriproducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Datagriproducto.ColumnHeadersHeight = 20;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Datagriproducto.DefaultCellStyle = dataGridViewCellStyle3;
			this.Datagriproducto.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Datagriproducto.EnableHeadersVisualStyles = false;
			this.Datagriproducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.Datagriproducto.Location = new System.Drawing.Point(0, 300);
			this.Datagriproducto.Name = "Datagriproducto";
			this.Datagriproducto.RowHeadersVisible = false;
			this.Datagriproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Datagriproducto.Size = new System.Drawing.Size(781, 150);
			this.Datagriproducto.TabIndex = 19;
			this.Datagriproducto.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.Datagriproducto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.Datagriproducto.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.Datagriproducto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.Datagriproducto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.Datagriproducto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.Datagriproducto.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.Datagriproducto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.Datagriproducto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Datagriproducto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Datagriproducto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.Datagriproducto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.Datagriproducto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.Datagriproducto.ThemeStyle.HeaderStyle.Height = 20;
			this.Datagriproducto.ThemeStyle.ReadOnly = false;
			this.Datagriproducto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.Datagriproducto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.Datagriproducto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.Datagriproducto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.Datagriproducto.ThemeStyle.RowsStyle.Height = 22;
			this.Datagriproducto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.Datagriproducto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.Datagriproducto.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Datagriproducto_CellMouseDown);
			// 
			// Volver
			// 
			this.Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Volver.Image = global::Sistemaderopa.Properties.Resources.deshacer;
			this.Volver.Location = new System.Drawing.Point(747, 4);
			this.Volver.Name = "Volver";
			this.Volver.Size = new System.Drawing.Size(31, 28);
			this.Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Volver.TabIndex = 20;
			this.Volver.TabStop = false;
			this.Volver.Click += new System.EventHandler(this.Volver_Click);
			// 
			// btneliminar
			// 
			this.btneliminar.AnimationHoverSpeed = 0.07F;
			this.btneliminar.AnimationSpeed = 0.03F;
			this.btneliminar.BackColor = System.Drawing.Color.Transparent;
			this.btneliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btneliminar.BorderColor = System.Drawing.Color.Black;
			this.btneliminar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btneliminar.FocusedColor = System.Drawing.Color.Empty;
			this.btneliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btneliminar.ForeColor = System.Drawing.Color.White;
			this.btneliminar.Image = global::Sistemaderopa.Properties.Resources.eliminar;
			this.btneliminar.ImageSize = new System.Drawing.Size(20, 20);
			this.btneliminar.Location = new System.Drawing.Point(601, 248);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btneliminar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btneliminar.OnHoverForeColor = System.Drawing.Color.White;
			this.btneliminar.OnHoverImage = null;
			this.btneliminar.OnPressedColor = System.Drawing.Color.Black;
			this.btneliminar.Radius = 12;
			this.btneliminar.Size = new System.Drawing.Size(98, 36);
			this.btneliminar.TabIndex = 17;
			this.btneliminar.Text = "Eliminar";
			this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
			// 
			// btnmodificar
			// 
			this.btnmodificar.AnimationHoverSpeed = 0.07F;
			this.btnmodificar.AnimationSpeed = 0.03F;
			this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
			this.btnmodificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnmodificar.BorderColor = System.Drawing.Color.Black;
			this.btnmodificar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnmodificar.FocusedColor = System.Drawing.Color.Empty;
			this.btnmodificar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnmodificar.ForeColor = System.Drawing.Color.White;
			this.btnmodificar.Image = global::Sistemaderopa.Properties.Resources.editar;
			this.btnmodificar.ImageSize = new System.Drawing.Size(20, 20);
			this.btnmodificar.Location = new System.Drawing.Point(465, 248);
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnmodificar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnmodificar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnmodificar.OnHoverImage = null;
			this.btnmodificar.OnPressedColor = System.Drawing.Color.Black;
			this.btnmodificar.Radius = 12;
			this.btnmodificar.Size = new System.Drawing.Size(98, 36);
			this.btnmodificar.TabIndex = 17;
			this.btnmodificar.Text = "Modificar";
			this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
			// 
			// btnregistrar
			// 
			this.btnregistrar.AnimationHoverSpeed = 0.07F;
			this.btnregistrar.AnimationSpeed = 0.03F;
			this.btnregistrar.BackColor = System.Drawing.Color.Transparent;
			this.btnregistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnregistrar.BorderColor = System.Drawing.Color.Black;
			this.btnregistrar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnregistrar.FocusedColor = System.Drawing.Color.Empty;
			this.btnregistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnregistrar.ForeColor = System.Drawing.Color.White;
			this.btnregistrar.Image = global::Sistemaderopa.Properties.Resources.anadir;
			this.btnregistrar.ImageSize = new System.Drawing.Size(20, 20);
			this.btnregistrar.Location = new System.Drawing.Point(332, 248);
			this.btnregistrar.Name = "btnregistrar";
			this.btnregistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnregistrar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnregistrar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnregistrar.OnHoverImage = null;
			this.btnregistrar.OnPressedColor = System.Drawing.Color.Black;
			this.btnregistrar.Radius = 12;
			this.btnregistrar.Size = new System.Drawing.Size(98, 36);
			this.btnregistrar.TabIndex = 17;
			this.btnregistrar.Text = "Registrar";
			this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
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
			this.btnbuscar.Location = new System.Drawing.Point(198, 248);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 12;
			this.btnbuscar.Size = new System.Drawing.Size(98, 36);
			this.btnbuscar.TabIndex = 17;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// FrmProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 450);
			this.Controls.Add(this.Volver);
			this.Controls.Add(this.Datagriproducto);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btneliminar);
			this.Controls.Add(this.btnmodificar);
			this.Controls.Add(this.btnregistrar);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.Txtcolor);
			this.Controls.Add(this.txtprecio);
			this.Controls.Add(this.txtcantidad);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtarticulo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmProductos";
			this.Text = "Productos";
			((System.ComponentModel.ISupportInitialize)(this.Datagriproducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Volver)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaTextBox txtcantidad;
		private Guna.UI.WinForms.GunaTextBox txtarticulo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private Guna.UI.WinForms.GunaTextBox Txtcolor;
		private System.Windows.Forms.Label label1;
		private Guna.UI.WinForms.GunaButton btneliminar;
		private Guna.UI.WinForms.GunaButton btnmodificar;
		private Guna.UI.WinForms.GunaButton btnregistrar;
		private Guna.UI.WinForms.GunaButton btnbuscar;
		private Guna.UI.WinForms.GunaTextBox txtbuscar;
		private System.Windows.Forms.Label label2;
		private Guna.UI.WinForms.GunaTextBox txtprecio;
		private System.Windows.Forms.Label label5;
		private Guna.UI.WinForms.GunaTextBox txtId;
		private Guna.UI.WinForms.GunaDataGridView Datagriproducto;
		private System.Windows.Forms.PictureBox Volver;
	}
}