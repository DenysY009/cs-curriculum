using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
public class HealthBar : MonoBehaviour
{
    bool iframes = false;
    private HUD gm;
    private float timer;
    float originalTimer;
    private float xVector;
    private float yVector;
    private void Start()
    {
        gm = GameObject.FindAnyObjectByType<HUD>();

        originalTimer = 1.5f;
        timer = originalTimer;
    }
    private void Update()
    {
        if (iframes)
        {
            timer -= Time.deltaTime;

            if (timer < 0);
            {
                iframes = false;
                timer = originalTimer;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            ChangeHealth(-1);
            

            transform.position = transform.position + new Vector3(xVector - 1, yVector + 1, 0);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Potion"))
        {
            ChangeHealth(1);
         }
    }
    void ChangeHealth(int amount)
    {
        if(iframes)
        {
            iframes = true;
            gm.health += amount;
            if (gm.health < 1)
            {
                Death();
            }
        }
      
    }
    void Death()
    {
        Debug.Log("You Dead");

        print("You Dead");
    }


}