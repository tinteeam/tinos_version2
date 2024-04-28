using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using tinos_version2.Commands;

namespace tinos_version2
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
