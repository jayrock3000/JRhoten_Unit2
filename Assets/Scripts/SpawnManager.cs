using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xPosRange = 13.0f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1.0f);
    }

    void SpawnRandomAnimal()
    {
        float randXPos = Random.Range(-xPosRange, xPosRange);
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 randPosition = new Vector3(randXPos, 0.0f, 21.0f);
        Instantiate(animalPrefabs[animalPrefabIndex], randPosition,
            animalPrefabs[animalPrefabIndex].transform.rotation);
    }
}
