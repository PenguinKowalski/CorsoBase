using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    public Vector3 distance;

    public void Start()
    {
        distance = target.position - this.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.position + distance;
    }
}
