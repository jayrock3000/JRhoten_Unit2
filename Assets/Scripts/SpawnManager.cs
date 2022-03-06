using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //private int animalPrefabIndex;
    private float xPosRange = 13.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            float randXPos = Random.Range(-xPosRange, xPosRange);
            int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 randPosition = new Vector3(randXPos, 0.0f, 21.0f);
            Instantiate(animalPrefabs[animalPrefabIndex], randPosition, 
                animalPrefabs[animalPrefabIndex].transform.rotation);
        }
    }
}
