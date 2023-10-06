using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPersonaggio : MonoBehaviour
{
    [SerializeField]Camera cam;

    [SerializeField] float mouseSensitivity = 1f, speed = 1f;
    
  
    void Update()
    {
        //Movimento della camera
        float h = mouseSensitivity * Input.GetAxis("Mouse X");
        float v = -mouseSensitivity * Input.GetAxis("Mouse Y");
        
        this.transform.rotation *= Quaternion.Euler(0,h, 0);
        cam.transform.rotation *= Quaternion.Euler(v, 0, 0);
       

        //Traslazione
        Vector3 spostamento= Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            spostamento += transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            spostamento -= transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            spostamento -= transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            spostamento += transform.right;
        }

        spostamento = Vector3.Normalize(spostamento);

        Debug.Log(spostamento);
        this.transform.position += spostamento * Time.deltaTime * speed;
    }
}
