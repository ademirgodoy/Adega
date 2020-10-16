using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite;

namespace Adega
{
    class Vinho
    {
        
        [PrimaryKey, AutoIncrement]
        public uint Id { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Tipo { get; set; }
        public string Uva { get; set; }
        public string DataProva { get; set; }
        public string Comentario { get; set; }
        //public Image Foto { get; set; }


    }
}
