using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortailTP6 : MonoBehaviour
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
            player.transform.position = new Vector4(141.59f, -27.1f, 0f);
            camera.transform.position = new Vector4(149.9f, -24.5f, -10f);

        }
    }

}
