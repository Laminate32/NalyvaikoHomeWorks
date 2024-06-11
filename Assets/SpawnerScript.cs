using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
        void SpawnObject()
        {
            Instantiate(ObjectToSpawn, transform.position, transform.rotation);
        }
    }
}
