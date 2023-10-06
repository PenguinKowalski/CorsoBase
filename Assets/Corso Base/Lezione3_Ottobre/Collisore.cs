using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisore : MonoBehaviour
{
    ForzaSfera sfera = null;
    public GameObject crepaPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("� entrato collisione l'oggetto " + collision.collider.name);
        GameObject.Instantiate(crepaPrefab,collision.GetContact(0).point, Quaternion.identity);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("� uscito collisione l'oggetto " + collision.collider.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("� dentro collisione l'oggetto " + collision.collider.name);
    }
  
}
