using UnityEngine;
using System.Collections;

public class Class2 <T>
{
    T item;
    public Class2(T newItem)
    {
        item = newItem;
    }
}