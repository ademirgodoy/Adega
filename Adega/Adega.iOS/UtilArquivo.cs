using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using System.IO;

namespace Adega.iOS
{
    class UtilArquivo: IUtilArquivo
    {
        public String GetDiretorioLocalArquivo(String nomeArquivo)
        {
            String diretorio = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String diretorioLib = Path.Combine(diretorio, "..", "Library", "Databases");
            if (!Directory.Exists(diretorioLib))
            {
                Directory.CreateDirectory(diretorioLib);
            }

            return Path.Combine(diretorioLib, nomeArquivo);
        }
    }
}