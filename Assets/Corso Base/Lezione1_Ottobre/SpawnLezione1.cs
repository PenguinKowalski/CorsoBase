using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;

public class SpawnLezione1 : MonoBehaviour
{
    string stringa; // = "ciao mondo";
    char carattere = 'c';
    int intero = 0;
    bool booleano = true;
    protected float virgola = 32.4f;
    enum Enumeratore { Nord, Ovest, Est, Sud};
    Enumeratore enumeratore = Enumeratore.Nord;

    [SerializeField]
    private GameObject oggettoDaSpawnare;

    public Vector3 spawnPosition;
    public float moltiplicatore;
    // Start is called before the first frame update
    GameObject spawnedObj;
    public int x, y;
    void Start()
    {

        Debug.Log("ciao mondo");
        spawnedObj= Instantiate(oggettoDaSpawnare, spawnPosition, oggettoDaSpawnare.transform.rotation);

        float somma = (float) Somma(3, 6);


        /*
         * x > y
         * x >= y
         * x == y
         * x < y
         * x <= y
        */
        //Destroy(spawnedObj, somma);
        
    
    }


    void OnEnable()
    {

        Debug.Log("ciao mondo attivo");

        string stringa = "alfa" + "beto";

    }

    // Update is called once per frame1
    void Update()
    {


        if (x > 0 && y ==0)
        {
            //codice 
            spawnedObj.transform.position += new Vector3(1, 0, 0) * Time.deltaTime * moltiplicatore;
        }
        else if (x==0)
        {
          
        }
        else
        {
            Debug.Log("numeri sbagliati");
        }

        switch (stringa)
        {
            case "ciao":
                //Debug.Log("numeri sbagliati");

                //break;

            case "chiudi":
                Debug.Log("numeri sbagliati");
                break;

            default:
                Debug.Log("numeri sbagliati");
                break;

        }
        //Debug.Log("ciao mondo ogni frame");
    }

    
    int Somma(int a , int b)
    {
        int sum = a + b;
        return sum;
    }
}
