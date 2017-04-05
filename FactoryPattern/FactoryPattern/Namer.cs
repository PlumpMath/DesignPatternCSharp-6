using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Namer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class FirstFirst : Namer
    {
        public FirstFirst(string name)
        {
            int i = name.IndexOf(" ");
            if (i > 0)
            {
                FirstName = name.Substring(0, i).Trim();
                LastName = name.Substring(i + 1).Trim();
            }
            else
            {
                LastName = name;
                FirstName = "";
            }
        }
    }

    public class LastFirst : Namer
    {
        public LastFirst(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
            {
                LastName = name.Substring(0, i);
                FirstName = name.Substring(i + 1).Trim();
            }
            else
            {
                LastName = name;
                FirstName = "";
            }
        }
    }

    public class NameFactory
    {
        public NameFactory() { }

        public Namer GetNamer(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
                return new LastFirst(name);
            else
                return new FirstFirst(name);
        }
    }

}
