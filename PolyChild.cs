using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolyChild : PolyMaster
{
    new public void printData()
    {
        Debug.Log("This is Polymorphism Child Class");
    }
}
