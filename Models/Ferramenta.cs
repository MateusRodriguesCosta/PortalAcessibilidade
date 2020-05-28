using System;

namespace PortalAcessibilidade.Models
{
    public class Ferramenta
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Tipo { get; set; }
        public Atividade Atividade { get; set; }
        public String Resumo { get; set; }
        public String Descricao { get; set; }                
        public String Thumbnail { get; set; }
        
    }
}
