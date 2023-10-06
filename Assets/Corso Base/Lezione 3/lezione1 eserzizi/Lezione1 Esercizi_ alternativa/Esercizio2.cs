using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    public class Persona
    {
        public string nome, cognome;
        public int eta;

        public Persona(string _nome, string _cognome, int _eta)
        {
            nome = _nome;
            cognome = _cognome;
            eta = _eta;
        }
    }


    Persona[] _listaPersone;

    void Start()
    {
        _listaPersone = new Persona[5];

        _listaPersone[0] = new Persona("Mario", "Rossi", 20);
        _listaPersone[1] = new Persona("Giovanni", "Verdi", 17);
        _listaPersone[2] = new Persona("Maria", "Arancio", 29);
        _listaPersone[3] = new Persona("Pietro", "Papalia", 20);
        _listaPersone[4] = new Persona("Marco", "Rossi", 26);

        Persona giovane = CercaGiovane(_listaPersone);

        Debug.Log("la persona più giovane è" + giovane.nome + " " + giovane.cognome);
    }

    Persona CercaGiovane(Persona[] _lista )
    {
        int minimo= 1000;
        int indiceMin=0;

        for (int i=0; i< _lista.Length; i++)
        {
            if (minimo > _lista[i].eta)
            {
                minimo = _lista[i].eta;
                indiceMin = i;
            }
        }

        return _lista[indiceMin];
    }

}
