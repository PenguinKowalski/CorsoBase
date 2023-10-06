using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForzaSfera : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
   [SerializeField] Vector3 direzioneLancio, posizioneForza;
    [SerializeField] float forzaLancio;

    bool isSpacePressed=false;
    void Start()
    {
        rb= this.GetComponent<Rigidbody>();
        direzioneLancio = direzioneLancio.normalized;
                        // Vector3.Normalize(direzioneLancio)
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSpacePressed = true;
        }



        //isSpacePressed = Input.GetKey(KeyCode.Space);
    }

    /* CASO CONTINUO
    private void FixedUpdate()
    {
        if (isSpacePressed) {
            rb.AddForce(direzioneLancio * forzaLancio, ForceMode.Force);
        }
    }
    */

    //CASO IMPULSO
    private void FixedUpdate()
    {
        if (isSpacePressed)
        {
            rb.AddForce(direzioneLancio * forzaLancio, ForceMode.Impulse);
          //  rb.AddForceAtPosition(direzioneLancio * forzaLancio, posizioneForza, ForceMode.Impulse);
            isSpacePressed=false;
        }
    }
}
