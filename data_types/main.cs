using System;

namespace DataTypes {

    class Program {
        public static void Main(string[] args) {
            int my_int = 1;
            long my_long = 99999991l;
            float my_float = 3.5f;
            double my_double = 1.5;
            decimal my_decimal = 3.5m;
            bool my_bool = true;
            char my_char = 'a';
            string my_string = "hola";

            Console.WriteLine($"Integer: {my_int}");
            Console.WriteLine($"Long: {my_long}");
            Console.WriteLine($"Float: {my_float}");
            Console.WriteLine($"Double: {my_double}");
            Console.WriteLine($"Decimal: {my_decimal}");
            Console.WriteLine($"Bool: {my_bool}");
            Console.WriteLine($"Char: {my_char}");
            Console.WriteLine($"String: {my_string}");
        }
    }

}
