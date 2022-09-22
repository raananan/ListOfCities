using System;
using System.Collections.Generic;
using System.Text;

namespace EladAssignment1
{
    class City
    {
        public string name { get; set; }
        public int code = 0;
        public int display { get; set; }
        List<City> Cities = new List<City>();

        public City(string _name, int _display)
        {
            this.name = _name;
            this.display = _display;
            this.code++;
        }
        public City()
        {
                
        }
        public void CreateCity()
        {
            Console.WriteLine("Please choose the name of city you want to add");
            name = Console.ReadLine();
            Cities.Add(new City() { name = this.name, display = this.display });
        }

        public void Print()
        {
         
            foreach (var item in Cities)
                Console.WriteLine("Name: {0}, code: {1}, Display: {2}", name,code, display);

        }
        
        public void Menu()
        {
            int num;
            Console.WriteLine("Please choose one from the options\n 1 - Create city\n 2-Display all cities\n 3-Exit");
            num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:
                    CreateCity();
                    break;

                case 2:
                    Print();
                    break;

                case 3:
                    Print();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

            }
            Menu();
        }
    }

    
}
