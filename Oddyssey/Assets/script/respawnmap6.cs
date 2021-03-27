using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnmap6 : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void respawnmap() 
    { 
        player.transform.position = new Vector4(115.9081f, -27.5f, 0f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            respawnmap();
        }
    }
}
