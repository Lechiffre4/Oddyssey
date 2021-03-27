using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonetpMap5 : MonoBehaviour
{
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
            
            camera.transform.position = new Vector4(93.36f, -24.05f, -10f);

        }
    }
}
