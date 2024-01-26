using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tin_version_2.Commands
{
    internal class TinVer : Command
    {
        public TinVer(string name) : base(name) { }
        public override string Execute(string[] args)
        {
            return "tin version 2. build 2. licensed with MIT license. copyright randomusert 2023";
        }
    }
}