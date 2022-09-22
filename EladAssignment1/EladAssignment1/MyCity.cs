using System;
using System.Collections.Generic;
using System.Text;

namespace EladAssignment1
{
    class MyCity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int Display { get; set; }
        List<MyCity> Cities1 = new List<MyCity>();

        public MyCity(string _name, int code, int display)
        {
            this.Name = _name;
            this.Code = code;
            this.Display = display;
        }

        public void Print()
        {
            foreach (var item in Cities1)
                Console.WriteLine("Name: {0}, code: {1}, display: {2}", item.Name, item.Code, item.Display);
        }
    }
}
