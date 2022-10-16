using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214066
{
    public class velg : product
    {
        public velg(string type, string name, string spokes) : base(type, name)
        {
            this.Spoke = spokes;
        }

        public string Spoke
        {
            get
            {
                return this.Spoke;
            }
            set
            {
                Spoke = value;
            }
        }

    }
}
