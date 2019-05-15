
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : Vehicle
{
    public string color;

    public Bike()
    {
        color = "BLack";
        Debug.Log("Colour of Bike: " + color);
    }

    public Bike(string color)
    {
        this.color = color;
        Debug.Log("Updated Colour of Bike : " + color);
    }
}