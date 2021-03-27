using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortailTP5 : MonoBehaviour
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
            player.transform.position = new Vector4(115.9081f, -27.5f, 0f);
            camera.transform.position = new Vector4(123.96f, -24.13f, -10f);

        }
    }
}
