using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tinos_version2.FS;

namespace tinos_version2.Commands
{
    public class PartInfo : Command
    {
        public PartInfo(string name) : base(name) { }

        public override string Execute(string[] args)
        {
            FS.Fs.availableSpace();
            return base.Execute(args);
        }
    }
}
