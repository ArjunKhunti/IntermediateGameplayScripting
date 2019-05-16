using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverrideMain : MonoBehaviour
{
    
    void Start()
    {
        OverrideMaster om = new OverrideMaster();
        OverrideChild oc = new OverrideChild();

        om.DoubleData();
        oc.DoubleData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
