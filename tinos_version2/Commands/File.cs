using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;



namespace tinos_version2.Commands
{
    public class File : Command
    {
        public File(string name) : base(name) { }

        public override string Execute(string[] args)
        {

            String response = "";
            switch (args[0])
            {
                case "create":
                    {

                        try
                        {
                            Sys.FileSystem.VFS.VFSManager.CreateFile(args[1]);
                            response = "your file" + args[1] + " is in the drive";
                        }
                        catch (Exception ex)
                        {
                            response = ex.ToString();
                        }
                        break;
                    }
                case "delete":
                    {
                        try
                        {
                            Sys.FileSystem.VFS.VFSManager.DeleteFile(args[1]);
                            response = "your file" + args[1] + " is not in the drive any more";
                        }
                        catch (Exception ex)
                        {
                            response = ex.ToString();
                        }
                        break;
                    }
                case "md":
                    {
                        try
                        {
                            Sys.FileSystem.VFS.VFSManager.CreateDirectory(args[1]);
                            response = "your folder" + args[1] + " is in the drive";
                        }
                        catch (Exception ex)
                        {
                            response = ex.ToString();
                        }
                        break;
                    }



                case "rmd":
                    {
                        try
                        {
                            Sys.FileSystem.VFS.VFSManager.DeleteDirectory(args[1], true);
                            response = "your folder" + args[1] + " is not in the drive any more";
                        }
                        catch (Exception ex)
                        {
                            response = ex.ToString();
                        }
                        break;
                    }




                case "writefl":
                    {
                        try
                        {
                            FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();


                            if (fs.CanWrite)
                            {

                            }
                            else
                            {
                                response = "File in use or it is read only file";
                            }
                        }
                        catch (Exception ex)
                        {
                            response = ex.ToString();
                        }
                        break;
                    }
                default:
                    {
                        response = "unexpected arguments";
                        return response;
                    }
            }
            return response;
        }
    }
}