using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Akva3
{
    //Eelmise programmi kärbitud versioon, et proovida get-set käsklusi.
    public class Indikaator
    {
        public string nimi = "N/A";
        public string väärtus = "N/A";
        //public string kokku = NIMI + ": " + VÄÄRTUS;  - kas niiviisi ei saa, sellisel juhul saaks hiljem kirjutada nt WriteLine (PH.kokku), mitte eraldi välja PH.NIMI + PH.VÄÄRTUS???

        public string NIMI
        {
            get
            {
                return nimi;
            }

            set
            {
                nimi = value;
            }
        }

        public string VÄÄRTUS
        {
            get
            {
                return väärtus;
            }

            set
            {
                väärtus = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string file2 = @"C:\csharpfile5.txt";
            StreamWriter kirjutaja2 = new StreamWriter(file2,true); //true käsklus ütleb, et andmed kirjutada faili lõppu?!
            DateTime aeg = DateTime.Now;
            Console.WriteLine("Tere tulemast oma akvaariumi logisse.");
            Console.WriteLine("Sisesta PH, NO2 ja KH näitajad");
            Console.Write("Alustamiseks vajuta Enter-klahvi");
            Console.ReadLine();
            //klassi objektide loomine, nende nime defineerimine ja väärtuse sisestamine.
            //Visual Studio ütleb Message'i, et Object initialization can be simplified.
            Console.Write("Sisesta PH-väärtus: ");
            Indikaator PH = new Indikaator();
            PH.NIMI = "PH";                             //Set
            PH.VÄÄRTUS = Console.ReadLine();            //Set
            Console.Write("Sisesta NO2 väärtus: ");
            Indikaator NO2 = new Indikaator();
            NO2.NIMI = "NO2";
            NO2.VÄÄRTUS = Console.ReadLine();
            Console.Write("Sisesta KH väärtus: ");
            Indikaator KH = new Indikaator();
            KH.NIMI = "KH";
            KH.VÄÄRTUS = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(aeg);
            Console.WriteLine(PH.NIMI + ": " + PH.VÄÄRTUS); //Get
            Console.WriteLine(NO2.NIMI + ": " + NO2.VÄÄRTUS);
            Console.WriteLine(KH.NIMI + ": " + KH.VÄÄRTUS);


            using (kirjutaja2)
            {

                kirjutaja2.WriteLine(aeg);
                kirjutaja2.WriteLine(PH.NIMI + ": " + PH.VÄÄRTUS);
                kirjutaja2.WriteLine(KH.NIMI + ": " + KH.VÄÄRTUS);
                kirjutaja2.WriteLine(NO2.NIMI + ": " + NO2.VÄÄRTUS);
            }
            Console.ReadLine();
        }
    }
}
