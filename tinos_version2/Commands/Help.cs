using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos_version2.Commands
{
    public class Help : Command
    {
        public Help(string name) : base(name)
        {
        }
        public override string Execute(string[] args)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("welcome to the tin os help utility                  |");
            Console.WriteLine("=====================================================");
            Console.WriteLine("help - show help                                    |");
            Console.WriteLine("=====================================================");
            Console.WriteLine("tinver - show version                               |");
            Console.WriteLine("=====================================================");
            Console.WriteLine("file (non functional(system crash(cpu expection in debug)in debug)in debug) - create file, delete file ,create folder,delet folder");
            Console.WriteLine("=====================================================");
            Console.WriteLine("shutdown - acpi shutdown                            |");
            Console.WriteLine("=====================================================");
            Console.WriteLine("restart - restart cpu                               |");
            Console.WriteLine("=====================================================");
            Console.WriteLine("listdisk - list disk(does not list)                 |");
            Console.WriteLine("=====================================================");
            Console.WriteLine("format - formats disks(not implemented)             |");
            Console.WriteLine("=====================================================");
            Console.WriteLine("changes - change log in the os itself");
            return "================================================================";
        }
    }
}