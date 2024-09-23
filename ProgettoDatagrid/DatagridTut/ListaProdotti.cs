using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatagridTut
{
    class ListaProdotti
    {
        public List<Prodotto> elencoProdotti { get; set; }

        public ListaProdotti()
        {
            elencoProdotti = new List<Prodotto>();

            Prodotto p = new Prodotto();
            p.Nome = "The";
            p.Quantità = 4;
            p.Prezzo = 5;
            elencoProdotti.Add(p);
            p = new Prodotto();
            p.Nome = "Fragola";
            p.Quantità = 1;
            p.Prezzo = 6;
            elencoProdotti.Add(p);
            p = new Prodotto();
            p.Nome = "Avocado";
            p.Quantità = 2;
            p.Prezzo = 3;
            elencoProdotti.Add(p);
        }
    }
}
