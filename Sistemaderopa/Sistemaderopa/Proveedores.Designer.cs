namespace Sistemaderopa
{
	partial class FrmProveedores
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
			this.Datagriproveedor = new Guna.UI.WinForms.GunaDataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.Txtnombre = new Guna.UI.WinForms.GunaTextBox();
			this.txtdireccion = new Guna.UI.WinForms.GunaTextBox();
			this.txttelefono = new Guna.UI.WinForms.GunaTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtbuscar = new Guna.UI.WinForms.GunaTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtId = new Guna.UI.WinForms.GunaTextBox();
			this.txtarticulo = new Guna.UI.WinForms.GunaTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btneliminar = new Guna.UI.WinForms.GunaButton();
			this.btnmodificar = new Guna.UI.WinForms.GunaButton();
			this.btnregistrar = new Guna.UI.WinForms.GunaButton();
			this.btnbuscar = new Guna.UI.WinForms.GunaButton();
			this.Volver = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Datagriproveedor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Volver)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// Datagriproveedor
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.Datagriproveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.Datagriproveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Datagriproveedor.BackgroundColor = System.Drawing.Color.White;
			this.Datagriproveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Datagriproveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.Datagriproveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Datagriproveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Datagriproveedor.ColumnHeadersHeight = 20;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Datagriproveedor.DefaultCellStyle = dataGridViewCellStyle3;
			this.Datagriproveedor.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Datagriproveedor.EnableHeadersVisualStyles = false;
			this.Datagriproveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.Datagriproveedor.Location = new System.Drawing.Point(0, 300);
			this.Datagriproveedor.Name = "Datagriproveedor";
			this.Datagriproveedor.RowHeadersVisible = false;
			this.Datagriproveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Datagriproveedor.Size = new System.Drawing.Size(800, 150);
			this.Datagriproveedor.TabIndex = 35;
			this.Datagriproveedor.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.Datagriproveedor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.Datagriproveedor.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.Datagriproveedor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.Datagriproveedor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.Datagriproveedor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.Datagriproveedor.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.Datagriproveedor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.Datagriproveedor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Datagriproveedor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Datagriproveedor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.Datagriproveedor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.Datagriproveedor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.Datagriproveedor.ThemeStyle.HeaderStyle.Height = 20;
			this.Datagriproveedor.ThemeStyle.ReadOnly = false;
			this.Datagriproveedor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.Datagriproveedor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.Datagriproveedor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.Datagriproveedor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.Datagriproveedor.ThemeStyle.RowsStyle.Height = 22;
			this.Datagriproveedor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.Datagriproveedor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.Datagriproveedor.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Datagriproveedor_CellMouseDown);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 238);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 20);
			this.label2.TabIndex = 34;
			this.label2.Text = "Proveedor";
			// 
			// Txtnombre
			// 
			this.Txtnombre.BackColor = System.Drawing.Color.Transparent;
			this.Txtnombre.BaseColor = System.Drawing.Color.White;
			this.Txtnombre.BorderColor = System.Drawing.Color.Silver;
			this.Txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Txtnombre.FocusedBaseColor = System.Drawing.Color.White;
			this.Txtnombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Txtnombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.Txtnombre.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Txtnombre.Location = new System.Drawing.Point(124, 106);
			this.Txtnombre.Name = "Txtnombre";
			this.Txtnombre.PasswordChar = '\0';
			this.Txtnombre.Radius = 5;
			this.Txtnombre.SelectedText = "";
			this.Txtnombre.Size = new System.Drawing.Size(146, 30);
			this.Txtnombre.TabIndex = 24;
			// 
			// txtdireccion
			// 
			this.txtdireccion.BackColor = System.Drawing.Color.Transparent;
			this.txtdireccion.BaseColor = System.Drawing.Color.White;
			this.txtdireccion.BorderColor = System.Drawing.Color.Silver;
			this.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtdireccion.FocusedBaseColor = System.Drawing.Color.White;
			this.txtdireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtdireccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtdireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtdireccion.Location = new System.Drawing.Point(445, 103);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.PasswordChar = '\0';
			this.txtdireccion.Radius = 5;
			this.txtdireccion.SelectedText = "";
			this.txtdireccion.Size = new System.Drawing.Size(142, 30);
			this.txtdireccion.TabIndex = 25;
			// 
			// txttelefono
			// 
			this.txttelefono.BackColor = System.Drawing.Color.Transparent;
			this.txttelefono.BaseColor = System.Drawing.Color.White;
			this.txttelefono.BorderColor = System.Drawing.Color.Silver;
			this.txttelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttelefono.FocusedBaseColor = System.Drawing.Color.White;
			this.txttelefono.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txttelefono.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txttelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttelefono.Location = new System.Drawing.Point(445, 29);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.PasswordChar = '\0';
			this.txttelefono.Radius = 5;
			this.txttelefono.SelectedText = "";
			this.txttelefono.Size = new System.Drawing.Size(142, 30);
			this.txttelefono.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(54, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 20;
			this.label1.Text = "Nombre";
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
			this.txtbuscar.Location = new System.Drawing.Point(26, 261);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.PasswordChar = '\0';
			this.txtbuscar.Radius = 5;
			this.txtbuscar.SelectedText = "";
			this.txtbuscar.Size = new System.Drawing.Size(122, 30);
			this.txtbuscar.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(355, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 20);
			this.label5.TabIndex = 21;
			this.label5.Text = "Dirección";
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
			this.txtId.Location = new System.Drawing.Point(124, 32);
			this.txtId.Name = "txtId";
			this.txtId.PasswordChar = '\0';
			this.txtId.Radius = 5;
			this.txtId.SelectedText = "";
			this.txtId.Size = new System.Drawing.Size(146, 30);
			this.txtId.TabIndex = 28;
			this.txtId.Visible = false;
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
			this.txtarticulo.Location = new System.Drawing.Point(124, 32);
			this.txtarticulo.Name = "txtarticulo";
			this.txtarticulo.PasswordChar = '\0';
			this.txtarticulo.Radius = 5;
			this.txtarticulo.SelectedText = "";
			this.txtarticulo.Size = new System.Drawing.Size(92, 30);
			this.txtarticulo.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(355, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 20);
			this.label4.TabIndex = 22;
			this.label4.Text = "Télefono";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(48, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 20);
			this.label3.TabIndex = 23;
			this.label3.Text = "Articulo";
			// 
			// btneliminar
			// 
			this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
			this.btneliminar.Location = new System.Drawing.Point(575, 255);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btneliminar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btneliminar.OnHoverForeColor = System.Drawing.Color.White;
			this.btneliminar.OnHoverImage = null;
			this.btneliminar.OnPressedColor = System.Drawing.Color.Black;
			this.btneliminar.Radius = 12;
			this.btneliminar.Size = new System.Drawing.Size(98, 36);
			this.btneliminar.TabIndex = 36;
			this.btneliminar.Text = "Eliminar";
			this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
			// 
			// btnmodificar
			// 
			this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
			this.btnmodificar.Location = new System.Drawing.Point(439, 255);
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnmodificar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnmodificar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnmodificar.OnHoverImage = null;
			this.btnmodificar.OnPressedColor = System.Drawing.Color.Black;
			this.btnmodificar.Radius = 12;
			this.btnmodificar.Size = new System.Drawing.Size(98, 36);
			this.btnmodificar.TabIndex = 37;
			this.btnmodificar.Text = "Modificar";
			this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
			// 
			// btnregistrar
			// 
			this.btnregistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
			this.btnregistrar.Location = new System.Drawing.Point(306, 255);
			this.btnregistrar.Name = "btnregistrar";
			this.btnregistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnregistrar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnregistrar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnregistrar.OnHoverImage = null;
			this.btnregistrar.OnPressedColor = System.Drawing.Color.Black;
			this.btnregistrar.Radius = 12;
			this.btnregistrar.Size = new System.Drawing.Size(98, 36);
			this.btnregistrar.TabIndex = 38;
			this.btnregistrar.Text = "Registrar";
			this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
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
			this.btnbuscar.Location = new System.Drawing.Point(172, 255);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 12;
			this.btnbuscar.Size = new System.Drawing.Size(98, 36);
			this.btnbuscar.TabIndex = 39;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// Volver
			// 
			this.Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Volver.Image = global::Sistemaderopa.Properties.Resources.deshacer;
			this.Volver.Location = new System.Drawing.Point(767, 2);
			this.Volver.Name = "Volver";
			this.Volver.Size = new System.Drawing.Size(31, 28);
			this.Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Volver.TabIndex = 40;
			this.Volver.TabStop = false;
			this.Volver.Click += new System.EventHandler(this.Volver_Click);
			// 
			// FrmProveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Volver);
			this.Controls.Add(this.btneliminar);
			this.Controls.Add(this.btnmodificar);
			this.Controls.Add(this.btnregistrar);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.Datagriproveedor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Txtnombre);
			this.Controls.Add(this.txtdireccion);
			this.Controls.Add(this.txttelefono);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtarticulo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmProveedores";
			this.Text = "Proveedores";
			((System.ComponentModel.ISupportInitialize)(this.Datagriproveedor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Volver)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaDataGridView Datagriproveedor;
		private System.Windows.Forms.Label label2;
		private Guna.UI.WinForms.GunaTextBox Txtnombre;
		private Guna.UI.WinForms.GunaTextBox txtdireccion;
		private Guna.UI.WinForms.GunaTextBox txttelefono;
		private System.Windows.Forms.Label label1;
		private Guna.UI.WinForms.GunaTextBox txtbuscar;
		private System.Windows.Forms.Label label5;
		private Guna.UI.WinForms.GunaTextBox txtId;
		private Guna.UI.WinForms.GunaTextBox txtarticulo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private Guna.UI.WinForms.GunaButton btneliminar;
		private Guna.UI.WinForms.GunaButton btnmodificar;
		private Guna.UI.WinForms.GunaButton btnregistrar;
		private Guna.UI.WinForms.GunaButton btnbuscar;
		private System.Windows.Forms.PictureBox Volver;
	}
}