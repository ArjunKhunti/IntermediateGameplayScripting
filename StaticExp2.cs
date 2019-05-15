using UnityEngine;


public class StaticExp2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Rounds are : " + StaticExp1.round);
        Debug.Log("Message that " + StaticExp1.msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
