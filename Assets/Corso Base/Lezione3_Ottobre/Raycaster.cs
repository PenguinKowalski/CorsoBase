using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public float maxDistance = 10f;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Physics.Raycast(this.transform.position, this.transform.up, out hit, maxDistance))
        {
            Debug.Log("contatto con " + hit.collider);
            Debug.DrawLine(this.transform.position, hit.point, Color.magenta);
        }
    }
}
