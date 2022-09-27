using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace EladAssignment1
{
  
    class City
    { 
        private static int CodeCityIncrement = 111;
        private static int DisplayCityIncrement = 0;

        private string name;
        private int code;
        private int display;

        public City(string _name)
        {
            this.name = _name;
            this.code = Interlocked.Increment(ref CodeCityIncrement);//Auto increment
            this.display= Interlocked.Increment(ref DisplayCityIncrement);//Auto increment
        }
        public string getName
        {
            get { return name; }
            set { if (name == null||name=="") throw new Exception("Please try again"); else name = value; }
        }

        public int getCode
        {
            get { return code; }
            set { code = value; }
        }
        public int getDisplay
        {
            get { return display; }
            set { display = value; }
        }
    }
}
