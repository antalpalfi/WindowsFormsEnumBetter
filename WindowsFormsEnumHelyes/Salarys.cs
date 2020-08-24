using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEnumHelyes
{
    public class Salarys
    {
        public enum SalaryType
        {
            Week,Maand
        }
        public SalaryType Cont;
        public double BruttoBedrag;
        public int Percent;
        

        public Salarys(double bruttoBedrag = 2440.55, SalaryType typeSalary = SalaryType.Maand, int percent =21)
        {
            this.Cont = typeSalary;
            this.BruttoBedrag = bruttoBedrag;
            this.Percent = percent;
        }
      
        public double BerekenNetto()
        {
            double netto = BruttoBedrag - (BruttoBedrag/100*Percent);
            return Math.Round(netto, 2);
        }

        public virtual  string Money()
        {
            return
                $"Brutto: {BruttoBedrag} euro\n" +
                $"Netto:  {BerekenNetto()} euro\n" +
                $"Btw: {Percent}%";
        }
    }
}
