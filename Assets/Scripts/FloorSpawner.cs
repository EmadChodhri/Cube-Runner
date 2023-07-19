using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject floor;
    Vector3 nextSpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFloor", 0.1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
         
    }

    public void SpawnFloor()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject spawn = Instantiate(floor, nextSpawnPos, Quaternion.identity);
            nextSpawnPos = spawn.transform.GetChild(1).transform.position;
        }
    }
}
