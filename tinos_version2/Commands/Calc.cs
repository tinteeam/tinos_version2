using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos_version2.Commands
{
    public class Calc : Command
    {
        public Calc(string name) : base(name) { }

        public override string Execute(string[] args)
        {
            if (args.Length != 3)
                return "Expected <num> <op> <num> args.";

            long num1, num2;
            string op = args[1];

            if (!long.TryParse(args[0], out num1))
                return "Expected a number for arg 1.";

            if (!long.TryParse(args[2], out num2))
                return "Expected a number for arg 3.";

            switch (op)
            {
                case "+":
                    return $"{num1} + {num2} = {num1 + num2}";
                case "-":
                    return $"{num1} - {num2} = {num1 - num2}";
                case "*":
                case "X":
                case "x":
                    return $"{num1} * {num2} = {num1 * num2}";
                case "/":
                    if (num1 == 0)
                        return $"{num1} / {num2} = unsigned infinity";
                    return $"{num1} / {num2} = {num1 / num2}";
                case "%":
                    return $"{num1} % {num2} = {num1 % num2}";
                default:
                    return "Expected a operator for arg 2.";
            }
        }
    }
}
