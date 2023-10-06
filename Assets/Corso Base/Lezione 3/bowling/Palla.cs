using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum StatoTiro {Posizione, Rotazione, Forza, Tiro }
public class Palla : MonoBehaviour
{
    public float posizione = 0.5f, rotazione=0.5f, potenza=0f;
    public float speedPos = 1f, speedRot = 1f, speedPotenza = 1f, potenzaEffetto = 1f;
    public float larghezza=0.5f, ampiezza=20f, potenzaMax=3f;
    public float scalaPotenza = 10f;
    Vector3 startPosition, startRotation;

    public StatoTiro stato;

    public Transform cubettorosso;

    public Rigidbody pallaRb;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        startRotation = this.transform.rotation.eulerAngles;
        pallaRb = this.GetComponent<Rigidbody>();
        stato = StatoTiro.Posizione;
        cubettorosso.gameObject.SetActive(true);
        pallaRb.isKinematic = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (stato == StatoTiro.Posizione)
            {
                stato = StatoTiro.Rotazione;
            }
            else if (stato == StatoTiro.Rotazione)
            {
                stato = StatoTiro.Forza;
            }
            else if (stato == StatoTiro.Forza)
            {
                Tiro();
            }
        }

        if (stato==StatoTiro.Posizione)
        {
            
            posizione = Mathf.PingPong(Time.time*speedPos, 1);

            this.transform.position = Vector3.Lerp(
                              startPosition + new Vector3(0, 0, larghezza),
                              startPosition + new Vector3(0, 0, -larghezza),
                              posizione);


        }
        
        if (stato == StatoTiro.Rotazione)
        {

            rotazione = Mathf.PingPong(Time.time * speedRot, 1);

            this.transform.rotation = Quaternion.Euler (Vector3.Lerp(
                              startPosition + new Vector3(0, ampiezza, 0),
                              startPosition + new Vector3(0, -ampiezza, 0),
                              rotazione)
                              );


        }
        
        if (stato == StatoTiro.Forza)
        {

            potenza = Mathf.PingPong(Time.time * speedPotenza, 1);

            cubettorosso.localScale = Vector3.Lerp(
                              new Vector3(0, 1f, 1f),
                              new Vector3(potenzaMax, 1f, 1f),
                              potenza);
        }
        
    }

    private void Tiro()
    {
        stato = StatoTiro.Tiro;
        cubettorosso.gameObject.SetActive(false);
        pallaRb.isKinematic = false;
        pallaRb.AddForce(potenza * scalaPotenza * -this.transform.right, ForceMode.Impulse);
    }
}
