using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portailTP4 : MonoBehaviour
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
            player.transform.position = new Vector4(85.06f, -3.8f, 0f);
            camera.transform.position = new Vector4(93.36f, 0f, -10f);

        }
    }
}
