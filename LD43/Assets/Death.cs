using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    public GameObject lik;
    public Vector3 deathpoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            deathpoint = col.gameObject.transform.position;
            Destroy(col.gameObject);
            Instantiate(lik, deathpoint, Quaternion.identity);
        }
    }
}
