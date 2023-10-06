using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
public class Schermata1 : MonoBehaviour
{

    [SerializeField] Button inputButton;
    [SerializeField] TextMeshProUGUI outputText;

    [SerializeField] GameObject elementoPrefab;
    [SerializeField] Transform parentLista;

    [SerializeField] Database database;

    private void Start()
    {
        inputButton.onClick.RemoveListener(() => { OnClick(); });
        inputButton.onClick.AddListener(() => { OnClick(); });
    }


    public void SetData(List<Elemento> elementi)
    {
        for(int i = parentLista.childCount-1; i>= 0; i--)
        {
            Destroy(parentLista.GetChild(i).gameObject);
        }


        foreach(Elemento elemento in elementi)
        {
           GameObject go=   GameObject.Instantiate(elementoPrefab, parentLista);
           ElementoUI elemUI= go.GetComponent<ElementoUI>();
           elemUI.SetData(elemento.immagine, elemento.titolo);
        }
    }

    public void OnClick()
    {
        outputText.text = "Ciao Mondo";
        // inputButton.interactable = false;

        SetData(database.Lista);

    }


}
