using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger start for " + other.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger end for " + other.name);

    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("trigger stay for " + other.name);

    }

}
