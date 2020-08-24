using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;

namespace WindowsFormsEnumHelyes
{
    public partial class Form1 : Form
    {
        List<Bedrijf> bedrijList = new List<Bedrijf>();
        List<Werknemers> werkNemersList = new List<Werknemers>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Werknemers geert = new Werknemers("Geert",new Salarys(typeSalary: Salarys.SalaryType.Week));
            Werknemers frank = new Werknemers("Frank",new Salarys(bruttoBedrag:2200));
            Werknemers daniel = new Werknemers("Daniel",new Salarys(typeSalary: Salarys.SalaryType.Week),Werknemers.Land.Nederland);
            Werknemers sofia = new Werknemers("Sofia",new Salarys(bruttoBedrag:3110),Werknemers.Land.Nederland);
            werkNemersList.Add(geert);
            werkNemersList.Add(frank);
            werkNemersList.Add(daniel);
            werkNemersList.Add(sofia);
            //Werknemers werknem1 = new Werknemers("Antal");
            //Werknemers werknem2 = new Werknemers("Klaudia");
            //Werknemers werknem3 = new Werknemers("Johnny");
            //Werknemers werknem4 = new Werknemers("Gregory");
            //Werknemers werknem5 = new Werknemers("Patricia");
            //Werknemers werknem6 = new Werknemers("Adam");
            //Werknemers werknem7 = new Werknemers("Joshep");
            //Werknemers werknem8 = new Werknemers("Raul");
            //Werknemers werknem9 = new Werknemers("Piroska");
            cmbNaam.DataSource = null;
            cmbNaam.DataSource = werkNemersList;

            //Bedrijf Antalnv = new Bedrijf("Antal Nv.", BtwNummerRandom());
            //Antalnv.
        }
        public string BtwNummerRandom()
        {
            Random rng = new Random();
            string rekeningnr = "BE";
            for (int i = 1; i <= 3; i++)
            {
                int randomnr = rng.Next(999);
                rekeningnr += " " + randomnr.ToString().PadLeft(3, '0');
            }
            return rekeningnr;

        }

        private void cmbNaam_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cmbNaam.DataSource != null)
            {
                
                labelNaamInfo.Text = (cmbNaam.SelectedItem as Werknemers).Beschrijft();
                lblNettoBrutto.Text = (cmbNaam.SelectedItem as Werknemers).Salarys.Money();
            }
        }
    }
}
