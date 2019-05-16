using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverrideChild : OverrideMaster
{
    public override void DoubleData()
    {
        int a = 5;
        Debug.Log("Value of a in ChildClass is " + a * 2);
    }
}
