using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Při zadání validních hodnot a správnému provedení akce se pole formuláře vymažou
// Přidání tlačítka pro resetování aplikace smožností určit velikost parkovišt
namespace Parkoviště
{
    public partial class Form1 : Form
    {
        Parkoviste P = new Parkoviste(3);
        int velikostParkoviste = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Zaparkuj_Click(object sender, EventArgs e)
        {
            
            
            var vuzA = new Vozidlo("2B45896");
            var vuzB = new Vozidlo("6H01212");
           
            //zaparkujeme jedno auto
            P.Zaparkuj(vuzA, 0);
            P.Zaparkuj(vuzB, 1);
            this.Debug_OutPut_Write(P.VypisVozidel());
        }

        private void Debug_OutPut_Click(object sender, EventArgs e)
        {

        }
        public void Debug_OutPut_Write(string s)
        {
            this.Debug_OutPut.Text = s;
        }

        private void Vyparkuj_Click(object sender, EventArgs e)
        {
           var vuzC = new Vozidlo("8A96428");
            P.Vyparkuj(0);
            P.Vyparkuj(1);
            P.Zaparkuj(vuzC);
            
            this.Debug_OutPut_Write(P.VypisVozidel());


            if (P.Vyparkuj(vuzC))
            {
                this.Debug_OutPut_Write("Vyparkování vozidla vuzC bylo USPESNE!");
            }
            else
            {
                this.Debug_OutPut_Write("Vyparkování vozidla vuzC bylo NEUSPESNE!");
            }
            //Vyzkoušet funkčnost na parkovišiti o velikosti 5 se třemi vozy (můžeme použit již vytvořená zfáze 1.)
        }

        private void Velikost_Parkoviste_TextChanged(object sender, EventArgs e)
        {
            // TODO: pridat try/catch blok
            int i = 0;
            bool success = int.TryParse(this.Velikost_Parkoviste.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out i);
            if (success)
            {
                this.velikostParkoviste = i;
            }
        }

        private void Reset_Parkoviste_Click(object sender, EventArgs e)
        {
            if (this.velikostParkoviste > 0) { 
                this.P = new Parkoviste(this.velikostParkoviste);
                this.Debug_OutPut_Write("Vytvoreno nove parkoviste o velikosti " + this.velikostParkoviste.ToString());
                this.Velikost_Parkoviste.Text = "";
            }
            else
            {
                this.Debug_OutPut_Write("Zadejte velikost parkoviste vetsi nez 0");
            }
        }
    }
    
}
