using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Es_Fibonacci : MonoBehaviour
{
    int numero, precedente1, precedente2;

    //N deve stare sotto i 50
    [Range(0,50)]
    public int N = 60;

    string risultato = "";
    void Start()
    {
        precedente1 = 0;
        precedente2 = 1;

        risultato = precedente1.ToString();

        for (int i=0; i< N; i++)
        {
            numero = precedente1 + precedente2;
            precedente2 = precedente1;
            precedente1 = numero;

            risultato += " "+ numero.ToString();
        }
        Debug.Log(risultato);

    }



}
