using UnityEngine;
using System.Collections;
using System; 


public class BadGuy : IComparable<BadGuy>
{
    public string name;
    public int power;

    public BadGuy(string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    public int CompareTo(BadGuy other)
    {
        if (other == null)
        {
            return 1;
        }

        return power - other.power;
    }
}