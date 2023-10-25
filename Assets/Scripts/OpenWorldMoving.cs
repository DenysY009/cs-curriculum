using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class OpenWorldMoving : MonoBehaviour
{
    public bool cave;
    public float walkingSpeed;
    public float xDirection;
    public float xVector;
    public float yVector;
    public float yDirection;
    // Use this for initialization
    void Start()
    {
        walkingSpeed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (cave != false)
        {
            xDirection = Input.GetAxis("Horizontal");
            xVector = xDirection * walkingSpeed * Time.deltaTime;
            transform.position = transform.position + new Vector3(xVector, 0, 0);
        }
        if (cave != true)
        {
            yDirection = Input.GetAxis("Vertical");
            yVector = yDirection * walkingSpeed * Time.deltaTime;
            transform.position = transform.position + new Vector3(0, yVector, 0);

            xDirection = Input.GetAxis("Horizontal");
            xVector = xDirection * walkingSpeed * Time.deltaTime;
            transform.position = transform.position + new Vector3(xVector, 0, 0);
        }
    }
}
