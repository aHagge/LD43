using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    public GameObject lik;
    public Vector3 deathpoint;
    public GameObject Playerprefab;
    public Transform Spawnpos;
    public bool Makelik;

	void Start () {
        Spawnpos = GameObject.Find("Spawnpos").transform;
	}
	
	void Update () {
		
	}
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            deathpoint = col.gameObject.transform.position;
            Destroy(col.gameObject);
            if(Makelik)
            {
                Instantiate(lik, deathpoint, Quaternion.identity);
            }
            Instantiate(Playerprefab, Spawnpos.position, Quaternion.identity);
        }
    }
}
