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
    public partial class CosmeticosDetailsPage : ContentPage
    {
        OpcaoEntrega _OpcaoEntrega;
        public CosmeticosDetailsPage(OpcaoEntrega opcaoEntrega)
        {
            InitializeComponent();
            _OpcaoEntrega = opcaoEntrega;
            this.BindingContext = _OpcaoEntrega;
        }

        
        private async void Btnproximo_Clicked_1(object sender, EventArgs e)
        {
            if (_OpcaoEntrega == null)
                return;
            await this.Navigation.PushModalAsync(new CosmeticosPedidoPage(_OpcaoEntrega));
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new MainPage());
        }
    }
}