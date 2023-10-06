using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField]
    Vector3 origine, direzione;
    public float distanzaMax;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        origine = this.transform.position;
        Debug.DrawRay(origine, transform.forward*distanzaMax, Color.magenta);

        if (Physics.Raycast(origine, transform.forward, out hit, distanzaMax))
        {
            Debug.Log(hit.collider.name);
            Forza forza = hit.collider.gameObject.GetComponentInParent<Forza>();
            if (forza != null)
            {
                Debug.Log("FORZA" + hit.collider.name);
            }

        }
    }
}
