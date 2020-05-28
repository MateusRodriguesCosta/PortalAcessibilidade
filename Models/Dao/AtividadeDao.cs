using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace PortalAcessibilidade.Models.Dao
{
    public class AtividadeDao
    {

        private PortalDbContext context;

        public AtividadeDao(PortalDbContext context)
        {
            this.context = context;
        }

        public void Adicionar(Atividade atividade)
        {
            context.Atividades.Add(atividade);
            context.SaveChanges();
        }

        public void Atualizar(Atividade atividade)
        {
            context.Atividades.Update(atividade);
            context.SaveChanges();
        }

        public Atividade Procurar(Atividade atividade)
        {
            return context.Atividades.Where(a => a.Equals(atividade)).Include(a => a.Ferramentas).FirstOrDefault<Atividade>();
        }

        public Atividade Procurar(int? id)
        {
            return context.Atividades.Where(a => a.Id.Equals(id)).Include(a => a.Ferramentas).FirstOrDefault<Atividade>();
        }

        public void Remover(Atividade atividade)
        {
            context.Atividades.Remove(atividade);
            context.SaveChanges();
        }

        public IList<Atividade> Listar()
        {
            return context.Atividades.Include(a => a.Ferramentas).ToList();
        }
       
    }
}
