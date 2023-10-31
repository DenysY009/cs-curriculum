using UnityEngine;
using System.Collections;

public class NewMonoBehaviour : MonoBehaviour
{
    private Vector3 Target; 
    private float timer;
    private float originalTimer;
    private GameObject player;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        originalTimer = 6;
        timer = originalTimer;
        Target = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {


        }
        if (Target !=null)
        {
            transform.position = Vector3.MoveTowards(current: transform.position, Target, maxDistanceDelta:100);
        }   
               
               
           
        
    }
}
