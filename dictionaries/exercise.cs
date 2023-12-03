using System;
using System.Collections.Generic;

public class Exercise {

    public static void Main(string[] args) {

        Dictionary<string,long> inventory = new Dictionary<string,long>();
        inventory["apple"] = 3l;
        inventory["orange"] = 5l;
        inventory["banana"] = 2l;

        foreach (KeyValuePair<string,long> product in inventory) {
            Console.WriteLine(product.Value);
        }

    }

}
