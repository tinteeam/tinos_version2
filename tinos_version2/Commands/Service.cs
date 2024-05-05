using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos_version2.Commands
{
    public class Service:Command
    {
        public Service(string name):base(name) { }

        public override string Execute(string[] args)
        {
            switch(args[0])
            {
                case "list":
                    Console.WriteLine("==================================================================");
                    Console.WriteLine("service list");
                    Console.WriteLine("==================================================================");
                    Console.WriteLine("kernel(cannot be removed!!!!!)");
                    Console.WriteLine("==================================================================");
                    return "";
            }
            return "";
        }
    }
}
