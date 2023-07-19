using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Obstacles;

    // Start is called before the first frame update
    void Start()
    {
        ObstacleSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ObstacleSpawn()
    {
        
            int pos = Random.Range(2, 5);
            Transform spawnPos = transform.GetChild(pos).transform;
            Instantiate(Obstacles, spawnPos.position, Quaternion.identity,transform);
        
    }
}
