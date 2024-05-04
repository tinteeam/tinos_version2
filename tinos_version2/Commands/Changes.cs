using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos_version2.Commands
{
    public class Changes : Command
    {
        public Changes(string name) : base(name) { }

        public override string Execute(string[] args)
        {
            Console.WriteLine("BUILD 2");
            Console.WriteLine("Fixes and FIRST build PUBLIC release!");
            return "";
        }
    }
}
