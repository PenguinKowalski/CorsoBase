using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    // Start is called before the first frame update

    MeshRenderer meshRenderer;
    Camera cam;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        cam = Camera.main;
    }

    private void Update()
    {
        if (!meshRenderer.enabled)
        {
            Vector3 direction = this.transform.position - cam.transform.position;
            float angle = Vector3.Angle(cam.transform.forward, direction);

            if (direction.magnitude < 10f && angle < 90)
            {
                meshRenderer.enabled = true;
            }
        }
    }

    private void OnBecameVisible()
    {
       // meshRenderer.enabled = true;
    }
    private void OnBecameInvisible()
    {
        meshRenderer.enabled = false;
    }
}
