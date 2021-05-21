using Aplicativo_cosmeticos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicativo_cosmeticos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CosmeticosPedidoConfirmacao : ContentPage
    {
        public CosmeticosPedidoConfirmacao(OpcaoEntrega opcaoEntrega)
        {
            InitializeComponent();
            this.BindingContext = opcaoEntrega;
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new MainPage());
        }
    }
}