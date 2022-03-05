using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficinaProject.model.veicolo
{
    abstract class  Veicolo
    {
        public string marca { get; set; }
        public string modello { get; set; }
        public double cilindrata { get; set; }
        public double km { get; set; }

        public Veicolo(string marca, string modello, double cilindrata, double km)
        {
            this.marca = marca;
            this.modello = modello;
            this.cilindrata = cilindrata;
            this.km = km;
        }

        protected Veicolo()
        {
        }

        override public string ToString()
        {
            return "Veicolo - marca : " + marca + " modello : " + modello + " cilindrata : " + cilindrata + " km : " + km;
        }

        

    }
}
