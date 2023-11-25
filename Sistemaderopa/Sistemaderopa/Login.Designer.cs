namespace Sistemaderopa
{
	partial class FrmLogin
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.cerrar = new Guna.UI.WinForms.GunaCirclePictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtcorreo = new Guna.UI.WinForms.GunaTextBox();
			this.Txtclave = new Guna.UI.WinForms.GunaTextBox();
			this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
			this.btnentrar = new Guna.UI.WinForms.GunaButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.cerrar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(544, 38);
			this.panel1.TabIndex = 1;
			// 
			// cerrar
			// 
			this.cerrar.BaseColor = System.Drawing.Color.White;
			this.cerrar.Image = global::Sistemaderopa.Properties.Resources.emblemunreadable_93487;
			this.cerrar.Location = new System.Drawing.Point(505, 4);
			this.cerrar.Name = "cerrar";
			this.cerrar.Size = new System.Drawing.Size(34, 30);
			this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.cerrar.TabIndex = 5;
			this.cerrar.TabStop = false;
			this.cerrar.UseTransfarantBackground = false;
			this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(76, 225);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cuenta";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(41, 280);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Contraseña";
			// 
			// txtcorreo
			// 
			this.txtcorreo.BackColor = System.Drawing.Color.Transparent;
			this.txtcorreo.BaseColor = System.Drawing.Color.White;
			this.txtcorreo.BorderColor = System.Drawing.Color.Silver;
			this.txtcorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtcorreo.FocusedBaseColor = System.Drawing.Color.White;
			this.txtcorreo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtcorreo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtcorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtcorreo.Location = new System.Drawing.Point(187, 215);
			this.txtcorreo.Name = "txtcorreo";
			this.txtcorreo.PasswordChar = '\0';
			this.txtcorreo.Radius = 5;
			this.txtcorreo.SelectedText = "";
			this.txtcorreo.Size = new System.Drawing.Size(160, 30);
			this.txtcorreo.TabIndex = 3;
			// 
			// Txtclave
			// 
			this.Txtclave.BackColor = System.Drawing.Color.Transparent;
			this.Txtclave.BaseColor = System.Drawing.Color.White;
			this.Txtclave.BorderColor = System.Drawing.Color.Silver;
			this.Txtclave.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Txtclave.FocusedBaseColor = System.Drawing.Color.White;
			this.Txtclave.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Txtclave.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.Txtclave.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Txtclave.Location = new System.Drawing.Point(187, 270);
			this.Txtclave.Name = "Txtclave";
			this.Txtclave.PasswordChar = '*';
			this.Txtclave.Radius = 5;
			this.Txtclave.SelectedText = "";
			this.Txtclave.Size = new System.Drawing.Size(160, 30);
			this.Txtclave.TabIndex = 3;
			// 
			// gunaCirclePictureBox1
			// 
			this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
			this.gunaCirclePictureBox1.Image = global::Sistemaderopa.Properties.Resources.grupo;
			this.gunaCirclePictureBox1.Location = new System.Drawing.Point(195, 59);
			this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
			this.gunaCirclePictureBox1.Size = new System.Drawing.Size(143, 150);
			this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.gunaCirclePictureBox1.TabIndex = 5;
			this.gunaCirclePictureBox1.TabStop = false;
			this.gunaCirclePictureBox1.UseTransfarantBackground = false;
			// 
			// btnentrar
			// 
			this.btnentrar.AnimationHoverSpeed = 0.07F;
			this.btnentrar.AnimationSpeed = 0.03F;
			this.btnentrar.BackColor = System.Drawing.Color.Transparent;
			this.btnentrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnentrar.BorderColor = System.Drawing.Color.Black;
			this.btnentrar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnentrar.FocusedColor = System.Drawing.Color.Empty;
			this.btnentrar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnentrar.ForeColor = System.Drawing.Color.White;
			this.btnentrar.Image = global::Sistemaderopa.Properties.Resources.iniciar_sesion;
			this.btnentrar.ImageSize = new System.Drawing.Size(20, 20);
			this.btnentrar.Location = new System.Drawing.Point(219, 324);
			this.btnentrar.Name = "btnentrar";
			this.btnentrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnentrar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnentrar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnentrar.OnHoverImage = null;
			this.btnentrar.OnPressedColor = System.Drawing.Color.Black;
			this.btnentrar.Radius = 12;
			this.btnentrar.Size = new System.Drawing.Size(98, 36);
			this.btnentrar.TabIndex = 4;
			this.btnentrar.Text = "Entrar";
			this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 450);
			this.Controls.Add(this.gunaCirclePictureBox1);
			this.Controls.Add(this.btnentrar);
			this.Controls.Add(this.Txtclave);
			this.Controls.Add(this.txtcorreo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmLogin";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaButton btnentrar;
		private Guna.UI.WinForms.GunaTextBox Txtclave;
		private Guna.UI.WinForms.GunaTextBox txtcorreo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
		private Guna.UI.WinForms.GunaCirclePictureBox cerrar;
	}
}