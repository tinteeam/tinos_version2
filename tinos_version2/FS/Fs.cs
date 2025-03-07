using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;

namespace tinos_version2.FS
{
    public class Fs
    {
        static CosmosVFS fs = new CosmosVFS();
        public static void Init()
        {
            VFSManager.RegisterVFS(fs);
            Console.WriteLine("FS module has been initialized");
        }

        public static void availableSpace()
        {
            var availableSpace = fs.GetAvailableFreeSpace(@"0:\");
            Console.WriteLine("Available space: " + availableSpace);
            var fs_type = fs.GetFileSystemType(@"0:\");
            Console.WriteLine("File System Type: " + fs_type);
        }
    }
}
