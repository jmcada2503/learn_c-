using System;

class Vehicle {

    private string _Type;
    private int _NumTires;

    public string Type {
        get {
            return this._Type;
        }
        set {
            if (value == String.Empty) {
                Console.WriteLine("The vehicle type cannot be empty");
            }
            else {
                this._Type = value;
            }
        }
    }

    public int NumTires {
        get {
            return this._NumTires;
        }
        set {
            if (value < 1) {
                Console.WriteLine("The vehicle must have at least one tire");
            }
            else {
                this._NumTires = value;
            }
        }
    }

}

public class MainClass {

    public static void Main(string[] args) {
        Vehicle myRide = new Vehicle();
        myRide.Type = "Motorcycle";
        myRide.NumTires = 2;
        Console.WriteLine(myRide.Type);
        Console.WriteLine(myRide.NumTires);
        myRide.Type = String.Empty;
        Console.WriteLine(myRide.Type);
        myRide.NumTires = 0;
        Console.WriteLine(myRide.NumTires);
    }

}
