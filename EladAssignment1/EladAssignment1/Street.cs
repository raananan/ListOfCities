using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EladAssignment1
{
    class Street:City
    {
    
        public int code_city = 0;

        public int getCode_city
        {
            get { return code_city; }
            set { code_city = value; }
        }

        public Street()
        {

        }

        public Street(string _name, int _display, int _code, int code_city) : base(_name)
        {
            this.code_city = code_city;
        }

        public Street(string _name) : base(_name)
        {

        }
    }
    
}
