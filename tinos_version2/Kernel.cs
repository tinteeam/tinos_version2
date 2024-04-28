using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using tin_version_2.Commands;
using Cosmos.System.FileSystem;

namespace tin_version_2
{
    public class Kernel : Sys.Kernel
    {
        private CommandManager commandManger;
        private CosmosVFS VFS;

        protected override void BeforeRun()
        {
            this.commandManger = new CommandManager();
            this.VFS = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.VFS);

            Console.WriteLine("welcome to the new version of tin os");

        }

        protected override void Run()
        {
            string response;


            response = this.commandManger.ProcessInput(Console.ReadLine());
            Console.Write(">");

            Console.WriteLine(response);
        }
    }
}
