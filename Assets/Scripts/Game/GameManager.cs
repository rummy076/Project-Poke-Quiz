using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject playerGO;
    public GameObject enemyGO;

    public Text playerName;
    public Text enemyName;
    public Text pLvl;
    public Text eLvl;

    public void Start()
    {
        
    }

    private void Update()
    {
        playerName.text = "Name: " + playerGO.GetComponent<playerScript>().unitName;
        enemyName.text = "Name: " + enemyGO.GetComponent<enemyScript>().unitName;

        pLvl.text = "LVL: " + playerGO.GetComponent<playerScript>().unitLvl;
        eLvl.text = "LVL: " + enemyGO.GetComponent<enemyScript>().unitLvl;
    }
}

