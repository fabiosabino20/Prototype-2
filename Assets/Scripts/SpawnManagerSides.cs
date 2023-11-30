using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerSides : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeZMin = 3f;
    private float spawnRangeZMax = 12f;
    private float startDelay = 1f;
    private float spawnInterval = 2f;
    private Quaternion animalPrefabRotation = Quaternion.Euler(0, -90, 0); // if (gameObject.tag == "SpawnManagerRight")

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float spawnPosX = 26f;

        if (gameObject.tag == "SpawnManagerLeft")
        {
            animalPrefabRotation = Quaternion.Euler(0, 90, 0);
            spawnPosX *= -1;
        }

        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZMin, spawnRangeZMax));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabRotation);
    }
}