using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Es_Scontrino : MonoBehaviour
{
    [System.Serializable]
    public class Oggetto
    {
        public string nome;
        public float costo;

        public Oggetto(string _nome, float _costo)
        {
            nome = _nome;
            costo = _costo;
        }
    }

    [System.Serializable]
    public class OggettoDaAcquistare
    {
        public string nome;
        public int quantità;

        public OggettoDaAcquistare(string _nome, int _quantità)
        {
            nome = _nome;
            quantità = _quantità;
        }
    }


    public Oggetto[] lista_item;
    public List<OggettoDaAcquistare> lista_da_acquistare;

    public float Contanti = 1000;
    public Dictionary<string, Oggetto> hash;
    // Start is called before the first frame update
    void Start()
    {
        lista_item = new Oggetto[7];

        lista_item[0] = new Oggetto("Mario", 20.3f);
        lista_item[1] = new Oggetto("Paolo", 14.5f);
        lista_item[2] = new Oggetto("Francesco", 39);
        lista_item[3] = new Oggetto("Giuseppe", 40);
        lista_item[4] = new Oggetto("Federico", 17);
        lista_item[5] = new Oggetto("Pietro", 26);
        lista_item[6] = new Oggetto("Maria", 21);

        hash = new Dictionary<string, Oggetto>();
        for (int i=0; i< lista_item.Length; i++)
        {
            if (!hash.ContainsKey(lista_item[i].nome))
                hash.Add(lista_item[i].nome, lista_item[i]);
        }

        float resto = SommaProdotti();

        if (Contanti> resto)
        {
            Debug.Log("hai comprato i prodotti, ti rimane " + (Contanti-resto));
        }
        else
            Debug.Log("non hai comprato i prodotti");

    }

    float SommaProdotti()
    {
        float somma = 0;
        for (int i = 0; i < lista_da_acquistare.Count; i++)
        {
            Oggetto oggetto;
            if (hash.TryGetValue(lista_da_acquistare[i].nome, out oggetto))
            {
                somma += oggetto.costo * lista_da_acquistare[i].quantità;
            }
        }
        return somma;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
