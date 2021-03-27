using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortailTP3 : MonoBehaviour
{
    //Player
    public GameObject player;



    //camera
    public GameObject camera;


    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            player.transform.position = new Vector4(62.99636f, -3.8f, 0f);
            camera.transform.position = new Vector4(71.24f, 0f, -10f);

        }
    }
}
