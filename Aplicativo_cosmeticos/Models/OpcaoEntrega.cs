using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace Aplicativo_cosmeticos.Models
{
    public class OpcaoEntrega : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public decimal Preco { get; set; }

        public string ImagemUrl { get; set; }

        private const decimal RETIRAR_LOJA = 0.00M;
        private const decimal ENTREGA_AGENDADA = 7.00M;
        private const decimal ENTREGA_RAPIDA = 5.00M;
      
        public string TextoRetirarLoja
        {
            get { return string.Format("Retirar na Loja - R$ {0}", RETIRAR_LOJA); }
        }

        public string TextoEntregaAgendada
        {
            get { return string.Format("Entrega Agendada - R$ {0}", ENTREGA_AGENDADA); }
        }

        public string TextoEntregaRapida
        {
            get { return string.Format("Entrega Rápida - R$ {0}", ENTREGA_RAPIDA); }
        }

        
        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: R$ {0}", Preco
                + (RetirarLoja ? RETIRAR_LOJA : 0) 
                + (EntregaAgendada ? ENTREGA_AGENDADA : 0)
                + (EntregaRapida ? ENTREGA_RAPIDA : 0));
            }
        }

        private bool retirarLoja;
        public bool RetirarLoja
        {
            get { return retirarLoja; }
            set
            {
                retirarLoja = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

        private bool entregaAgendada;
        public bool EntregaAgendada
        {
            get { return entregaAgendada; }
            set
            {
                entregaAgendada = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

        private bool entregaRapida;
        public bool EntregaRapida
        {
            get { return entregaRapida; }
            set
            {
                entregaRapida = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

       
    }
}