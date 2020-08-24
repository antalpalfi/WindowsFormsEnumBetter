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
using System.Threading;

namespace WindowsFormsEnumHelyes
{
    public partial class Form1 : Form
    {
        List<Bedrijf> bedrijfList = new List<Bedrijf>();
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
            Werknemers werknem1 = new Werknemers("Antal",new Salarys());
            Werknemers werknem2 = new Werknemers("Klaudia",new Salarys());
            Werknemers werknem3 = new Werknemers("Johnny",new Salarys());
            Werknemers werknem4 = new Werknemers("Gregory",new Salarys());
            Werknemers werknem5 = new Werknemers("Patricia", new Salarys());
            Werknemers werknem6 = new Werknemers("Adam", new Salarys());
            Werknemers werknem7 = new Werknemers("Joshep", new Salarys());
           
            //cmbNaam.DataSource = null;
            //cmbNaam.DataSource = werkNemersList;

            Bedrijf Antalnv = new Bedrijf("Antal Nv.", BtwNummerRandom());
            Thread.Sleep(50);
            Bedrijf PalfiAuto = new Bedrijf("Palfi Auto Bt.", BtwNummerRandom());
            Thread.Sleep(50);
            Bedrijf Szabo = new Bedrijf("Szabo Kft.", BtwNummerRandom());
            bedrijfList.Add(Antalnv);
            bedrijfList.Add(PalfiAuto);
            bedrijfList.Add(Szabo);


            Antalnv.WerkNemersAdd(werknem1);
            Antalnv.WerkNemersAdd(werknem2);
            Antalnv.WerkNemersAdd(werknem3);
            PalfiAuto.WerkNemersAdd(werknem4);
            PalfiAuto.WerkNemersAdd(werknem5);
            PalfiAuto.WerkNemersAdd(werknem6);
            Szabo.WerkNemersAdd(new Werknemers("Tamas", new Salarys()));
            Szabo.WerkNemersAdd(werknem7);
            Szabo.WerkNemersAdd(new Werknemers("Piroska", new Salarys()));
            cmbBedrijf.DataSource = bedrijfList;

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

        private void cmbBedrijf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBedrijf.DataSource!=null)
            {

                cmbNaam.DataSource = (cmbBedrijf.SelectedValue as Bedrijf).werkNemList;
                cmbBedrijf.DataSource = bedrijfList;
                labelBedrijf.Text = (cmbNaam.SelectedItem as Bedrijf).BedInfo();
            }
        }
    }
}
