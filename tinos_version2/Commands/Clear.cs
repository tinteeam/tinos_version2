using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos_version2.Commands
{
    public class Clear : Command
    {
        public Clear(string name) : base(name) { }

        public override string Execute(string[] args)
        {
            Console.Clear();
            return "clear done";
        }
    }
}
