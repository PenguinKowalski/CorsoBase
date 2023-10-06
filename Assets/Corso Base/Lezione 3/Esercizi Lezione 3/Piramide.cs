using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piramide : MonoBehaviour
{
    public GameObject prefab;
    public float distanzaX, distanzaZ, distanzaY;
    public int N_Righe, N_Colonne, N_Piani;

    public Vector3 startpos;
    // Start is called before the first frame update

    void Start()
    {
        //trovo il numero di piani. cerco qual'è il lato minore e poi lo divido per due (ogni piano si restringe di due cubi per lato)
        N_Piani = Mathf.Min(N_Righe, N_Colonne);
        N_Piani = Mathf.FloorToInt(N_Piani / 2f);

        //alla fine spawno il numero di piani trovato più uno (usando il <= ) quello di partenza
        for (int i=0; i<= N_Piani; i++)
        {
            MakePiano(i * distanzaY,i);
        }
    }

    //spawnare una griglia di cubi (come l'esercizio precedente)
    void MakePiano(float Yvalue, int startIndex)
    {
        for (int i = startIndex; i < N_Righe- startIndex; i++)
        {
            for (int j = startIndex; j < N_Colonne- startIndex; j++)
            {
                GameObject go = GameObject.Instantiate(prefab, startpos + new Vector3(i * distanzaX, Yvalue, j * distanzaZ), Quaternion.identity);
            }
        }
    }
}
