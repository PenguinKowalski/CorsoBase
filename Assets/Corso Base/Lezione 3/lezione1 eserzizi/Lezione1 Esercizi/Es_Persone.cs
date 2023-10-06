using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Es_Persone : MonoBehaviour
{
    [System.Serializable]
    public class Persona
    {
        public string nome, cognome;
         public int eta;
         int eta_nascosta;

        public Persona(string _nome, string _cognome, int _eta)
        {
            nome = _nome;
            cognome = _cognome;
            eta = _eta;
            eta_nascosta = _nome.Length + 20;
        }
    }

    [SerializeField]
    public Persona[] lista_persone;


    // Start is called before the first frame update
    void Start()
    {
        lista_persone = new Persona[7];

        lista_persone[0] = new Persona("Mario", "Rossi", 20);
        lista_persone[1] = new Persona("Paolo", "Bianchi", 14);
        lista_persone[2] = new Persona("Francesco", "Rossi", 39);
        lista_persone[3] = new Persona("Giuseppe", "Bianchi", 40);
        lista_persone[4] = new Persona("Federico", "Rossi", 17);
        lista_persone[5] = new Persona("Pietro", "Papalia", 26);
        lista_persone[6] = new Persona("Maria", "Verdi", 21);
        ///
       
        Persona personagiovane = CercaGiovane(lista_persone);

        Debug.Log("la persona più giovane è " +
            personagiovane.cognome + " " +
            personagiovane.nome);

    }

    public Persona CercaGiovane(Persona[] lista)
    {
        int min = 1000;
        int indice_minimo = 0;
        for (int i = lista_persone.Length-1; i >= 0; i--)
        {
            if (lista_persone[i].eta < min)
            {
                indice_minimo = i;
                min = lista_persone[i].eta;
            }
        }

        return lista_persone[indice_minimo];
    }
}
