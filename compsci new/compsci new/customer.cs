using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compsci_new
{
    internal class customer
    {
        public string name; public bool premium;
        public customer(string thename, bool ispremium)
        {
            name = thename;
            premium = ispremium;
        }
        string getname(string Name)
        {
            return Name;
        }
        bool ispremium(bool Premium)
        {
            return Premium;
        }
    }
}
