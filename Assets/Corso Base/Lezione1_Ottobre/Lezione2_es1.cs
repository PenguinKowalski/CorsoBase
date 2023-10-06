using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lezione2_es1 : MonoBehaviour
{
    //FIBONACCI 
    [SerializeField]
    int N =10;

    int a = 0, b = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a);
        Debug.Log(b);

        for (int i = 0; i < N-2; i++) 
        {
            int c = a + b;          
            a = b;
            b = c;
            Debug.Log(c);
        }
    }
}
    
