using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBottomMap5 : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;

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
            player.transform.position = new Vector4(85.06f, -3.8f, 0f);
            camera.transform.position = new Vector4(93.36f, 0f, -10f);

        }
    }
}
