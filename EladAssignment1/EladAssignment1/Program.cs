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
                Console.WriteLine("Please choose one from the options\n 1 - Create city\n2 - Create street\n 3-Display all cities\n 4-Display all streets\n 5-Exit");
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

                }
            }

            void CreateCity()
            {
                string name;
                Console.WriteLine("Please choose the name of city you want to add");
                try
                {
                    name = Console.ReadLine();
                    Cities.Add(new City(name) { geName = name });
                    Console.WriteLine("City added with success");
                    Console.WriteLine("{0}", name);
                    Thread.Sleep(2000);
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
                        Console.WriteLine("Please add the code of city which contain the street");
                        code_city = Convert.ToInt32(Console.ReadLine());
                        foreach (City city in Cities)
                        {
                            if (city.code == code_city)
                            {
                                Streets.Add(new Street(name) { geName = name });
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
                    Console.WriteLine("{0}.City: {1}, code of city {2}",city.display,city.geName,city.getCode);
                }
            }
            void PrintStreet()
            {
                foreach (Street street in Streets)
                {
                    Console.WriteLine("{0}.City: {1}, code of city {2}", street.display, street.geName, street.getCode);
                }
            }
        }
        }
    }
        


