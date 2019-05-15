using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int exp;

    public int Exp
    {
        set
        {
            exp = value;
        }
        get
        {
            return exp;
        }
    }

    public void Level
    {
        get
        {
            return exp / 5000;
        }
        set
        {
            exp = exp * 5000;
        }
    }

    public void Health { get; set; }
}
