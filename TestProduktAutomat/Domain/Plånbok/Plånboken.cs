using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TestProduktAutomat.UI;

namespace TestProduktAutomat.Domain.Plånbok
{
    internal class Plånboken
    {
        public int EnKrona { get; set; }
        public int FemKrona { get; set; }
        public int TioKrona { get; set; }
        public int TjugeLap { get; set; }
        public int FemtioLap { get; set; }
        public int HundraLap { get; set; }
        public static int summa { get; set; } = 0;

        public static List<int> enkrona = new List<int>();
        public static List<int> femkrona = new List<int>();
        public static List<int> tiokrona = new List<int>();
        public static List<int> tjugolapp = new List<int>();
        public static List<int> femtiolapp = new List<int>();
        public static List<int> hundralapp = new List<int>();


        public Plånboken(int enKrona, int femKrona, int tioKrona, int tjugeLap, int femtioLap, int hundraLap)
        {
            EnKrona = enKrona;
            FemKrona = femKrona;
            TioKrona = tioKrona;
            TjugeLap = tjugeLap;
            FemtioLap = femtioLap;
            HundraLap = hundraLap;

            enkrona.Add(EnKrona);
            femkrona.Add(FemKrona);
            tiokrona.Add(TioKrona);
            tjugolapp.Add(TjugeLap);
            femtiolapp.Add(FemtioLap);
            hundralapp.Add(HundraLap);


        }


        public static int Amount()
        {


            Console.Clear();
            Console.WriteLine($"Your accont balace is {summa}kr");
            Console.WriteLine("");
            Console.WriteLine($":1. {enkrona.Count}st 1-kronor         4. {tjugolapp.Count}st 20-lappar");
            Console.WriteLine($":2. {femkrona.Count}st 5-kronor        5. {femtiolapp.Count}st 50-lappar");
            Console.WriteLine($":3. {tiokrona.Count}st 10-kronor      6. {hundralapp.Count}st 100-lappar");
            Console.WriteLine(":0.Back");




            int selectedAmount = Validator.Convert<int>("option (vilken valör vill du ha):");

            switch (selectedAmount)
            {
                case 1:

                    Console.WriteLine("How many 1-kronor will you insert?");
                    int e = Validator.Convert<int>("amount");
                    if (Plånboken.enkrona.Count >= e)
                    {
                        for (int i = 0; i < e; i++)
                        {
                            Plånboken.enkrona.Remove(Plånboken.enkrona[0]);

                        }
                        int vale = 1 * e;
                        summa += vale;

                        return vale;
                    }
                    else
                    {
                        Utility.PrintMessage($"We dont have that many. Try again.", false);
                        return -1;
                    }
                    

                    
                    break;


                case 2:

                    Console.WriteLine("How many 5-kronor will you insert?");
                    int f = Validator.Convert<int>("amount");

                    if (femkrona.Count >= f)
                    {
                        for (int i = 0; i < f; i++)
                        {
                            Plånboken.femkrona.Remove(Plånboken.femkrona[0]);

                        }
                        int valf = 5 * f;
                        summa += valf;

                        return valf;
                    }

                    else
                    {
                        Utility.PrintMessage($"We dont have that many. Try again.", false);
                        return -1;
                    }


                    break;




                case 3:
                    Console.WriteLine("How many 10-kronor will you insert?");
                    int t = Validator.Convert<int>("amount");

                    if(tiokrona.Count >= t)
                    {
                        for (int i = 0; i < t; i++)
                        {
                            Plånboken.tiokrona.Remove(Plånboken.tiokrona[0]);

                        }
                        int valt = 10 * t;
                        summa += valt;

                        return valt;
                    }
                    else
                    {
                        Utility.PrintMessage($"We dont have that many. Try again.", false);
                        return -1;
                    }

                    break;



                case 4:
                    Console.WriteLine("How many 20-sedlar will you insert?");
                    int ts = Validator.Convert<int>("amount");

                    if(tjugolapp.Count >= ts)
                    {
                        for (int i = 0; i < ts; i++)
                        {
                            Plånboken.tjugolapp.Remove(Plånboken.tjugolapp[0]);

                        }
                        int valts = 20 * ts;
                        summa += valts;

                        return valts;
                    }
                    else
                    {
                        Utility.PrintMessage($"We dont have that many. Try again.", false);
                        return -1;
                    }

                    break;



                case 5:

                    Console.WriteLine("How many 50-sedlar will you insert?");
                    int fs = Validator.Convert<int>("amount");

                    if(femtiolapp.Count >= fs)
                    {
                        for (int i = 0; i < fs; i++)
                        {
                            Plånboken.femtiolapp.Remove(Plånboken.femtiolapp[0]);

                        }
                        int valfs = 50 * fs;
                        summa += valfs;

                        return valfs;
                    }

                    else
                    {
                        Utility.PrintMessage($"We dont have that many. Try again.", false);
                        return -1;
                    }


                    break;



                case 6:

                    Console.WriteLine("How many 100-sedlar will you insert?");
                    int hs = Validator.Convert<int>("amount");

                    if(hundralapp.Count >= hs)
                    {
                        for (int i = 0; i < hs; i++)
                        {
                            Plånboken.hundralapp.Remove(Plånboken.hundralapp[0]);

                        }
                        int valhs = 100 * hs;
                        summa += valhs;


                        return valhs;
                    }
                    else
                    {
                        Utility.PrintMessage($"We dont have that many. Try again.", false);
                        return -1;
                    }


                    break;

                case 0:
                    return 0;
                    break;


                default:
                    Utility.PrintMessage("Invalid input. Try again.", false);

                    return -1;
                    break;

            }





        }
    }
}
