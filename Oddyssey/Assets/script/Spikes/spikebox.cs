using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikebox : MonoBehaviour
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

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            player.transform.position = new Vector4(62.99636f, -3.8f, 0f);


        }
    }
}
