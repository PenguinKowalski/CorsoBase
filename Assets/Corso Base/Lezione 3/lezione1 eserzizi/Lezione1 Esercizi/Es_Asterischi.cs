using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Es_Asterischi : MonoBehaviour
{
    string car ="ciao";

    int N = 15;

    string stringa="";

    void Start()
    {


        for (int i=0; i< N; i++)
        {
            stringa += car;
            Debug.Log(stringa);
        }


        for (int i = 1; i < N; i++)
        {
            Debug.Log(stringa);
            stringa =  stringa.Remove(stringa.Length-1-car.Length,car.Length);
           
        }

    }


}
