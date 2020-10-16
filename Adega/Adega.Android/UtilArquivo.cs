using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using System.IO;
using Adega.Droid;

[assembly: Dependency(typeof(UtilArquivo))]
namespace Adega.Droid
{
    class UtilArquivo: IUtilArquivo
    {
       public String GetDiretorioLocalArquivo(String nomeArquivo)
        {
            String diretorio = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(diretorio, nomeArquivo);
        }
    }
}
