using System;
using System.Collections.Generic;

namespace ambaganSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pin = 11111;
            char chs = 'Y', yy = 'Y';

            Console.Write("Enter a Pin: ");
            int pass = Convert.ToInt16(Console.ReadLine());

            if (pass == pin)
            {
                Console.WriteLine("Login Successful!");

                string[] make = new string[] { "\n[1] List", "[2] View", "[3] Remove" };

                var ambags = new List<Tuple<int, string, int, int, int>>();

                do
                {
                    foreach (var mk in make)
                    {
                        Console.WriteLine(mk);
                    }

                    Console.Write("To Do : ");
                    int ccc = Convert.ToInt16(Console.ReadLine());


                    if (ccc == 1)
                    {
                        Console.Write("\nSet an Amount: ");
                        int set = Convert.ToInt16(Console.ReadLine());

                        do
                        {
                            Console.Write("\nEnter a Name: ");
                            string name = Console.ReadLine().ToLower();

                            Console.Write("Enter an Amount: ");
                            int amnt = Convert.ToInt16(Console.ReadLine());

                            int change = amnt - set;

                            ambags.Add(new Tuple<int, string, int, int, int>(set, name, amnt, set, change));
                            Console.WriteLine("\nAmbag Added!");

                            Console.Write("\nAdd another Ambag? (Y/N): ");
                            yy = char.ToUpper(Console.ReadLine()[0]);
                        } while (yy == 'Y');

                        Console.Write("\nDo another Case? (Y/N) : ");
                        chs = char.ToUpper(Console.ReadLine()[0]);
                    }


                    else if (ccc == 2)
                    {

                        if (ambags.Count > 0)
                        {
                            Console.WriteLine($"\nAmbagan: {ambags[0].Item1}");

                            Console.WriteLine("\nList of Ambags: ");

                            foreach (var ambs in ambags)
                            {
                                Console.WriteLine($"Name: {ambs.Item2}, Bigay: {ambs.Item3}, Ambag: {ambs.Item4}, Sukli: {ambs.Item5}");
                            }

                            int tAmnt = 0, tSet = 0, tChng = 0;
                            foreach (var ambs in ambags)
                            {
                                tAmnt += ambs.Item3;
                                tSet += ambs.Item4;
                                tChng += ambs.Item5;

                            }

                            Console.WriteLine($"\nTotal Bigay: {tAmnt} ");
                            Console.WriteLine($"Total Ambag: {tSet} ");
                            Console.WriteLine($"Total Sukli: {tChng} ");

                        }
                        else
                        {
                            Console.WriteLine("\nThere are no available list.");
                        }

                        Console.Write("\nDo another? (Y/N) : ");
                        chs = char.ToUpper(Console.ReadLine()[0]);
                    }


                    else if (ccc == 3)
                    {
                        Console.Write("\nEnter a Name to Remove: ");
                        string reName = Console.ReadLine().ToLower();

                        var toRemove = ambags.Find(ntr => ntr.Item2 == reName);

                        if (toRemove != null)
                        {
                            ambags.Remove(toRemove);
                            Console.WriteLine($"\n{reName} was remove from the list.");
                        }

                        Console.Write("\nDo another? (Y/N) : ");
                        chs = char.ToUpper(Console.ReadLine()[0]);
                    }

                    else
                    {
                        Console.WriteLine("Invalid Case!");

                        Console.Write("\nDo another? (Y/N) : ");
                        chs = char.ToUpper(Console.ReadLine()[0]);
                    }

                } while (chs == 'Y');

            }
            else
            {
                Console.WriteLine("Pin Error!");
            }


        }
    }
}
