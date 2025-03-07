using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tinos_version2.Applications.Editor;


namespace tinos_version2.Commands
{
    public class Nano : Command
    {
        public Nano(string name) : base(name) { }

        public override string Execute(string[] args)
        {
            tinos_version2.Applications.Editor.Editor.Edit();
            return "";

        }

    }
}
