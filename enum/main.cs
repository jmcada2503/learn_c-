using System;

namespace Enum {
    public enum Test {
        car = 1,
        bike = 2,
        test = 3,
        another_test = 4,
        final_test = 5
    }

    class Enum {
        public static void Main(string[] args) {

            Test my_test = Test.car;
            Console.WriteLine($"Test: {my_test}");

        }
    }
}
