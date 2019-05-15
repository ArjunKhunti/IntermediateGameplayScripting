using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Bike
{
    public Car()
    {
        color = "White";
        Debug.Log("Colour of Car is " + color);
    }
    public Car(string color) : base(color)
    {
        Debug.Log("Second Constructor Called");
    }
   
}
