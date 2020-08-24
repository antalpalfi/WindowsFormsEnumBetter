using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEnumHelyes
{
    public class Bedrijf
    {
        public string BedNaam { get; set; }
        public string BtwNum { get; set; }
        public List<Werknemers> werkNemList = new List<Werknemers>();
        public Bedrijf (string naam , string btwNumm)
        {
            this.BedNaam = naam;
            this.BtwNum = btwNumm;
            werkNemList = new List<Werknemers>();
        }
        public override string ToString()
        {
            return BedNaam;
        }
    }
}
