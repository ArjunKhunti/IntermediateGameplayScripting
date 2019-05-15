using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassB : MonoBehaviour
{
    ClassA obj= new ClassA();

    obj.Add(44, 66);
    obj.Add("Hello", "World");

}
