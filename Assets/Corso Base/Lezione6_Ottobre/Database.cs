using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{

    [SerializeField] List<Elemento> lista;

    public List<Elemento> Lista { get => lista; set => lista = value; }


    //public Schermata1 schermata1;



}

[Serializable]
public class Elemento
{
    public string titolo;
    public Sprite immagine;
}
