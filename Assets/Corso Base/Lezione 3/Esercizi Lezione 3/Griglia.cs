using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Griglia : MonoBehaviour
{
    public GameObject prefab;
    public float distanzaX, distanzaZ;
    public int N_Righe,N_Colonne;

    public Vector3 startpos;
    // Start is called before the first frame update
    void Start()
    {
       for (int i=0; i< N_Righe; i++)
        {
            for (int j=0; j< N_Colonne; j++)
            {
                GameObject go = GameObject.Instantiate(prefab, startpos + new Vector3(i * distanzaX, 0, j * distanzaZ), Quaternion.identity);
            }
        } 
    }

}
