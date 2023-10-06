using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCamera : MonoBehaviour
{
    Camera cam;

    RaycastHit RaycastHit;
    void Start()
    {
        cam = this.GetComponent<Camera>();
    }

    void Update()
    {
        Vector3 point = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));

        Vector3 direzione = point - this.transform.position;

        Debug.DrawRay(this.transform.position, direzione * 100, Color.magenta);
        if (Physics.Raycast(this.transform.position, direzione, out RaycastHit))
        {
            Debug.Log("HIT" + RaycastHit.collider.name);
        }
       
    }
}
