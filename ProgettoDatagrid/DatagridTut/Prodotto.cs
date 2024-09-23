using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DatagridTut
{
    class Prodotto
    {
        public string Nome { get; set; }
        public int Quantità { get; set; }
        public double Prezzo { get; set; }
        public ImageSource ImageCheckQuantità
        {
            get
            {
                if (Quantità < 0) return new BitmapImage(new Uri("/img/rosso.png", UriKind.Relative));
                else return new BitmapImage(new Uri("/img/verde.png", UriKind.Relative));
            }
        }
        public double PrezzoTotale
        {
            get
            {
                return Quantità * Prezzo;
            }
        }
    }
}
