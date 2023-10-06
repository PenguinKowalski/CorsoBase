using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    int var = 20;
    int prec1, prec2;
    int numero;

    void Start()
    {
        prec1 = 0;
        prec2 = 1;

        Debug.Log("il numero di fibonnaci è: " + prec1);

        for (int i=0; i<var; i++)
        {
            numero = prec1 + prec2;
            prec2 = prec1;
            prec1 = numero;

            Debug.Log("il numero di fibonnaci è: " + numero);
        }
    }


}
