using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos_version2.Commands
{
    internal class TinVer : Command
    {
        public TinVer(string name) : base(name) { }
        public override string Execute(string[] args)
        {
            Console.WriteLine("  _______ _        ____       __      __           _               ___  \r\n |__   __(_)      / __ \\      \\ \\    / /          (_)             |__ \\ \r\n    | |   _ _ __ | |  | |___   \\ \\  / /__ _ __ ___ _  ___  _ __      ) |\r\n    | |  | | '_ \\| |  | / __|   \\ \\/ / _ \\ '__/ __| |/ _ \\| '_ \\    / / \r\n    | |  | | | | | |__| \\__ \\    \\  /  __/ |  \\__ \\ | (_) | | | |  / /_ \r\n    |_|  |_|_| |_|\\____/|___/     \\/ \\___|_|  |___/_|\\___/|_| |_| |____|");
            Console.WriteLine("tin version 2. build 4.\r\n licensed with MIT license.");
            Console.WriteLine("copyright randomusert and contributors 2025");
            return "";
        }
    }
}