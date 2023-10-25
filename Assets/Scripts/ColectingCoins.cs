using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ColectingCoins : MonoBehaviour

{
   private HUD gm;
    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindObjectOfType<HUD>();
    }
    private void Update()
    {
        
    }
    // Update is called once per frame

    private void OnTrigerEnter2D(Collider2D other)
        {
        if (other.gameObject.CompareTag("Coins"))
        {
            gm.coins++;
            other.gameObject.SetActive(false);
            }
        }
    }