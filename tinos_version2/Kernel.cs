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
            Console.WriteLine("  _______ _        ____       __      __           _               ___  \r\n |__   __(_)      / __ \\      \\ \\    / /          (_)             |__ \\ \r\n    | |   _ _ __ | |  | |___   \\ \\  / /__ _ __ ___ _  ___  _ __      ) |\r\n    | |  | | '_ \\| |  | / __|   \\ \\/ / _ \\ '__/ __| |/ _ \\| '_ \\    / / \r\n    | |  | | | | | |__| \\__ \\    \\  /  __/ |  \\__ \\ | (_) | | | |  / /_ \r\n    |_|  |_|_| |_|\\____/|___/     \\/ \\___|_|  |___/_|\\___/|_| |_| |____|");


        }

        protected override void Run()
        {
            string response;
            Console.Write(">");

            response = this.commandManger.ProcessInput(Console.ReadLine());


            Console.WriteLine(response);
        }
    }
}