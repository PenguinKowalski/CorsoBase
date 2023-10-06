using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forza : MonoBehaviour
{
    [SerializeField]
    Vector3 forza;
    // Start is called before the first frame update
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    bool execute = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            execute = true;
        }
    }
    private void FixedUpdate()
    {
        if (execute)
        {
            rb.AddForce(forza, ForceMode.Impulse);
            execute = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        
    }

   
}
