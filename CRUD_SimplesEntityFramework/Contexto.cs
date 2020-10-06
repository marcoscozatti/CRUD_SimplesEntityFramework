using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSimples
{
	public class Contexto : DbContext
	{
		public Contexto() : base("Conexao")	
		{

		}

		public DbSet<Agenda> ObjetoAgenda { get; set; }
	}
}
