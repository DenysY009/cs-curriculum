using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyBulletScript : MonoBehaviour
{
    private GameObject Player;
    private Rigidbody2D rb;
    public float force;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = Player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
