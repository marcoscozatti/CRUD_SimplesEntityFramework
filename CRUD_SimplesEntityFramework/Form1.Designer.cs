namespace CRUD_SimplesEntityFramework
{
	partial class frmInicial
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnInserir = new System.Windows.Forms.Button();
			this.lblID = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.grid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(30, 124);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(75, 23);
			this.btnInserir.TabIndex = 3;
			this.btnInserir.Text = "Inserir";
			this.btnInserir.UseVisualStyleBackColor = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(27, 24);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(21, 17);
			this.lblID.TabIndex = 1;
			this.lblID.Text = "ID";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(92, 21);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(58, 22);
			this.txtID.TabIndex = 2;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(92, 49);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(326, 22);
			this.txtNome.TabIndex = 1;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(27, 52);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(45, 17);
			this.lblNome.TabIndex = 3;
			this.lblNome.Text = "Nome";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Telefone";
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(111, 124);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 4;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(192, 124);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 5;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// txtTelefone
			// 
			this.txtTelefone.Location = new System.Drawing.Point(92, 80);
			this.txtTelefone.Mask = "(99) 00000-0000";
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(195, 22);
			this.txtTelefone.TabIndex = 2;
			this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// grid
			// 
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Location = new System.Drawing.Point(30, 164);
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersWidth = 51;
			this.grid.RowTemplate.Height = 24;
			this.grid.Size = new System.Drawing.Size(403, 185);
			this.grid.TabIndex = 10;
			// 
			// frmInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 377);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.btnInserir);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInicial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agenda";
			this.Load += new System.EventHandler(this.frmInicial_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnInserir;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
		private System.Windows.Forms.DataGridView grid;
	}
}

