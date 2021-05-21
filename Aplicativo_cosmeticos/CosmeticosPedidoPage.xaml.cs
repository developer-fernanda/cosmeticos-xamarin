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
    public partial class CosmeticosPedidoPage : ContentPage
    {
        OpcaoEntrega _OpcaoEntrega;
        Usuario _usuario;
        public CosmeticosPedidoPage(OpcaoEntrega opcaoEntrega)
        {
            InitializeComponent();
            this._OpcaoEntrega = opcaoEntrega;
            this.BindingContext = _OpcaoEntrega;
        }

        private async void BtnPedido_Clicked(object sender, EventArgs e)
        {
            if (_OpcaoEntrega == null)
                return;

            if (string.IsNullOrEmpty(strNome.Text))
                return;

            if (string.IsNullOrEmpty(strFone.Text))
                return;

            if (string.IsNullOrEmpty(strEmail.Text))
                return;

            _usuario = new Usuario();
            _usuario.Nome = strNome.Text;
            _usuario.Telefone = strFone.Text;
            _usuario.Email = strEmail.Text;

            await this.Navigation.PushModalAsync(new CosmeticosPedidoConfirmacao(_OpcaoEntrega));
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new CosmeticosDetailsPage(_OpcaoEntrega));
        }
    }
}