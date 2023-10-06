using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buca : MonoBehaviour
{
    ForzaSfera sfera=null;
    private void OnTriggerEnter(Collider other)
    {
      
        sfera = other.GetComponent<ForzaSfera>();

        if (sfera != null)
        {
            Debug.Log("� entrato l'oggetto " + other.name);
        }
    }

    private void Update()
    {
        if (sfera != null)
        {
            Debug.Log("� dentro l'oggetto " + sfera.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {       

        if (sfera != null)
        {
            Debug.Log("� uscito l'oggetto " + sfera.name);
            sfera = null;
        }
    }

    /*
    private void OnTriggerStay(Collider other)
    {
        ForzaSfera sfera = other.GetComponent<ForzaSfera>();

        if (sfera != null)
        {
            Debug.Log("� dentro l'oggetto " + other.name);
        }
    }*/

}
