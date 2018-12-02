using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour {

    public Transform spawn;
    public GameObject spearprefab;

	void Start () {
        InvokeRepeating("Spawnspear", 0, 1);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Spawnspear()
    {
        print("lol");
        Instantiate(spearprefab, spawn.position, spawn.rotation);
    }
}
