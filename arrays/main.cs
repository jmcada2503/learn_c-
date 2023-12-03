using System;

public class Arrays {

    public static void Main(string[] args) {

        int[] nums = new int[10];
        for (int i=0; i<nums.Length; i++) Console.Write(nums[i]+" ");
        Console.WriteLine();

        int[] nums2 = {1, 2, 3 ,4, 5};
        for (int i=0; i<nums2.Length; i++) Console.Write(nums2[i]+" ");
        Console.WriteLine("\n");
        
        // Multidimensional array definition
        int[,] array2d = {{1,2,3}, {4,5,6}, {7,8,9}};
        for (int i=0; i<array2d.Length; i++) {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        int[][] array = new int[3][];
        array[0] = new int[] {1,2,3};
        array[1] = new int[] {4,5,6};
        array[2] = new int[] {7,8,9};
        for (int i=0; i<array.Length; i++) {
            Console.Write(i + " ");
        }
        Console.WriteLine();


    }

}
