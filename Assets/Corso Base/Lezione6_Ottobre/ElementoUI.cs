using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ElementoUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshProUGUI;
    [SerializeField] Image image;
  

    public void SetData(Sprite sprite, string text)
    {
        image.sprite = sprite;
        textMeshProUGUI.text= text; 
    }
}
