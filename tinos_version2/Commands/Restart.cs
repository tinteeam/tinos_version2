using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System;

namespace tinos_version2.Commands
{
    public class Restart : Command
    {
        public Restart(string name) : base(name) { }

        public override string Execute(string[] args)
        {
            Cosmos.System.Power.Reboot();
            return "";
        }
    }
}
