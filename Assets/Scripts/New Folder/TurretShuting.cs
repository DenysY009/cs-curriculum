using UnityEngine;
using System.Collections;

public class TurretShuting : MonoBehaviour
{
    public GameObject Projectile;
    public Transform ProjectilePos;
    private float timer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
            timer += Time.deltaTime;

            if(timer>2)
            {
                timer = 0;
                shoot();
            }

        }
       
               void shoot()
        {
            Instantiate(Projectile, ProjectilePos.position,Quaternion.identity);
        }
           
        
    }

