using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEx1 : MonoBehaviour
{
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
