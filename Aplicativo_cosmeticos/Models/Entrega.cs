using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Aplicativo_cosmeticos.Models
{
    public class Entrega 
    {
        public int EntregaId { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public decimal RetirarLoja { get; set; } 
        public decimal EntregaAgendada { get; }
        public decimal EntregaRapida { get; }
      
    }
}