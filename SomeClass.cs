using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeClass : MonoBehaviour
{
    void Start()
    {
        List<BadGuy> badguys = new List<BadGuy>();

       
        badguys.Add(new BadGuy("Rauhan", 30));
        badguys.Add(new BadGuy("Mitesh", 150));
        badguys.Add(new BadGuy("Anjali", 50));

        badguys.Sort();

        foreach (BadGuy guy in badguys)
        {
            print(guy.name + " " + guy.power);
        }

        badguys.Clear();
    }
}