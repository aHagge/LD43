using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour {

    public float speed = 10f;
    bool throwan;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(throwa());
        Destroy(gameObject, 5);
    }
    private void FixedUpdate()
    {
        if(throwan)
        {
            rb.AddForce(transform.up * speed);
        }
    }
    IEnumerator throwa()
        {
        yield return new WaitForSeconds(0.5f);
        GetComponent<Animator>().enabled = false;
        throwan = true;
        }
}
