using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour {

    public Transform spawn;
    public GameObject spearprefab;

	void Start () {
        InvokeRepeating("Spawnspear", 0, 2.5f);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Spawnspear()
    {
        Instantiate(spearprefab, spawn);
    }
}
