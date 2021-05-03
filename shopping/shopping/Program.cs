using System;
using System.Collections.Generic;
using System.Linq;

namespace shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                Console.WriteLine("Flowers list: ");
                Console.WriteLine("\n 1.Rose 10SR \n 2.Lily 25SR \n 3.Tulip 30SR \n 4.Orchid 40SR \n 5.Freesia 50SR");
                str = Console.ReadLine();

                List<string> bag = new List<string>();
                bag.Add(str);
                Ask:
                Console.WriteLine("Add --> to add more \n Delete --> to delete item\n Buy --> to pay \n Print --> to view result ");

                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "Add":
                        Console.WriteLine();
                        Console.WriteLine("Add Flowers: ");
                        str = Console.ReadLine();
                        bag.Add(str);
                        Console.WriteLine();
                         goto Ask;
                   
                     case "Delete":
                        Console.WriteLine();
                        Console.WriteLine("Enter what you whant to delete: ");
                        string d = Console.ReadLine();
                        bag.Remove(d);
                        Console.WriteLine();
                        goto Ask;
                       

                    case "Print":

                        Console.WriteLine("Your Shopping bag contains of: ");
                        foreach (var item in bag)
                        {
                            Console.WriteLine();
                            Console.WriteLine(item);
                            Console.WriteLine();
                        }
                        goto Ask;

                    case "Buy":
                        List<decimal> check = new List<decimal>();
                        foreach (var item in bag)
                        {
                            if (item == "Rose")
                            {
                                check.Add(10);
                            }
                            else if (item == "Lily")
                            {
                                check.Add(25);
                            }
                            else if (item == "Tulip")
                            {
                                check.Add(30);
                            }
                            else if (item == "Orchid")
                            {
                                check.Add(40);
                            }

                            else if (item == "Freesia")
                            {
                                check.Add(50);
                            }
                            
                            
                        }
                        decimal result;
                        decimal pill = check.Sum();
                        if (pill >= 100)
                        {
                             result = pill * 0.10m;

                            Console.WriteLine("You got a discount! Your pill is: ");
                            Console.WriteLine(pill - result);
                        }
                        else
                        {
                            Console.WriteLine("Your pill is: ");
                            Console.WriteLine(pill);
                        }

                        goto Ask;
                    default:
                        Console.WriteLine("Good Bye! Thanks for shopping with us .. See you again (: ");
                        break;
                }


            } while (!str.Equals("exit"));
            Console.WriteLine("Good Bye! Thanks for shopping with us .. See you again (: ");
        }
    }
}
