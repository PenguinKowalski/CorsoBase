using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input0 : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0f;
    public KeyCode KeyCode = KeyCode.Space;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode))
        {
            timer = 0;
        }

        if (Input.GetKey(KeyCode))
        {
            timer += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode))
        {
            Debug.Log("timer= " + timer);      
        }
        

    }
}
