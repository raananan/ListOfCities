using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;


namespace EladAssignment1
{
    class Street
    {

        private static int CodeCityIncreament = 111;
        private static int DisplayCityIncreament = 0;

        private string name;
        private int code;
        private int display;
        private int code_city;


        public Street(string _name, int _code_city)
        {
            this.name = _name;
            this.code = Interlocked.Increment(ref CodeCityIncreament);//Auto increament
            this.display = Interlocked.Increment(ref DisplayCityIncreament);//Auto increament
            this.code_city = _code_city;
        }
        public string getName
        {
            get { return name; }
            set { if (name == null || name == "") throw new Exception("Please try again"); else name = value; }
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
        public int getCodeCity
        {
            get { return code_city; }
            set { code_city = value; }
        }
    }
}
