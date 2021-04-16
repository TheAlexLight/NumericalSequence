using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksLibrary;

namespace _7.NumericalSequence.View
{
    internal class ConsolePrinter : IOutsidePrinter
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void ShowInstruction()
        {
            Console.WriteLine(Constant.INSTRUCTION);
            Console.WriteLine(Constant.FIRST_ARGUMENT);
        }

        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
