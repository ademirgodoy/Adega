using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Adega
{
    public partial class App : Application
    {
        private static VinhoItem bancoDados;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
        }

        internal static VinhoItem Database
        {
            get
            {
                if (bancoDados == null)
                {
                    bancoDados = new VinhoItem(DependencyService.Get<IUtilArquivo>().GetDiretorioLocalArquivo("AdegaSQLite.db3"));
                }

                return bancoDados;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
