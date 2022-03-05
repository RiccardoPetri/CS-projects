using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficinaProject.model.veicolo.motorino
{
    class Motorino : Veicolo, IRevisionabile
    {
        public Casco casco { get; set; }

        public Motorino(string marca, string modello, double cilindrata, double km, Casco casco) : base(marca, modello, cilindrata, km)
        {
            this.casco = casco;
        }

        

        public string Revisione(string marca, string modello, double cilindrata, double km)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Veicolo: Motorino -> " + base.ToString() +" "+ casco.ToString();
        }
    }
}
