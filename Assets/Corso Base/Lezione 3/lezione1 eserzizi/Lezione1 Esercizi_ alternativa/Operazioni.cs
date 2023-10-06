using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operazioni : MonoBehaviour
{
    int numero_elementi = 7;

    [SerializeField]
    List<int> addendo1, addendo2, risultato;
    [SerializeField]
    float moltiplicatore ;
    string errore = "attenzione gli rray sono di dimensione diversa da quanto previsto";

    public bool isDebugActive = false;
    // Start is called before the first frame update
    void Start()
    {
        risultato = new List<int>(addendo1.Count);
        // addendo1 = new int[numero_elementi];

        string tmp= errore.Replace("attenzione", "warning");
        Debug.Log("parola-" + tmp);
        /*
        foreach (string parola in tmp)
        {
            Debug.Log("parola-" + parola);
        }
        */
       // if (addendo2.Contains(2))
          





    }

    // Update is called once per frame
    void Update()
    {
       // addendo2.Add(2);
        if (addendo1.Count != addendo2.Count)
        {
            Debug.LogError(errore);
        }
        else
        {
            for (int i = 0; i < addendo1.Count; i++)
            {
                risultato[i] = (Somma(addendo1[i], addendo2[i]));
            }
        }

        
       
        /*
        bool a = addendo1[] > addendo2;
        float risultato=0f;
        bool b = addendo2 == addendo1;
        if (a)
        {
             risultato= (Somma(addendo1, addendo2)) * moltiplicatore;
        }
        else if (b)
        {
            risultato = 10;
        }
        else
        {
            risultato = (Somma(addendo1, addendo2));
        }

        
        //Debug.Log("il risultato è " + risultato);
        //if (isDebugActive)
         Debug.Log("il risultato è " + risultato);
         */


    }


    int Somma(int add1, int add2)
    {
        
        return add1 + add2;
    }
}
