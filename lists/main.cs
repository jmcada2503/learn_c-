using System;
using System.Collections.Generic;
using System.Linq;

public class Lists {

    public static void Main(string[] args) {

        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        for (int i=0; i<numbers.Count; i++) {
            Console.Write(numbers[i]+" ");
        }
        Console.WriteLine();

        List<string> test = Enumerable.Repeat("hola", 10).ToList();
        string[] array_string = {"chao", "adios"};
        test.AddRange(array_string);
        for (int i=0; i<test.Count; i++) {
            Console.Write(test[i]+" ");
        }
        Console.WriteLine();

        List<int> nums = new List<int> {1,2,3,4,5,6,7,8,9,10};
        nums.Remove(1);
        nums.RemoveAt(1);
        for (int i=0; i<nums.Count; i++) Console.Write(nums[i]+" "); Console.WriteLine();

    }

}
