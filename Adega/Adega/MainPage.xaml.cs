using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Adega
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            lstVinhos.ItemsSource = await App.Database.GetItemsAsync();
        }

        private void BtnAdiconar(object sender, EventArgs args)
        {
            Navigation.PushAsync(new DadosVinho()
            {
                BindingContext = new Vinho()
            });
        }

        private void BtnSair(object sender, EventArgs args)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void ItemSelecionado (object sender, SelectedItemChangedEventArgs args)
        {
            if (args != null)
            {
                Navigation.PushAsync(new DadosVinho()
                {
                    BindingContext = args.SelectedItem as Vinho

                });
            }
        }

    }
}
