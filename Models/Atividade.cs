using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAcessibilidade.Models
{
    public class Atividade
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public String Tipo { get; set; }
        public String Area { get; set; }
        public int IdadeInicial { get; set; }
        public int IdadeFinal { get; set; }
}
}
