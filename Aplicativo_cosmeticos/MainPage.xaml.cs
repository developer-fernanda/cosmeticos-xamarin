using Aplicativo_cosmeticos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aplicativo_cosmeticos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lvProdutos.ItemsSource = new List<OpcaoEntrega>
                {
            new OpcaoEntrega { Nome="Florata Blue", Descricao="Desodorante Colônia 75ml", Status="Ativo",
                Preco=104.90M, ImagemUrl="FlorataBlue.png" },

            new OpcaoEntrega { Nome="Florata Rose", Descricao="Desodorante Colônia 75ml", Status="Ativo",
                Preco=104.90M, ImagemUrl="FlorataRose.png" },

            new OpcaoEntrega { Nome="Florata Simples Love", Descricao="Desodorante Colônia 75ml", Status="Ativo",
                Preco=109.90M, ImagemUrl="FlorataSimpleLove.png" },

            new OpcaoEntrega { Nome="Florata Red", Descricao="Desodorante Colônia 75ml", Status="Ativo",
                Preco=109.90M, ImagemUrl="FlorataRed.png" },

            new OpcaoEntrega { Nome="Linda", Descricao="Desodorante Colônia 100ml", Status="Ativo",
                Preco=136.90M, ImagemUrl="Linda.png" },

              new OpcaoEntrega { Nome="Linda Felicidade", Descricao="Desodorante Colônia 100ml", Status="Ativo",
                Preco=136.90M ,ImagemUrl="LindaFelicidade.png" },

            new OpcaoEntrega { Nome="Coffee Paradiso", Descricao="Desodorante Colônia 100ml", Status="Ativo",
                Preco=114.90M, ImagemUrl="CoffeeParadiso.png" },

            new OpcaoEntrega { Nome="Egeo Dolce", Descricao="Desodorante Colônia 90ml", Status="Ativo",
                Preco=119.90M ,ImagemUrl="EgeoDolce.png" },

            new OpcaoEntrega { Nome="Egeo Choc", Descricao="Desodorante Colônia 90ml", Status="Ativo",
                Preco=119.90M, ImagemUrl="EgeoChoc.png" },

            new OpcaoEntrega { Nome="Cuide-se Bem ", Descricao="Hidratante Deleite 400ml", Status="Ativo",
                Preco=49.90M, ImagemUrl="CuideDeleite.png" },

            new OpcaoEntrega { Nome="Cuide-se Bem ", Descricao="Hidratante Nuvem 200ml", Status="Ativo",
                Preco=36.90M, ImagemUrl="CuideNuvem.png" },

            };
        }

        // Utilizando PushModalAsync
        private async void lvProdutos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var opcaoEntrega = e.SelectedItem as OpcaoEntrega;
            if (opcaoEntrega == null)
                return;
            await this.Navigation.PushModalAsync(new CosmeticosDetailsPage(opcaoEntrega));
        }

    }
}
