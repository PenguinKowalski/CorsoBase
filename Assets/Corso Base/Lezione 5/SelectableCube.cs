using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectableCube : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
       Debug.Log("ENTER Test");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("EXIT Test");
    }
}
