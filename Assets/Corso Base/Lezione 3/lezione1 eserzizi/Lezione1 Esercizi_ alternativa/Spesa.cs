using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spesa : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public string nome;
        public float costo;

        public Item(string _nome, float _costo)
        {
            nome = _nome;
            costo = _costo;
        }
    }
    [System.Serializable]
    public class ItemAquisto
    {
        public string oggetto;
        public int num_acquistati;

        public ItemAquisto(string _oggetto, int _num_acquistati)
        {
            oggetto = _oggetto;
            num_acquistati = _num_acquistati;
        }
    }

    public float Contanti=100;

    public Item[] prodotti;

    public List<ItemAquisto> prodotti_in_acquisto;

    public Dictionary<string, Item> hash_item;

    void Start()
    {
        //creo lista degli oggetti acquistabili
        prodotti = new Item[7];

        prodotti[0] = new Item("mela", 0.5f);
        prodotti[1] = new Item("pera", 1f);
        prodotti[2] = new Item("banana", 0.8f);
        prodotti[3] = new Item("fragola", 0.3f);
        prodotti[4] = new Item("kiwi", 2);
        prodotti[5] = new Item("nocciola", 4);
        prodotti[6] = new Item("avocado", 0.6f);

        hash_item = new Dictionary<string, Item>();
        for(int i=0; i< prodotti.Length; i++)
        {
            hash_item.Add(prodotti[i].nome, prodotti[i]);
        }

        float risultato= SommaPrezzi(prodotti, prodotti_in_acquisto, Contanti);

        if (risultato>=0)
            Debug.Log("i prodotti sono stati acquistati, ti rimane " + risultato );
        else
            Debug.Log("i prodotti non sono stati acquistati");

    }

    float SommaPrezzi(Item[] _proddoti, List<ItemAquisto> prodottiAquistati , float contantiDisponibili)
    {
        Item prodotto;
        float somma = 0;

        foreach (ItemAquisto prod in prodottiAquistati)
        {
            if (hash_item.TryGetValue(prod.oggetto, out prodotto))
            {
                somma += prod.num_acquistati * prodotto.costo;
            }
        }
       

        if (contantiDisponibili> somma)
        {
            return contantiDisponibili - somma;
        }
        else
        {
            return -1;
        }      
    }





}
