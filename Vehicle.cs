using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    void Start()
    {
        Debug.Log("First Vehicle Initialized");
        Car ct = new Car();
        Debug.Log("Second Vehicle Initialized");
        Bike bk = new Bike();

        Debug.Log("Car with Yellow");
        Car ct1 = new Car("Yellow");
        Debug.Log("Bike with Grey");
        Bike bk1 = new Bike("Grey");    
    }
}
