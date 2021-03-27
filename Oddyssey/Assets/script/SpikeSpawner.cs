using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    
    public Transform[] SpawnPoints;
    public GameObject blockPrefabs;
    private float timeTospawn = 2f;
    public float timebetweenSpawn = 1f;
    // Start is called before the first frame update
    void SpawnSpikes()
    {
       int randomIndex = Random.Range(0, SpawnPoints.Length);

       Instantiate(blockPrefabs, SpawnPoints[randomIndex].position, Quaternion.identity);
        

    }
   
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timeTospawn)
        {
            SpawnSpikes();
            timeTospawn = Time.time + timebetweenSpawn;
            
        }
        
    }

   


}
