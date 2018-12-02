using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    public GameObject lik;
    public Transform deathpoint;
    public GameObject Playerprefab;
    public Transform Spawnpos;
    public bool Makelik;

	void Start () {
        Spawnpos = GameObject.Find("Spawnpos").transform;
	}
	
	void Update () {
        Spawnpos = GameObject.Find("Spawnpos").transform;
	}
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            deathpoint = col.gameObject.transform;
            Destroy(col.gameObject);
            if(Makelik)
            {
                Instantiate(lik, deathpoint.position, Quaternion.Euler( new Vector3(deathpoint.transform.eulerAngles.x - 180, deathpoint.transform.eulerAngles.y, deathpoint.transform.eulerAngles.z - 180)));
            }
            int players = (GameObject.FindGameObjectsWithTag("Player").Length);
            if(players == 1)
            {
                Instantiate(Playerprefab, Spawnpos.position, Quaternion.identity);
            }
        }
    }
}
