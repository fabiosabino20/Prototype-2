using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnTimer = 0;

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnTimer<=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnTimer = 2;
        }
    }
}
