using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTP1 : MonoBehaviour
{
    //Player
    public GameObject player;


    
    //camera
    public GameObject camera;
    

    void Start() {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            player.transform.position = new Vector4(16.72f,-3.8f,0f);
            camera.transform.position = new Vector4(24.95f,0f,-10f);

        }
    }

  
}
