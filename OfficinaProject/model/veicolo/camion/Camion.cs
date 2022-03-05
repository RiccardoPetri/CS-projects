using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficinaProject.model.veicolo.camion
{
    class Camion: Veicolo
    {
       

        public Telepass telepass { get; set; }

        public Camion(string marca, string modello, double cilindrata, double km, Telepass telepass) : base(marca, modello, cilindrata, km)
        {
            this.telepass = telepass;
        }


        public override string ToString()
        {
            return "Veicolo: Camion -> " + base.ToString() + " telepass -> " + telepass;

        }
    }
}
