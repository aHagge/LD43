using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour {

    public float speed;
    bool throwan;
    Rigidbody rb;
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("Throw");
        transform.rotation = transform.parent.rotation;
        rb = GetComponent<Rigidbody>();
        StartCoroutine(throwa());
        Destroy(gameObject, 5);
    }
    private void FixedUpdate()
    {
        if(throwan)
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }
    }
    IEnumerator throwa()
        {
        yield return new WaitForSeconds(0.5f);
        GetComponent<Animator>().enabled = false;
        throwan = true;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject,0.1f);
    }


}
