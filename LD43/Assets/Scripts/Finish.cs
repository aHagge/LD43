using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public Game_manager gm;

    public Color red, green;

    public GameObject lighta;
    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<Game_manager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && Game_manager.finish)
        {
            gm.Nextlvl();
        }
    }

    private void FixedUpdate()
    {
        if(Game_manager.finish)
        {
            lighta.GetComponent<Light>().color = green;
        }
        else
        {
            lighta.GetComponent<Light>().color = red;
        }
    }
}

