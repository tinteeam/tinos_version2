using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System;

namespace tinos_version2.Commands
{
    public class Kill:Command
    {
        public Kill(string name):base(name) { }

        public override string Execute(string[] args)
        {
            switch (args[0])
            {
                case "kernel":
                    {
                        Cosmos.System.Power.Shutdown();
                        return"";
                    }
            }

            return "";
        }
    }
}
