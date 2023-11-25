namespace Sistemaderopa
{
	partial class FrmInventario
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
			this.datagriinvetario = new Guna.UI.WinForms.GunaDataGridView();
			this.txtbuscar = new Guna.UI.WinForms.GunaTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnbuscar = new Guna.UI.WinForms.GunaButton();
			this.Volver = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.datagriinvetario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Volver)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// datagriinvetario
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.datagriinvetario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.datagriinvetario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datagriinvetario.BackgroundColor = System.Drawing.Color.White;
			this.datagriinvetario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.datagriinvetario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagriinvetario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagriinvetario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.datagriinvetario.ColumnHeadersHeight = 20;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagriinvetario.DefaultCellStyle = dataGridViewCellStyle3;
			this.datagriinvetario.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.datagriinvetario.EnableHeadersVisualStyles = false;
			this.datagriinvetario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriinvetario.Location = new System.Drawing.Point(0, 111);
			this.datagriinvetario.Name = "datagriinvetario";
			this.datagriinvetario.RowHeadersVisible = false;
			this.datagriinvetario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagriinvetario.Size = new System.Drawing.Size(800, 339);
			this.datagriinvetario.TabIndex = 0;
			this.datagriinvetario.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.datagriinvetario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.datagriinvetario.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.datagriinvetario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.datagriinvetario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.datagriinvetario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.datagriinvetario.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.datagriinvetario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriinvetario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datagriinvetario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.datagriinvetario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagriinvetario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.datagriinvetario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.datagriinvetario.ThemeStyle.HeaderStyle.Height = 20;
			this.datagriinvetario.ThemeStyle.ReadOnly = false;
			this.datagriinvetario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.datagriinvetario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagriinvetario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.datagriinvetario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.datagriinvetario.ThemeStyle.RowsStyle.Height = 22;
			this.datagriinvetario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagriinvetario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
			this.txtbuscar.Location = new System.Drawing.Point(96, 75);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.PasswordChar = '\0';
			this.txtbuscar.Radius = 5;
			this.txtbuscar.SelectedText = "";
			this.txtbuscar.Size = new System.Drawing.Size(160, 30);
			this.txtbuscar.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Buscar";
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
			this.btnbuscar.Location = new System.Drawing.Point(278, 70);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 12;
			this.btnbuscar.Size = new System.Drawing.Size(87, 36);
			this.btnbuscar.TabIndex = 19;
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
			this.Volver.TabIndex = 21;
			this.Volver.TabStop = false;
			this.Volver.Click += new System.EventHandler(this.Volver_Click);
			// 
			// FrmInventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Volver);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.datagriinvetario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmInventario";
			this.Text = "Inventario";
			((System.ComponentModel.ISupportInitialize)(this.datagriinvetario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Volver)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaDataGridView datagriinvetario;
		private Guna.UI.WinForms.GunaTextBox txtbuscar;
		private System.Windows.Forms.Label label1;
		private Guna.UI.WinForms.GunaButton btnbuscar;
		private System.Windows.Forms.PictureBox Volver;
	}
}