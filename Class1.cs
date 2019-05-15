using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class1 : MonoBehaviour
{
    private void Start()
    {
        GenericEx1 genericEx1 = new GenericEx1();

        genericEx1.GenericMethod<int>(5);
    }
}
