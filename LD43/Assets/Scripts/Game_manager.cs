using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Game_manager : MonoBehaviour {

    public Scene[] alllevels;
    public static int level = 1;
    public static bool finish;
    public  int[] lvlcoin;
    private static bool created = false;
    public static int total_coins ,level_coins;
    public static int total_deaths, level_deaths;

    public TextMeshProUGUI cointext;

	void Start () {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Nextlvl()
    {
        finish = false;
        level++;
        SceneManager.LoadScene(level);
        level_coins = 0;
        level_deaths = 0;
    }
	// Update is called once per frame
	void Update () {
        if (cointext != null)
        {
            cointext.text = level_coins.ToString() + "/" + lvlcoin[level];
        } else
        {
            cointext = GameObject.Find("Canvas/Coin text").GetComponent<TextMeshProUGUI>();
        }
        if(lvlcoin[level] <= level_coins)
        {
            finish = true;
        }
	}
}
