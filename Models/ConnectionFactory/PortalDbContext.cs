
using Microsoft.EntityFrameworkCore;
using PortalAcessibilidade.Models;

namespace PortalAcessibilidade
{
    public class PortalDbContext : DbContext
    {
        public DbSet<Atividade> Atividades { get; set; }

        public DbSet<Ferramenta> Ferramentas { get; set; }

        public PortalDbContext(DbContextOptions<PortalDbContext> options) : base(options) {}
    }

}