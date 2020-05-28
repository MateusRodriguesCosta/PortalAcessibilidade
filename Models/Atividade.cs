using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PortalAcessibilidade.Models
{
    public class Atividade
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Tipo { get; set; }
        public String Area { get; set; }
        public String Resumo { get; set; }
        public String Descricao { get; set; }
        public String Sintomas { get; set; }
        public String Diagnostico { get; set; }
        public String Thumbnail { get; set; }
        public List<Ferramenta> Ferramentas { get; set; }
        public int IdadeInicial { get; set; }
        public int IdadeFinal { get; set; }
    }
}
