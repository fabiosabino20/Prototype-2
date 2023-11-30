using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float xBound = 28f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the objects outside the screen
        if (transform.position.z > topBound || transform.position.x > xBound || transform.position.x < -xBound)
        {
            Destroy(gameObject);
        }
        //
        else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
