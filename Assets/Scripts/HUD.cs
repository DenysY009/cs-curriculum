using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
public class HUD : MonoBehaviour
{
    public static HUD gm;
    
    public int health;
    public int coins;
    int maxHealth = 5;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    private void Awake()
    {
        if (gm != null & gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(this);
             
        }
    }
    // Use this for initialization
    void Start()
    {
        coins = 0;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins" + coins;
        healthText.text = "Heath" + health;
      
    }
}
