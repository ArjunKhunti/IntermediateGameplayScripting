using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverrideMaster : MonoBehaviour
{
    public virtual void DoubleData()
    {
        int a = 10;
        Debug.Log("Value of a in Master Class is " + a * 2);
    }
}
