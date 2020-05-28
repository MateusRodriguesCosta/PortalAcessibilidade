using System.Collections.Generic;
using System.Linq;

namespace PortalAcessibilidade.Models.Dao
{
    public class FerramentaDao
    {

        private PortalDbContext context;

        public FerramentaDao(PortalDbContext context)
        {
            this.context = context;
        }

        public void Adicionar(Ferramenta ferramenta)
        {
            context.Ferramentas.Add(ferramenta);
            context.SaveChanges();
        }

        public void Atualizar(Ferramenta ferramenta)
        {
            context.Ferramentas.Update(ferramenta);
            context.SaveChanges();
        }

        public Ferramenta Procurar(Ferramenta ferramenta)
        {
            return context.Ferramentas.Where(a => a.Equals(ferramenta)).FirstOrDefault<Ferramenta>();
        }

        public Ferramenta Procurar(int? id)
        {
            return context.Ferramentas.Where(a => a.Id.Equals(id)).FirstOrDefault<Ferramenta>();
        }

        public void Remover(Ferramenta ferramenta)
        {
            context.Ferramentas.Remove(ferramenta);
            context.SaveChanges();
        }

        public IList<Ferramenta> Listar()
        {
            return context.Ferramentas.ToList();
        }
       
    }
}
