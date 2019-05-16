using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolyMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PolyMaster pm = new PolyMaster();
        PolyChild pc = new PolyChild();

        pm.printData();
        pc.printData();

        Debug.Log("This is Polymorphism Main Class");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
