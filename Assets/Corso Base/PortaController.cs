using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaController : MonoBehaviour
{
    public GameObject porta, cubo;
    public Vector3 postEnd;
    Vector3 rotationTarget =  new Vector3(0, 90, 0);
    Vector3 rotationStart = new Vector3(0, 0, 0);

    Vector3 target;


    Vector3 rotationSpeed = new Vector3(0, 1, 0);
    public int speed = 10;
    // Start is called before the first frame update
    bool isAnimation = false;
 
    void Start()
    {
        target = rotationStart;
        // posStart = cubo.transform.position;

        LeanTween.move(cubo, postEnd, 1f).setLoopPingPong().setEaseInOutElastic();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A) && !isAnimation)
        {
            isAnimation = true;
            if (target == rotationStart)
            {
                target = rotationTarget;
            }
            else
            {
                target = rotationStart;
            }
           // LeanTween.cancel(porta);
            LeanTween.rotate(porta, target, 1f).setEaseInCubic().setOnComplete(() => { isAnimation = false; });
        }
        
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            isAnimation = true;
        }

        if (isAnimation)
        {
            porta.transform.rotation *= Quaternion.Euler(rotationSpeed * Time.deltaTime*speed);
            if (porta.transform.rotation.eulerAngles.y > rotationTarget.y)
            {
                isAnimation = false;
            }
        }
     */

    }
}
