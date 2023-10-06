using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiramideAsterischi : MonoBehaviour
{
    public char car = '*';

    public int val_massimo = 10;

    string piramide;

    void Start()
    {
        piramide = car.ToString();

        for (int i=0; i< val_massimo; i++)
        {
            Debug.Log(piramide);
            piramide = piramide + car.ToString();
            
        }
        
        for (int i = val_massimo; i > 0; i--)
        {
            Debug.Log(piramide);
            piramide = piramide.Remove(piramide.Length-2,1);
        }

        Debug.Log(piramide);
        
    }

}
