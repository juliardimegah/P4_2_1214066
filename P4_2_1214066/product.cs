using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214066
{
    public class product
    {
        private string mytype;
        private string myname;

        public product()
        {

        }

        public product(string type, string name)
        {
            this.mytype = type;
            this.myname = name;
        }

        public string MyType
        {
            get
            {
                return mytype;
            }

            set
            {
                mytype = value;
            }
        }

        public string myName
        {
            get
            {
                return myname;
            }

            set
            {
                myName = value;
            }
        }
    }
}

