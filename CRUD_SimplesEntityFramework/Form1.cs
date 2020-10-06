using CadastroSimples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CRUD_SimplesEntityFramework
{
	public partial class frmInicial : Form
	{
		public frmInicial()
		{
			InitializeComponent();
		}

		private void btnInserir_Click(object sender, EventArgs e)
		{
			using (var tb = new Contexto())
			{
				tb.ObjetoAgenda.Add(new Agenda { nome = txtNome.Text, telefone = txtTelefone.Text });
				tb.SaveChanges();
			}
			AtualizaGrid();
			txtNome.Clear();
			txtTelefone.Clear();
			MessageBox.Show("Incluido com sucesso", "Inclusão");

		}
		public void AtualizaGrid()
		{
			using (var tb = new Contexto())
			{
				grid.DataSource = null;
				grid.DataSource = tb.ObjetoAgenda.ToList();
			}
		}

		private void frmInicial_Load(object sender, EventArgs e)
		{
			AtualizaGrid();
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			using (var tb = new Contexto())
			{
				var objeto = tb.ObjetoAgenda.Find(Convert.ToInt32(txtID.Text));
				objeto.nome = txtNome.Text;
				objeto.telefone = txtTelefone.Text;
				tb.Entry(objeto).State = EntityState.Modified;
				tb.SaveChanges();
				MessageBox.Show("Alteração realizada com sucesso", "Alteração");
				AtualizaGrid();

			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			using (var tb = new Contexto())
			{
				var objeto = tb.ObjetoAgenda.Find(Convert.ToInt32(txtID.Text));
				tb.ObjetoAgenda.Remove(objeto);
				tb.SaveChanges();
				MessageBox.Show("Exlcuido com sucesso", "Exclusão");
				AtualizaGrid();
			}
		}
	}

}
