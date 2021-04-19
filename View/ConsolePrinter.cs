using _7.NumericalSequence.Enums;
using System;

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
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(Constant.INSTRUCTION);
            Console.WriteLine(Constant.FIRST_ARGUMENT);

            Console.ResetColor();
        }

        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteLine(string message, int color)
        {
            switch (color)
            {
                case (int)Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Color.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
