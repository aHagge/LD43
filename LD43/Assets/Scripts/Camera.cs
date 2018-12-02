using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Transform target;
    public Vector3 offset;
    public float smoothSpeed;


    void FixedUpdate()
    {
        if (target != null)
        {
            print("hola");
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, target.position + offset, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        } else
        {
            target = GameObject.Find("Player").transform;
        }

    }
}

