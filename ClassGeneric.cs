using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassGeneric : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Class2<int> class2 = new Class2<int>(5); 
    }
}
