﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.FileSystem;
using tinos_version2.FS;

namespace tinos_version2.Commands
{
    public class ListDisk : Command
    {
        public ListDisk(string name) : base(name) { }

        public override string Execute(string[] args)
        {
            FS.Fs.listDisks();
            return "";
        }
    }
}
