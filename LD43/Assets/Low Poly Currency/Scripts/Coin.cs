using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {


    public GameObject Takeneffect;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Game_manager.level_coins++;
            Game_manager.total_coins++;
            Instantiate(Takeneffect, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
