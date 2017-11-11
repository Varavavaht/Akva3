using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Akva3
{

    public class Indikaator
    {
        public string nimi;
        public string väärtus;


        public Indikaator(string _nimi, string _väärtus)
        {
            nimi = _nimi;
            väärtus = _väärtus;
        }
        public void Print()
        {
            Console.Write(nimi + ": ");
            Console.WriteLine(väärtus);
        }
        public void WriteToFile()
        {
            string file = @"C:\csharpfile1.txt";
            StreamWriter kirjutaja = new StreamWriter(file, true);
            //foreach (var Indikaator in nimi + väärtus)

            //{
            kirjutaja.WriteLine(nimi + ": " + väärtus);

            //}
            kirjutaja.Close();
        }
    }
    class Akva
    {
        static void Main(string[] args)
        {
            //StreamWriter teise faili jaoks, kuna ülemist (WriteToFile jaoks tehtud) ei leia enam all olev WriteLine ülesse...
            string file2 = @"C:\csharpfile2.txt";
            StreamWriter kirjutaja2 = new StreamWriter(file2);

            Console.WriteLine("Tere tulemast oma akvaariumi logisse.");
            Console.WriteLine("Milliseid andmeid sa soovid sisestada?");
            Console.WriteLine("1 - üldine - PH, NO2, KH");
            Console.WriteLine("2 - põhjalikum - PH, NO2, NO3, KH, GH, PO4, Fe");
            Console.Write("Tee oma valik - 1 või 2: ");
            DateTime aeg = DateTime.Now;
            string valik = Console.ReadLine();
            if (valik == "1")
            {
                //bool valikud1 = true;
                //while (valikud1)
                {
                    //klassi objektide loomine, nende nime defineerimine ja väärtuse sisestamine.
                    Console.Write("Sisesta PH-väärtus: ");
                    Indikaator PH = new Indikaator("PH-tase", Console.ReadLine());
                    Console.Write("Sisesta NO2 väärtus: ");
                    Indikaator NO2 = new Indikaator("NO2 - vee karedus", Console.ReadLine());
                    Console.Write("Sisesta KH väärtus: ");
                    Indikaator KH = new Indikaator("KH - vee karedus", Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(aeg);
                    PH.Print();
                    NO2.Print();
                    KH.Print();

                    //Faili nr 1 kirjutamine
                    PH.WriteToFile();
                    NO2.WriteToFile();
                    KH.WriteToFile();

                    //faili nr 2 kirjutamine alternatiivsel viisil.
                    using (kirjutaja2)
                    {

                        kirjutaja2.WriteLine(aeg);
                        kirjutaja2.WriteLine(KH);
                        kirjutaja2.WriteLine(PH);
                        kirjutaja2.WriteLine(NO2);
                        //salvestatud failis on kirjas Akva3.Indikaator, mitte väärtused!
                    }
                }

            }
            if (valik == "2")
            {
                //bool valik2 = true;
                //while (valik2)

                Console.Write("Sisesta PH-väärtus: ");
                Indikaator PH = new Indikaator("PH-tase", Console.ReadLine());
                Console.Write("Sisesta NO2 väärtus: ");
                Indikaator NO2 = new Indikaator("NO2 - nitriti tase", Console.ReadLine());
                Console.Write("Sisesta KH väärtus: ");
                Indikaator KH = new Indikaator("KH - vee karedus", Console.ReadLine());
                Console.Write("Sisesta GH-väärtus: ");
                Indikaator GH = new Indikaator("GH - vee karedus", Console.ReadLine());
                Console.Write("Sisesta NO3-väärtus: ");
                Indikaator NO3 = new Indikaator("NO3 - nitraadi tase", Console.ReadLine());
                Console.Write("Sisesta Fe-väärtus: ");
                Indikaator Fe = new Indikaator("Fe - raua tase", Console.ReadLine());
                Console.Write("Sisesta Cu-väärtus: ");
                Indikaator Cu = new Indikaator("Cu - vase tase", Console.ReadLine());
                Console.Write("Sisesta PO4-väärtus: ");
                Indikaator PO4 = new Indikaator("PO4 - fosfori tase", Console.ReadLine());
                Console.Clear();

                Console.WriteLine(aeg);
                PH.Print();
                NO2.Print();
                KH.Print();
                GH.Print();
                NO3.Print();
                Fe.Print();
                Cu.Print();
                PO4.Print();

                PH.WriteToFile();
                NO2.WriteToFile();
                KH.WriteToFile();
                GH.WriteToFile();
                NO3.WriteToFile();
                Fe.WriteToFile();
                Cu.WriteToFile();
                PO4.WriteToFile();

                using (kirjutaja2)
                {

                    kirjutaja2.WriteLine(aeg);
                    kirjutaja2.WriteLine(PO4);
                    kirjutaja2.WriteLine(PH);
                    //salvestatud failis on kirjas Akva3.Indikaator, mitte väärtused!


                }
            }
            Console.ReadLine();
        }
    }
}
