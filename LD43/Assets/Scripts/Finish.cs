using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public Game_manager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<Game_manager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        gm.Nextlvl();
    }
}

