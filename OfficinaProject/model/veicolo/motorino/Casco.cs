using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficinaProject.model.veicolo.motorino.util;

namespace OfficinaProject.model.veicolo.motorino
{
    class Casco
    {
        public double Size { get; set; }
        public ColoreCasco Colore { get; set; }

        public Casco(double size, ColoreCasco colore)
        {
            this.Size = size;
            this.Colore = colore;
        }

        public bool changeColor()
        {
            if(Colore.Equals(ColoreCasco.Bianco) || Colore.Equals(ColoreCasco.Giallo)) {
                Console.WriteLine("Colore casco troppo chiaro, tieni il casco blu");
                Colore = ColoreCasco.Blu;
                return false;
            } else

                Console.WriteLine("Colore casco consentito!");
            return true;
        }
    

        public override string ToString()
        {
            return "Casco : size -> " + Size + " colore -> " + Colore;
        }
    }   
}
