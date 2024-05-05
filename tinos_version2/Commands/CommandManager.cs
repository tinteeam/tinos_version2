using Cosmos.Core.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tinos_version2.Commands
{
    public class CommandManager
    {
        private List<Command> commands;


        public CommandManager()
        {
            this.commands = new List<Command>(15);
            this.commands.Add(new Help("help"));
            this.commands.Add(new File("file"));
            this.commands.Add(new TinVer("tinver"));
            this.commands.Add(new Shutdown("shutdown"));
            this.commands.Add(new Restart("restart"));
            this.commands.Add(new ListDisk("listdisk"));
            this.commands.Add(new Format("format"));
            this.commands.Add(new Clear("clear"));
            this.commands.Add(new Changes("changes"));
            this.commands.Add(new Kill("kill"));
            this.commands.Add(new Service("sc"));

        }

        public string ProcessInput(string input)
        {
            // "taskkill /F /T IM cmd.exe"

            string[] split = input.Split(' ');

            string label = split[0];

            List<string> args = new List<string>();

            int ctr = 0;

            foreach (string s in split)
            {

                if (ctr != 0)
                    args.Add(s);
                ++ctr;
            }

            foreach (Command cmd in this.commands)
            {
                if (cmd.name == label)
                {
                    return cmd.Execute(args.ToArray());
                }
            }
            return "the command that you typed isn't a the command that you did type is \"" + label + ".";
        }
    }
}