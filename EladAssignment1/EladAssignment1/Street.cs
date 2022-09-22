using System;
using System.Collections.Generic;
using System.Text;

namespace EladAssignment1
{
    class Street
    {
        public string name { get; set; }
        public int code = 0;
        public int display { get; set; }
        public int code_city { get; set; }
        List<Street> Streets = new List<Street>();

        public Street(string _name, int _display,int _code_city)
        {
            this.name = _name;
            this.display = _display;
            this.code++;
            this.code_city = _code_city;

        }
        public Street()
        {
                
        }
        public void Createstreet()
        {
            Console.WriteLine("Please choose the name of city you want to add");
            name = Console.ReadLine();
            Streets.Add(new Street() { name = this.name, display = this.display,code_city=this.code_city });
        }

        public void Print()
        {
            foreach (var item in Streets)
                Console.WriteLine("Name: {0}, code: {1}, Display: {2}", name, code, display);
        }

    }
    
}
