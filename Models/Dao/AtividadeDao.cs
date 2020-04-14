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
            return context.Atividades.Where(a => a.Equals(atividade)).FirstOrDefault<Atividade>();
        }

        public void Remover(Atividade atividade)
        {
            context.Atividades.Remove(atividade);
            context.SaveChanges();
        }

        public IList<Atividade> Listar(Atividade atividade)
        {
            return context.Atividades.Where(a => a.Equals(atividade)).ToList();
        }
       
    }
}
