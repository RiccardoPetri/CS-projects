using System;
using OfficinaProject.model.veicolo;
using OfficinaProject.model.veicolo.camion;
using OfficinaProject.model.veicolo.camion.util;
using OfficinaProject.model.veicolo.macchina;
using OfficinaProject.model.veicolo.motorino;
using OfficinaProject.model.veicolo.motorino.util;

namespace OfficinaProject
{
    class Tester
    {
        static void Main(string[] args)
        {
            var o = new Officina("OfficinaName", 10);
            o.AggiungiVeicolo(new Motorino("marca1","modello0", 250, 10, new Casco(20, ColoreCasco.Nero)));
            o.RimuoviVeicolo(o.VeicoliList.Find(x => x.marca == "marca1"));

            Console.WriteLine(o.ToString());    // this will output null!!!!

            o.AggiungiVeicolo(new Macchina("marca2", "modello2", 256, 11));
            o.AggiungiVeicolo(new Macchina("marca3", "modello4", 301, 16));
            o.AggiungiVeicolo(new Camion("marca4", "modello5", 351, 13, new Telepass("AV22", TipoTelepass.Annuale)));
            o.AggiungiVeicolo(new Motorino("marca1", "modello0", 255, 11, new Casco(20, ColoreCasco.Bianco)));

            Console.WriteLine(o.ToString());

            ((Motorino)(o.VeicoliList.Find(x => x.marca == "marca1"))).casco.changeColor();
            

            //comparing by km and if the km are equal, comparing the cilindrata
            o.VeicoliList.Sort(new VeicoliComparator());
            Console.WriteLine(o.ToString());

            
            

        }
    }

    
}
