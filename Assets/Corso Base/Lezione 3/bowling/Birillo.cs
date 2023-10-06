using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birillo : MonoBehaviour
{
    [SerializeField]
    float origineY;
    [SerializeField]
    float distanza;

    RaycastHit RaycastHit;

    public bool Caduto = false;

    private void Update()
    {
        Caduto = true;

        Debug.DrawRay(this.transform.position-this.transform.up*origineY, -transform.up * distanza, Color.magenta);
        if (Physics.Raycast(this.transform.position-this.transform.up * origineY, -this.transform.up, out RaycastHit, distanza))
        {
            if (RaycastHit.collider.CompareTag("Terreno"))
            {
                Caduto = false;
            }
        }
   
    }

}
