using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPersonaggioFisico : MonoBehaviour
{
    Rigidbody body;

    [SerializeField]Camera cam;

    [SerializeField] float mouseSensitivity = 1f, speed = 1f;

    Vector3 spostamento = Vector3.zero;
    private void Start()
    {
        body = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Movimento della camera
        float h = mouseSensitivity * Input.GetAxis("Mouse X");
        float v = -mouseSensitivity * Input.GetAxis("Mouse Y");
        
        this.transform.rotation *= Quaternion.Euler(0,h, 0);
        cam.transform.rotation *= Quaternion.Euler(v, 0, 0);


        //Traslazione
        spostamento = Vector3.zero;

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

        
    }

    private void FixedUpdate()
    {
       
        body.MovePosition(body.position + spostamento * Time.fixedDeltaTime * speed);
        //body.
        // body.velocity = spostamento*speed* Time.fixedDeltaTime;
        //body.AddForce(spostamento * speed, ForceMode.VelocityChange);
    }
}
