using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Adega
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DadosVinho : ContentPage
    {
        public DadosVinho()
        {
            InitializeComponent();
        }

        private void BtnSalvarVinho(object sender, EventArgs e)
        {
            Vinho v = BindingContext as Vinho;
            App.Database.SaveItemAsync(v);
            Navigation.PopAsync();
        }

        private void BtnApagarVinho(object sender, EventArgs e)
        {
            Vinho v = BindingContext as Vinho;
            App.Database.DeleteItemAsync(v);
            Navigation.PopAsync();
        }

       

    }
}