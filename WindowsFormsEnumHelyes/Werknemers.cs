using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEnumHelyes
{
     public class Werknemers
    {
        public string Naam { get; set; }
        public Salarys Salarys = new Salarys();
        
       public enum Land
        {
            Belgie, Nederland, Frans, Luxemburg
        }
        public Land KomLand;

        public Werknemers(string naam,Salarys salarys, Land komLand = Land.Belgie)
        {

            this.Naam = naam;
            this.KomLand = komLand;
            this.Salarys = salarys;
        }
        public Werknemers()
        {
        }
        public virtual string Beschrijft()
        {
            return $"Naam: {Naam}\n" +
                $"Komt uit: {KomLand}\n";
               
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
