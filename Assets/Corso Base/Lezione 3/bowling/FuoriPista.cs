using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuoriPista : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
            rb.velocity = Vector3.zero;
            rb.gameObject.SetActive(false);
        }
    }
}
