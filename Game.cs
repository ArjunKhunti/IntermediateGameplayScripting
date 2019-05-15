using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player myPlayer = new Player();
        myPlayer.Exp = 5;
        int x = myPlayer.Exp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
