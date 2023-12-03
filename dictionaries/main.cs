using System;
using System.Collections.Generic;

public class Dictionaries {

    public static void Main(string[] args) {

        Dictionary<string,long> phonebook = new Dictionary<string,long>();
        phonebook.Add("Alex", 4154346543);
        phonebook["Jessica"] = 4159484588;

        if (phonebook.ContainsKey("Alex")) {
            Console.WriteLine($"Alex phone number: {phonebook["Alex"]}");
        }

    }

}
