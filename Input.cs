using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserIO
{
    public static class Input
    {
        public static bool TryReadInputAsInt(out int result, string prompt = "Enter a value: ")
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            return int.TryParse(input, out result);
        }
        public static bool TryReadInputAsBool(out bool result, string prompt = "Enter a value: ")
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            return bool.TryParse(input, out result);
        }
        public static bool TryReadInputAsFloat(out float result, string prompt = "Enter a value: ")
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            return float.TryParse(input, out result);
        }
        public static bool TryReadInputAsDouble(out double result, string prompt = "Enter a value: ")
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            return double.TryParse(input, out result);
        }
        public static bool TryReadInputAsString(out string result, string prompt = "Enter a value: ")
        {
            Console.WriteLine(prompt);
            result = Console.ReadLine();
            return true;
        }
        public static bool TryReadInputAsDateTime(out DateTime result, string prompt = "Enter a value: ")
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            return DateTime.TryParse(input, out result);
        }
        public static bool TryReadInputAsLong(out long result, string prompt = "Enter a value: ")
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            return long.TryParse(input, out result);
        }
        public static bool TryReadInputAsUnsignedInt(out uint result, string prompt = "Enter a value: ")
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            return uint.TryParse(input, out result);
        }
        public static bool TryReadInputAsUnsignedLong(out ulong result, string prompt = "Enter a value: ")
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            return ulong.TryParse(input, out result);
        }
    }
}

