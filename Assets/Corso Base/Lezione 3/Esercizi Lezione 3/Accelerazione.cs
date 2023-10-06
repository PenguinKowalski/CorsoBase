using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerazione : MonoBehaviour
{
    public float StartSpeed;

    public float speed;
    public float acc;
    // Start is called before the first frame update
    void Start()
    {
        speed = StartSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        speed += acc * Mathf.Pow(Time.deltaTime, 2);

        this.transform.position += this.transform.forward * speed * Time.deltaTime;
    }
}
