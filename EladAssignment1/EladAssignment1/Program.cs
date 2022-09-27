using System;
using System.Collections.Generic;
using System.Threading;

namespace EladAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> Cities = new List<City>();
            List<Street> Streets = new List<Street>();
            int num;
            while (true)
            {
                Console.WriteLine("Please choose one from the options\n\n1 - Create city\n2 - Create street\n3 - Display all cities\n4 - Display all streets\n5 - Exit");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:

                            CreateCity();
                            break;

                        case 2:
                            CreateStreet();
                            break;

                        case 3:
                            PrintCity();
                            break;

                        case 4:
                            PrintStreet();
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Number not found, please try again");
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Uncorrect choice, try again");
                }
            }

            void CreateCity()
            {
                string name;
                Console.WriteLine("Please choose the name of city you want to add");
                try
                {
                    name = Console.ReadLine();
                    Cities.Add(new City(name) { getName = name });
                    Console.WriteLine("City added with success ");
                    Console.WriteLine("City {0}", name);
                    Thread.Sleep(500);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }

            void CreateStreet()
            {
                string name;
                int code_city;
                int flag = 0;

                Console.WriteLine("Please choose the name of street you want to add");
                name = Console.ReadLine();
                try
                {
                    while (true)
                    {
                        Console.WriteLine("Please enter the code of city which contain the street by following list:\n");
                        PrintCity();
                        code_city = Convert.ToInt32(Console.ReadLine());
                        foreach (City city in Cities)
                        {
                            if (city.getCode == code_city)
                            {
                                Streets.Add(new Street(name,code_city) { getName = name , getCodeCity=code_city});
                                Console.WriteLine("Street {0} added with success to city {1}\n",name,city.getName);
                                flag = 1;
                            }
                        }
                        if (flag == 0)
                        {
                            Console.WriteLine("Code city not found");
                        }
                        break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            void PrintCity()
            {
                foreach(City city in Cities)
                {
                    Console.WriteLine("{0}.City: {1}, code of city {2}",city.getDisplay,city.getName, city.getCode);
                }
            }
            void PrintStreet()
            {
                for (int i = 0; i < Cities.Count; i++)
                {
                    Console.WriteLine("For " + Cities[i].getName + " Exist following streets\n");

                   for (int j = 0; j < Streets.Count; j++)
                      {
                        if (Streets[j].getCodeCity == Cities[i].getCode)
                           {
                             Console.WriteLine(Streets[j].getName + "\n");
                           }
                      }
                }
            }
          }
       }
    }
        


